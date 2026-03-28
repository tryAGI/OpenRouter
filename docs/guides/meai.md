# Microsoft.Extensions.AI Integration

The OpenRouter SDK provides `AIFunction` tools for use with any `IChatClient` through [Microsoft.Extensions.AI](https://www.nuget.org/packages/Microsoft.Extensions.AI).

## Available Tools

### ListOpenRouterModels

Lists available AI models on OpenRouter with pricing and capabilities. Supports category filtering.

```csharp
using OpenRouter;
using Microsoft.Extensions.AI;

var client = new OpenRouterClient(apiKey);
var tool = client.AsListModelsTool();
// Add to ChatOptions.Tools for any IChatClient
```

### GetOpenRouterModel

Gets detailed information about a specific model by ID, including pricing, context length, and supported parameters.

```csharp
var tool = client.AsGetModelTool();
```

### GetOpenRouterGeneration

Retrieves generation stats (token counts, cost, latency, provider info) for a specific request.

```csharp
var tool = client.AsGetGenerationTool();
```

### GetOpenRouterCredits

Gets the current credit balance showing total, used, and remaining.

```csharp
var tool = client.AsGetCreditsTool();
```

## Usage with IChatClient

```csharp
using OpenRouter;
using Microsoft.Extensions.AI;

var openRouterClient = new OpenRouterClient(openRouterApiKey);
IChatClient chatClient = /* any IChatClient (OpenAI, Anthropic, etc.) */;

var response = await chatClient.GetResponseAsync(
    "What models are available for programming on OpenRouter?",
    new ChatOptions
    {
        Tools =
        [
            openRouterClient.AsListModelsTool(),
            openRouterClient.AsGetModelTool(),
            openRouterClient.AsGetCreditsTool(),
        ],
    });
```

## Note on Chat Completions

For using OpenRouter as an `IChatClient` for chat completions (which are OpenAI-compatible),
use `CustomProviders.OpenRouter()` from the `tryAGI.OpenAI` package instead:

```csharp
using OpenAI;

var client = CustomProviders.OpenRouter(openRouterApiKey);
IChatClient chatClient = client;
```
