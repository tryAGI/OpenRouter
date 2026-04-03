
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Token usage statistics
    /// </summary>
    public sealed partial class EmbeddingsPostResponsesContentApplicationJsonSchemaUsage
    {
        /// <summary>
        /// Number of tokens in the input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptTokens { get; set; }

        /// <summary>
        /// Total number of tokens used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// Cost of the request in credits
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsPostResponsesContentApplicationJsonSchemaUsage" /> class.
        /// </summary>
        /// <param name="promptTokens">
        /// Number of tokens in the input
        /// </param>
        /// <param name="totalTokens">
        /// Total number of tokens used
        /// </param>
        /// <param name="cost">
        /// Cost of the request in credits
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingsPostResponsesContentApplicationJsonSchemaUsage(
            int promptTokens,
            int totalTokens,
            double? cost)
        {
            this.PromptTokens = promptTokens;
            this.TotalTokens = totalTokens;
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsPostResponsesContentApplicationJsonSchemaUsage" /> class.
        /// </summary>
        public EmbeddingsPostResponsesContentApplicationJsonSchemaUsage()
        {
        }
    }
}