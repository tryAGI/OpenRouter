
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"cache_creation":null,"cache_creation_input_tokens":null,"cache_read_input_tokens":null,"inference_geo":null,"input_tokens":100,"output_tokens":50,"output_tokens_details":null,"server_tool_use":null,"service_tier":"standard"}
    /// </summary>
    public sealed partial class AnthropicUsage
    {
        /// <summary>
        /// Example: {"ephemeral_1h_input_tokens":0,"ephemeral_5m_input_tokens":100}
        /// </summary>
        /// <example>{"ephemeral_1h_input_tokens":0,"ephemeral_5m_input_tokens":100}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation")]
        public global::OpenRouter.AnthropicCacheCreation? CacheCreation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_input_tokens")]
        public int? CacheCreationInputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_tokens")]
        public int? CacheReadInputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inference_geo")]
        public string? InferenceGeo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// Example: {"thinking_tokens":0}
        /// </summary>
        /// <example>{"thinking_tokens":0}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens_details")]
        public global::OpenRouter.AnthropicOutputTokensDetails? OutputTokensDetails { get; set; }

        /// <summary>
        /// Example: {"web_fetch_requests":0,"web_search_requests":1}
        /// </summary>
        /// <example>{"web_fetch_requests":0,"web_search_requests":1}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_tool_use")]
        public global::OpenRouter.AnthropicServerToolUsage? ServerToolUse { get; set; }

        /// <summary>
        /// Example: standard
        /// </summary>
        /// <example>standard</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicServiceTierJsonConverter))]
        public global::OpenRouter.AnthropicServiceTier? ServiceTier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicUsage" /> class.
        /// </summary>
        /// <param name="inputTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="cacheCreation">
        /// Example: {"ephemeral_1h_input_tokens":0,"ephemeral_5m_input_tokens":100}
        /// </param>
        /// <param name="cacheCreationInputTokens"></param>
        /// <param name="cacheReadInputTokens"></param>
        /// <param name="inferenceGeo"></param>
        /// <param name="outputTokensDetails">
        /// Example: {"thinking_tokens":0}
        /// </param>
        /// <param name="serverToolUse">
        /// Example: {"web_fetch_requests":0,"web_search_requests":1}
        /// </param>
        /// <param name="serviceTier">
        /// Example: standard
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicUsage(
            int inputTokens,
            int outputTokens,
            global::OpenRouter.AnthropicCacheCreation? cacheCreation,
            int? cacheCreationInputTokens,
            int? cacheReadInputTokens,
            string? inferenceGeo,
            global::OpenRouter.AnthropicOutputTokensDetails? outputTokensDetails,
            global::OpenRouter.AnthropicServerToolUsage? serverToolUse,
            global::OpenRouter.AnthropicServiceTier? serviceTier)
        {
            this.CacheCreation = cacheCreation;
            this.CacheCreationInputTokens = cacheCreationInputTokens;
            this.CacheReadInputTokens = cacheReadInputTokens;
            this.InferenceGeo = inferenceGeo;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.OutputTokensDetails = outputTokensDetails;
            this.ServerToolUse = serverToolUse;
            this.ServiceTier = serviceTier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicUsage" /> class.
        /// </summary>
        public AnthropicUsage()
        {
        }

    }
}