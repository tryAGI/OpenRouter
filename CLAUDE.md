# CLAUDE.md -- OpenRouter SDK

## Overview

Auto-generated C# SDK for [OpenRouter](https://openrouter.ai/) -- LLM gateway with 500+ models, model discovery, routing, generation stats, and credit management.
OpenAPI spec from the Fern-hosted documentation at `https://openrouter.docs.buildwithfern.com/api/openapi.json`.

## Build & Test

```bash
dotnet build OpenRouter.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth:

```csharp
var client = new OpenRouterClient(apiKey); // OPENROUTER_API_KEY env var
```

## Key Files

- `src/libs/OpenRouter/openapi.yaml` -- OpenAPI spec (downloaded and fixed from Fern docs)
- `src/libs/OpenRouter/generate.sh` -- Downloads spec, fixes auth/schemas, runs autosdk
- `src/libs/OpenRouter/Generated/` -- **Never edit** -- auto-generated code (~3200 files)
- `src/libs/OpenRouter/Extensions/OpenRouterClient.Tools.cs` -- MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Sub-client Pattern

```csharp
var client = new OpenRouterClient(apiKey);

// Models -- discover available models
client.SubpackageModels.GetModelsAsync()           // List all models
client.SubpackageModels.ListModelsCountAsync()      // Get model count
client.SubpackageModels.ListModelsUserAsync()        // List user's models

// Chat -- completions (OpenAI-compatible)
client.SubpackageChat.SendChatCompletionRequestAsync(...)

// Embeddings
client.SubpackageEmbeddings.CreateEmbeddingsAsync(...)

// Generations -- request stats
client.SubpackageGenerations.GetGenerationAsync(id)

// Credits -- balance
client.SubpackageCredits.GetCreditsAsync()

// Providers
client.SubpackageProviders.ListProvidersAsync()

// API Keys
client.SubpackageApiKeys.ListAsync()
client.SubpackageApiKeys.CreateKeysAsync(...)

// Guardrails
client.SubpackageGuardrails.ListGuardrailsAsync()

// Endpoints
client.SubpackageEndpoints.ListEndpointsAsync(author, slug)
```

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsListModelsTool()` -- List available models with pricing and capabilities
- `AsGetModelTool()` -- Get details for a specific model by ID
- `AsGetGenerationTool()` -- Get generation stats by generation ID
- `AsGetCreditsTool()` -- Get current credit balance

## Spec Notes

- Base URL: `https://openrouter.ai/api/v1`
- OpenAPI 3.1.0, 28 endpoints, ~1182 schemas
- `generate.sh` fixes: adds top-level `security` array, renames "API Keys_*" schemas, removes per-operation `Authorization` header parameters
- `SYSLIB1031` warnings suppressed in csproj (duplicate JsonSerializerContext type names from deep oneOf nesting)
- Chat completions are OpenAI-compatible; for MEAI `IChatClient`, use `CustomProviders.OpenRouter()` from `tryAGI.OpenAI`
