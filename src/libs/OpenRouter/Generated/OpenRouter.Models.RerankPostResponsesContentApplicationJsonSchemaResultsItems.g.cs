
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A single rerank result
    /// </summary>
    public sealed partial class RerankPostResponsesContentApplicationJsonSchemaResultsItems
    {
        /// <summary>
        /// Index of the document in the original input list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Relevance score of the document to the query
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relevance_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RelevanceScore { get; set; }

        /// <summary>
        /// The document object containing the original text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.RerankPostResponsesContentApplicationJsonSchemaResultsItemsDocument Document { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankPostResponsesContentApplicationJsonSchemaResultsItems" /> class.
        /// </summary>
        /// <param name="index">
        /// Index of the document in the original input list
        /// </param>
        /// <param name="relevanceScore">
        /// Relevance score of the document to the query
        /// </param>
        /// <param name="document">
        /// The document object containing the original text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankPostResponsesContentApplicationJsonSchemaResultsItems(
            int index,
            double relevanceScore,
            global::OpenRouter.RerankPostResponsesContentApplicationJsonSchemaResultsItemsDocument document)
        {
            this.Index = index;
            this.RelevanceScore = relevanceScore;
            this.Document = document ?? throw new global::System.ArgumentNullException(nameof(document));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankPostResponsesContentApplicationJsonSchemaResultsItems" /> class.
        /// </summary>
        public RerankPostResponsesContentApplicationJsonSchemaResultsItems()
        {
        }
    }
}