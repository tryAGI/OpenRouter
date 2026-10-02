
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Stop once cumulative token usage across the loop exceeds this threshold.<br/>
    /// Example: {"max_tokens":10000,"type":"max_tokens_used"}
    /// </summary>
    public sealed partial class StopServerToolsWhenMaxTokensUsed
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.StopServerToolsWhenMaxTokensUsedTypeJsonConverter))]
        public global::OpenRouter.StopServerToolsWhenMaxTokensUsedType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StopServerToolsWhenMaxTokensUsed" /> class.
        /// </summary>
        /// <param name="maxTokens"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StopServerToolsWhenMaxTokensUsed(
            int maxTokens,
            global::OpenRouter.StopServerToolsWhenMaxTokensUsedType type)
        {
            this.MaxTokens = maxTokens;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StopServerToolsWhenMaxTokensUsed" /> class.
        /// </summary>
        public StopServerToolsWhenMaxTokensUsed()
        {
        }

    }
}