
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultUsageIterationsItemsOneOf0CacheCreation
    {
        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ephemeral_5m_input_tokens")]
        public int? Ephemeral5mInputTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ephemeral_1h_input_tokens")]
        public int? Ephemeral1hInputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultUsageIterationsItemsOneOf0CacheCreation" /> class.
        /// </summary>
        /// <param name="ephemeral5mInputTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="ephemeral1hInputTokens">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseMessagesResultUsageIterationsItemsOneOf0CacheCreation(
            int? ephemeral5mInputTokens,
            int? ephemeral1hInputTokens)
        {
            this.Ephemeral5mInputTokens = ephemeral5mInputTokens;
            this.Ephemeral1hInputTokens = ephemeral1hInputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultUsageIterationsItemsOneOf0CacheCreation" /> class.
        /// </summary>
        public BaseMessagesResultUsageIterationsItemsOneOf0CacheCreation()
        {
        }
    }
}