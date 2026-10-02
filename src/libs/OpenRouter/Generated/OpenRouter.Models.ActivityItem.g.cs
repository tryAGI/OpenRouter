
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"byok_usage_inference":0.012,"cached_tokens":10,"completion_tokens":125,"date":"2025-08-24","endpoint_id":"550e8400-e29b-41d4-a716-446655440000","model":"openai/gpt-4.1","model_permaslug":"openai/gpt-4.1-2025-04-14","prompt_tokens":50,"provider_name":"OpenAI","reasoning_tokens":25,"requests":5,"usage":0.015}
    /// </summary>
    public sealed partial class ActivityItem
    {
        /// <summary>
        /// BYOK inference cost in USD (external credits spent)<br/>
        /// Example: 0.012F
        /// </summary>
        /// <example>0.012F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("byok_usage_inference")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ByokUsageInference { get; set; }

        /// <summary>
        /// Total prompt tokens read from the provider prompt cache (cache hits). Generally a subset of `prompt_tokens`; for replayed response-cache hits the provider may report the two counters over disjoint token sets, so `cached_tokens` can exceed `prompt_tokens`.<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CachedTokens { get; set; }

        /// <summary>
        /// Total completion tokens generated<br/>
        /// Example: 125
        /// </summary>
        /// <example>125</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CompletionTokens { get; set; }

        /// <summary>
        /// Date of the activity (YYYY-MM-DD format)<br/>
        /// Example: 2025-08-24
        /// </summary>
        /// <example>2025-08-24</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Date { get; set; }

        /// <summary>
        /// Unique identifier for the endpoint<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndpointId { get; set; }

        /// <summary>
        /// Model slug (e.g., "openai/gpt-4.1")<br/>
        /// Example: openai/gpt-4.1
        /// </summary>
        /// <example>openai/gpt-4.1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Model permaslug (e.g., "openai/gpt-4.1-2025-04-14")<br/>
        /// Example: openai/gpt-4.1-2025-04-14
        /// </summary>
        /// <example>openai/gpt-4.1-2025-04-14</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_permaslug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelPermaslug { get; set; }

        /// <summary>
        /// Total prompt tokens used<br/>
        /// Example: 50
        /// </summary>
        /// <example>50</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptTokens { get; set; }

        /// <summary>
        /// Name of the provider serving this endpoint<br/>
        /// Example: OpenAI
        /// </summary>
        /// <example>OpenAI</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderName { get; set; }

        /// <summary>
        /// Total reasoning tokens used<br/>
        /// Example: 25
        /// </summary>
        /// <example>25</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReasoningTokens { get; set; }

        /// <summary>
        /// Number of requests made<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Requests { get; set; }

        /// <summary>
        /// Total cost in USD (OpenRouter credits spent)<br/>
        /// Example: 0.015F
        /// </summary>
        /// <example>0.015F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Usage { get; set; }

        /// <summary>
        /// ID of the workspace this activity is attributed to. Only present when `group_by=workspace` is passed; the response is then split per workspace. Activity recorded before workspace resolution existed is attributed to the account default workspace.<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityItem" /> class.
        /// </summary>
        /// <param name="byokUsageInference">
        /// BYOK inference cost in USD (external credits spent)<br/>
        /// Example: 0.012F
        /// </param>
        /// <param name="cachedTokens">
        /// Total prompt tokens read from the provider prompt cache (cache hits). Generally a subset of `prompt_tokens`; for replayed response-cache hits the provider may report the two counters over disjoint token sets, so `cached_tokens` can exceed `prompt_tokens`.<br/>
        /// Example: 10
        /// </param>
        /// <param name="completionTokens">
        /// Total completion tokens generated<br/>
        /// Example: 125
        /// </param>
        /// <param name="date">
        /// Date of the activity (YYYY-MM-DD format)<br/>
        /// Example: 2025-08-24
        /// </param>
        /// <param name="endpointId">
        /// Unique identifier for the endpoint<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="model">
        /// Model slug (e.g., "openai/gpt-4.1")<br/>
        /// Example: openai/gpt-4.1
        /// </param>
        /// <param name="modelPermaslug">
        /// Model permaslug (e.g., "openai/gpt-4.1-2025-04-14")<br/>
        /// Example: openai/gpt-4.1-2025-04-14
        /// </param>
        /// <param name="promptTokens">
        /// Total prompt tokens used<br/>
        /// Example: 50
        /// </param>
        /// <param name="providerName">
        /// Name of the provider serving this endpoint<br/>
        /// Example: OpenAI
        /// </param>
        /// <param name="reasoningTokens">
        /// Total reasoning tokens used<br/>
        /// Example: 25
        /// </param>
        /// <param name="requests">
        /// Number of requests made<br/>
        /// Example: 5
        /// </param>
        /// <param name="usage">
        /// Total cost in USD (OpenRouter credits spent)<br/>
        /// Example: 0.015F
        /// </param>
        /// <param name="workspaceId">
        /// ID of the workspace this activity is attributed to. Only present when `group_by=workspace` is passed; the response is then split per workspace. Activity recorded before workspace resolution existed is attributed to the account default workspace.<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivityItem(
            double byokUsageInference,
            int cachedTokens,
            int completionTokens,
            string date,
            string endpointId,
            string model,
            string modelPermaslug,
            int promptTokens,
            string providerName,
            int reasoningTokens,
            int requests,
            double usage,
            string? workspaceId)
        {
            this.ByokUsageInference = byokUsageInference;
            this.CachedTokens = cachedTokens;
            this.CompletionTokens = completionTokens;
            this.Date = date ?? throw new global::System.ArgumentNullException(nameof(date));
            this.EndpointId = endpointId ?? throw new global::System.ArgumentNullException(nameof(endpointId));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.ModelPermaslug = modelPermaslug ?? throw new global::System.ArgumentNullException(nameof(modelPermaslug));
            this.PromptTokens = promptTokens;
            this.ProviderName = providerName ?? throw new global::System.ArgumentNullException(nameof(providerName));
            this.ReasoningTokens = reasoningTokens;
            this.Requests = requests;
            this.Usage = usage;
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityItem" /> class.
        /// </summary>
        public ActivityItem()
        {
        }

    }
}