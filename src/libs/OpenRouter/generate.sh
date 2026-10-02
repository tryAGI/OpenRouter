#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# OpenAPI spec: https://openrouter.ai/openapi.json
install_autosdk_cli
fetch_spec --fail --silent --show-error -L -o openapi.json https://openrouter.ai/openapi.json

# Fix 1: Add top-level security array (spec defines securitySchemes but no top-level security).
# Fix 2: Rename schemas with spaces ("API Keys_*" -> "ApiKeys*") to avoid C# compilation issues.
# Fix 3: Remove per-operation "Authorization" header parameters (redundant with securitySchemes;
#         causes generated methods to require an explicit authorization string parameter).
# Fix 4: Flatten single-reference observability response wrappers; their allOf otherwise
#         inherits from a sealed oneOf model in generated C#.
# Fix 5: Keep observability rule operators as strings because the wire value "equals"
#         collides with the generated C# value type's Equals members.
# Fix 6: Replace credential-shaped upstream examples before persisting or generating code.
jq '
  .security = [{"bearer": []}]
  | .components.schemas = (
      .components.schemas | to_entries |
      map(
        if .key | startswith("API Keys_") then
          .key = (.key | gsub("API Keys_"; "ApiKeys_"))
        else . end
      ) | from_entries
    )
  | walk(
      if type == "object" and has("$ref") then
        .["$ref"] = (.["$ref"] | gsub("API Keys_"; "ApiKeys_"))
      else . end
    )
  | .paths |= with_entries(
      .value |= with_entries(
        if .key == "get" or .key == "post" or .key == "put" or .key == "delete" or .key == "patch" then
          .value.parameters = [.value.parameters[]? | select(.name != "Authorization")]
        else . end
      )
    )
  | (.components.schemas.CreateObservabilityDestinationResponse.properties.data,
     .components.schemas.GetObservabilityDestinationResponse.properties.data,
     .components.schemas.UpdateObservabilityDestinationResponse.properties.data) |=
      {"$ref": "#/components/schemas/ObservabilityDestination"}
  | del(.components.schemas.ObservabilityFilterRuleGroup.properties.rules.items.properties.operator.enum)
  | walk(
      if type == "string" and test("^sk-or-v1-[A-Za-z0-9]{20,}$") then
        "example-api-key"
      else . end
    )
' openapi.json > openapi.json.tmp && mv openapi.json.tmp openapi.json

# Rename to YAML extension so AutoSDK recognizes it
mv openapi.json openapi.yaml

rm -rf Generated
autosdk generate openapi.yaml \
  --namespace OpenRouter \
  --clientClassName OpenRouterClient \
  --targetFramework net10.0 \
  --output Generated \
  --strip-redundant-operation-id-tag-prefixes \
  --exclude-deprecated-operations
