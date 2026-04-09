
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnthropicMessageUsageIteration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation")]
        public global::OpenRouter.AnthropicIterationCacheCreation? CacheCreation { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public int? InputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        public int? OutputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnthropicMessageUsageIterationTypeJsonConverter))]
        public global::OpenRouter.AnthropicMessageUsageIterationType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicMessageUsageIteration" /> class.
        /// </summary>
        /// <param name="cacheCreation"></param>
        /// <param name="cacheCreationInputTokens"></param>
        /// <param name="cacheReadInputTokens"></param>
        /// <param name="inputTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicMessageUsageIteration(
            global::OpenRouter.AnthropicIterationCacheCreation? cacheCreation,
            int? cacheCreationInputTokens,
            int? cacheReadInputTokens,
            int? inputTokens,
            int? outputTokens,
            global::OpenRouter.AnthropicMessageUsageIterationType type)
        {
            this.CacheCreation = cacheCreation;
            this.CacheCreationInputTokens = cacheCreationInputTokens;
            this.CacheReadInputTokens = cacheReadInputTokens;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicMessageUsageIteration" /> class.
        /// </summary>
        public AnthropicMessageUsageIteration()
        {
        }
    }
}