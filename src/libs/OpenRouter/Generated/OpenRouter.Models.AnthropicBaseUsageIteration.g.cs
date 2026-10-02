
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"cache_creation":null,"cache_creation_input_tokens":0,"cache_read_input_tokens":0,"input_tokens":100,"output_tokens":50}
    /// </summary>
    public sealed partial class AnthropicBaseUsageIteration
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464<br/>
        /// Example: {"ephemeral_1h_input_tokens":0,"ephemeral_5m_input_tokens":0}
        /// </summary>
        /// <example>{"ephemeral_1h_input_tokens":0,"ephemeral_5m_input_tokens":0}</example>
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicBaseUsageIteration" /> class.
        /// </summary>
        /// <param name="cacheCreation">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464<br/>
        /// Example: {"ephemeral_1h_input_tokens":0,"ephemeral_5m_input_tokens":0}
        /// </param>
        /// <param name="cacheCreationInputTokens"></param>
        /// <param name="cacheReadInputTokens"></param>
        /// <param name="inputTokens"></param>
        /// <param name="outputTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicBaseUsageIteration(
            global::OpenRouter.AnthropicIterationCacheCreation? cacheCreation,
            int? cacheCreationInputTokens,
            int? cacheReadInputTokens,
            int? inputTokens,
            int? outputTokens)
        {
            this.CacheCreation = cacheCreation;
            this.CacheCreationInputTokens = cacheCreationInputTokens;
            this.CacheReadInputTokens = cacheReadInputTokens;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicBaseUsageIteration" /> class.
        /// </summary>
        public AnthropicBaseUsageIteration()
        {
        }

    }
}