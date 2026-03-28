#pragma warning disable CS3002 // Return type is not CLS-compliant
using System.Text.Json;
using Microsoft.Extensions.AI;

namespace OpenRouter;

/// <summary>
/// Extensions for using OpenRouterClient as MEAI tools with any IChatClient.
/// </summary>
public static class OpenRouterToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists available models on OpenRouter
    /// with their pricing, context length, and capabilities.
    /// </summary>
    /// <param name="client">The OpenRouter client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsListModelsTool(this OpenRouterClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string? category, CancellationToken cancellationToken) =>
            {
                var response = await client.SubpackageModels.GetModelsAsync(
                    category: category is not null
                        ? ModelsGetParametersCategoryExtensions.ToEnum(category)
                        : null,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatModelsResponse(response);
            },
            name: "ListOpenRouterModels",
            description: "Lists available AI models on OpenRouter with pricing and capabilities. " +
                         "Optionally filter by category: roleplay, programming, marketing, marketing/seo, " +
                         "technology, science, academia, legal, finance, health, translation, trivia. " +
                         "Pass null for all models.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that gets details for a specific model
    /// by searching the model list.
    /// </summary>
    /// <param name="client">The OpenRouter client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetModelTool(this OpenRouterClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string modelId, CancellationToken cancellationToken) =>
            {
                var response = await client.SubpackageModels.GetModelsAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                var model = response.Data.FirstOrDefault(m =>
                    string.Equals(m.Id, modelId, StringComparison.OrdinalIgnoreCase));

                if (model is null)
                {
                    return $"Model '{modelId}' not found. Use ListOpenRouterModels to see available models.";
                }

                return FormatModelDetails(model);
            },
            name: "GetOpenRouterModel",
            description: "Gets detailed information about a specific OpenRouter model by its ID " +
                         "(e.g., 'openai/gpt-4o', 'anthropic/claude-sonnet-4'). " +
                         "Returns pricing, context length, supported parameters, and capabilities.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that retrieves generation stats
    /// for a specific request by generation ID.
    /// </summary>
    /// <param name="client">The OpenRouter client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetGenerationTool(this OpenRouterClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string generationId, CancellationToken cancellationToken) =>
            {
                var response = await client.SubpackageGenerations.GetGenerationAsync(
                    id: generationId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatGenerationResponse(response);
            },
            name: "GetOpenRouterGeneration",
            description: "Gets generation stats for a specific OpenRouter request by its generation ID. " +
                         "Returns token counts, cost, latency, provider info, and finish reason.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that retrieves the current credit balance.
    /// </summary>
    /// <param name="client">The OpenRouter client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsGetCreditsTool(this OpenRouterClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.SubpackageCredits.GetCreditsAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                var data = response.Data;
                var remaining = data.TotalCredits - data.TotalUsage;

                return $"Credits: ${data.TotalCredits:F4} total, ${data.TotalUsage:F4} used, ${remaining:F4} remaining";
            },
            name: "GetOpenRouterCredits",
            description: "Gets the current OpenRouter credit balance, showing total credits purchased, " +
                         "total usage, and remaining balance in USD.");
    }

    private static string FormatModelsResponse(ModelsListResponse response)
    {
        var parts = new List<string>
        {
            $"Available models: {response.Data.Count}",
            "",
        };

        foreach (var model in response.Data)
        {
            var entry = $"- {model.Id} ({model.Name})";

            if (model.ContextLength.HasValue)
            {
                entry += $" | ctx: {model.ContextLength:N0}";
            }

            entry += $" | prompt: ${model.Pricing.Prompt}/token, completion: ${model.Pricing.Completion}/token";

            if (model.Architecture.Modality is not null)
            {
                entry += $" | {model.Architecture.Modality}";
            }

            parts.Add(entry);
        }

        return string.Join("\n", parts);
    }

    private static string FormatModelDetails(Model model)
    {
        var parts = new List<string>
        {
            $"Model: {model.Id}",
            $"Name: {model.Name}",
        };

        if (!string.IsNullOrWhiteSpace(model.Description))
        {
            parts.Add($"Description: {model.Description}");
        }

        if (model.ContextLength.HasValue)
        {
            parts.Add($"Context Length: {model.ContextLength:N0} tokens");
        }

        parts.Add($"Pricing: prompt=${model.Pricing.Prompt}/token, completion=${model.Pricing.Completion}/token");

        if (model.Architecture.Modality is not null)
        {
            parts.Add($"Modality: {model.Architecture.Modality}");
        }

        if (model.Architecture.InputModalities is { Count: > 0 })
        {
            parts.Add($"Input: {string.Join(", ", model.Architecture.InputModalities)}");
        }

        if (model.Architecture.OutputModalities is { Count: > 0 })
        {
            parts.Add($"Output: {string.Join(", ", model.Architecture.OutputModalities)}");
        }

        if (model.TopProvider.MaxCompletionTokens.HasValue)
        {
            parts.Add($"Max Completion Tokens: {model.TopProvider.MaxCompletionTokens:N0}");
        }

        if (model.SupportedParameters is { Count: > 0 })
        {
            parts.Add($"Supported Parameters: {string.Join(", ", model.SupportedParameters)}");
        }

        if (!string.IsNullOrWhiteSpace(model.KnowledgeCutoff))
        {
            parts.Add($"Knowledge Cutoff: {model.KnowledgeCutoff}");
        }

        return string.Join("\n", parts);
    }

    private static string FormatGenerationResponse(GenerationsGetGenerationResponse200 response)
    {
        var data = response.Data;
        var parts = new List<string>
        {
            $"Generation: {data.Id}",
            $"Model: {data.Model}",
            $"Cost: ${data.TotalCost:F6}",
            $"Created: {data.CreatedAt}",
        };

        if (data.ProviderName is not null)
        {
            parts.Add($"Provider: {data.ProviderName}");
        }

        if (data.TokensPrompt.HasValue)
        {
            parts.Add($"Prompt Tokens: {data.TokensPrompt:N0}");
        }

        if (data.TokensCompletion.HasValue)
        {
            parts.Add($"Completion Tokens: {data.TokensCompletion:N0}");
        }

        if (data.Latency.HasValue)
        {
            parts.Add($"Latency: {data.Latency:N0}ms");
        }

        if (data.GenerationTime.HasValue)
        {
            parts.Add($"Generation Time: {data.GenerationTime:N0}ms");
        }

        if (data.FinishReason is not null)
        {
            parts.Add($"Finish Reason: {data.FinishReason}");
        }

        if (data.Streamed.HasValue)
        {
            parts.Add($"Streamed: {data.Streamed}");
        }

        return string.Join("\n", parts);
    }
}
