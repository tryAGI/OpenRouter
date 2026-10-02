
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Information about the top provider for this model<br/>
    /// Example: {"context_length":8192,"is_moderated":true,"max_completion_tokens":4096}
    /// </summary>
    public sealed partial class TopProviderInfo
    {
        /// <summary>
        /// Context length from the top provider<br/>
        /// Example: 8192
        /// </summary>
        /// <example>8192</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_length")]
        public int? ContextLength { get; set; }

        /// <summary>
        /// Whether the top provider moderates content<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_moderated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsModerated { get; set; }

        /// <summary>
        /// Maximum completion tokens from the top provider. Input and output tokens share the context window, so the effective maximum output for a request is further limited by the context remaining after input tokens.<br/>
        /// Example: 4096
        /// </summary>
        /// <example>4096</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")]
        public int? MaxCompletionTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopProviderInfo" /> class.
        /// </summary>
        /// <param name="isModerated">
        /// Whether the top provider moderates content<br/>
        /// Example: true
        /// </param>
        /// <param name="contextLength">
        /// Context length from the top provider<br/>
        /// Example: 8192
        /// </param>
        /// <param name="maxCompletionTokens">
        /// Maximum completion tokens from the top provider. Input and output tokens share the context window, so the effective maximum output for a request is further limited by the context remaining after input tokens.<br/>
        /// Example: 4096
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TopProviderInfo(
            bool isModerated,
            int? contextLength,
            int? maxCompletionTokens)
        {
            this.ContextLength = contextLength;
            this.IsModerated = isModerated;
            this.MaxCompletionTokens = maxCompletionTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopProviderInfo" /> class.
        /// </summary>
        public TopProviderInfo()
        {
        }

    }
}