
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Prompt tokens served from cache, when the daemon reported them.<br/>
    /// Example: {"cached_tokens":1024}
    /// </summary>
    public sealed partial class InternChatPromptTokensDetails
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CachedTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatPromptTokensDetails" /> class.
        /// </summary>
        /// <param name="cachedTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternChatPromptTokensDetails(
            int cachedTokens)
        {
            this.CachedTokens = cachedTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternChatPromptTokensDetails" /> class.
        /// </summary>
        public InternChatPromptTokensDetails()
        {
        }

    }
}