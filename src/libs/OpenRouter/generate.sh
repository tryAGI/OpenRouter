#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://openrouter.docs.buildwithfern.com/api/openapi.json

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L -o openapi.json https://openrouter.docs.buildwithfern.com/api/openapi.json

# Fix 1: Add top-level security array (spec defines securitySchemes but no top-level security).
# Fix 2: Rename schemas with spaces ("API Keys_*" -> "ApiKeys*") to avoid C# compilation issues.
# Fix 3: Remove per-operation "Authorization" header parameters (redundant with securitySchemes;
#         causes generated methods to require an explicit authorization string parameter).
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
' openapi.json > openapi.json.tmp && mv openapi.json.tmp openapi.json

# Rename to YAML extension so AutoSDK recognizes it
mv openapi.json openapi.yaml

autosdk generate openapi.yaml \
  --namespace OpenRouter \
  --clientClassName OpenRouterClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
