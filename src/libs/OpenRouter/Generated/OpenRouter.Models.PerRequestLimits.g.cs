
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Per-request token limits<br/>
    /// Example: {"completion_tokens":1000,"prompt_tokens":1000}
    /// </summary>
    public sealed partial class PerRequestLimits
    {
        /// <summary>
        /// Maximum completion tokens per request<br/>
        /// Example: 1000
        /// </summary>
        /// <example>1000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CompletionTokens { get; set; }

        /// <summary>
        /// Maximum prompt tokens per request<br/>
        /// Example: 1000
        /// </summary>
        /// <example>1000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PromptTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PerRequestLimits" /> class.
        /// </summary>
        /// <param name="completionTokens">
        /// Maximum completion tokens per request<br/>
        /// Example: 1000
        /// </param>
        /// <param name="promptTokens">
        /// Maximum prompt tokens per request<br/>
        /// Example: 1000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PerRequestLimits(
            double completionTokens,
            double promptTokens)
        {
            this.CompletionTokens = completionTokens;
            this.PromptTokens = promptTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PerRequestLimits" /> class.
        /// </summary>
        public PerRequestLimits()
        {
        }

    }
}