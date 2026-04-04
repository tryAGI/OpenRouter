
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesResultUsageIterationsItems2
    {
        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public int? InputTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        public int? OutputTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_input_tokens")]
        public int? CacheCreationInputTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_tokens")]
        public int? CacheReadInputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.MessagesResultUsageIterationsItemsOneOf2CacheCreation, object>))]
        public global::OpenRouter.OneOf<global::OpenRouter.MessagesResultUsageIterationsItemsOneOf2CacheCreation, object>? CacheCreation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResultUsageIterationsItems2" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="inputTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="outputTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="cacheCreationInputTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="cacheReadInputTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="cacheCreation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesResultUsageIterationsItems2(
            string type,
            int? inputTokens,
            int? outputTokens,
            int? cacheCreationInputTokens,
            int? cacheReadInputTokens,
            global::OpenRouter.OneOf<global::OpenRouter.MessagesResultUsageIterationsItemsOneOf2CacheCreation, object>? cacheCreation)
        {
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.CacheCreationInputTokens = cacheCreationInputTokens;
            this.CacheReadInputTokens = cacheReadInputTokens;
            this.CacheCreation = cacheCreation;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResultUsageIterationsItems2" /> class.
        /// </summary>
        public MessagesResultUsageIterationsItems2()
        {
        }
    }
}