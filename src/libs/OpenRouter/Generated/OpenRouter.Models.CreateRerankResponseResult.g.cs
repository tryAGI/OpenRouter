
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A single rerank result<br/>
    /// Example: {"document":{"text":"Paris is the capital of France."},"index":0,"relevance_score":0.98}
    /// </summary>
    public sealed partial class CreateRerankResponseResult
    {
        /// <summary>
        /// The document object echoing the original input (text and/or image)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.CreateRerankResponseResultDocument Document { get; set; }

        /// <summary>
        /// Index of the document in the original input list<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Relevance score of the document to the query<br/>
        /// Example: 0.98F
        /// </summary>
        /// <example>0.98F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("relevance_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RelevanceScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRerankResponseResult" /> class.
        /// </summary>
        /// <param name="document">
        /// The document object echoing the original input (text and/or image)
        /// </param>
        /// <param name="index">
        /// Index of the document in the original input list<br/>
        /// Example: 0
        /// </param>
        /// <param name="relevanceScore">
        /// Relevance score of the document to the query<br/>
        /// Example: 0.98F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRerankResponseResult(
            global::OpenRouter.CreateRerankResponseResultDocument document,
            int index,
            double relevanceScore)
        {
            this.Document = document ?? throw new global::System.ArgumentNullException(nameof(document));
            this.Index = index;
            this.RelevanceScore = relevanceScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRerankResponseResult" /> class.
        /// </summary>
        public CreateRerankResponseResult()
        {
        }

    }
}