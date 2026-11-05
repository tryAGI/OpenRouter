
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Totals across every upstream model call of a deferred-tools run. The native usage fields report only the final call; cost covers every call.<br/>
    /// Example: {"completion_tokens":180,"prompt_tokens":2400,"total_tokens":2580,"turns":2}
    /// </summary>
    public sealed partial class DeferredToolsDetails
    {
        /// <summary>
        /// Completion tokens summed over every upstream call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CompletionTokens { get; set; }

        /// <summary>
        /// Prompt tokens summed over every upstream call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptTokens { get; set; }

        /// <summary>
        /// Sum of the above two fields
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// Upstream model calls the run made
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Turns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeferredToolsDetails" /> class.
        /// </summary>
        /// <param name="completionTokens">
        /// Completion tokens summed over every upstream call
        /// </param>
        /// <param name="promptTokens">
        /// Prompt tokens summed over every upstream call
        /// </param>
        /// <param name="totalTokens">
        /// Sum of the above two fields
        /// </param>
        /// <param name="turns">
        /// Upstream model calls the run made
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeferredToolsDetails(
            int completionTokens,
            int promptTokens,
            int totalTokens,
            int turns)
        {
            this.CompletionTokens = completionTokens;
            this.PromptTokens = promptTokens;
            this.TotalTokens = totalTokens;
            this.Turns = turns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeferredToolsDetails" /> class.
        /// </summary>
        public DeferredToolsDetails()
        {
        }

    }
}