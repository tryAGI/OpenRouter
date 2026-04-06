
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Rerank response containing ranked results
    /// </summary>
    public sealed partial class RerankCreateRerankResponse200
    {
        /// <summary>
        /// Unique identifier for the rerank response (ORID format)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The model used for reranking
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The provider that served the rerank request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// List of rerank results sorted by relevance
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.RerankPostResponsesContentApplicationJsonSchemaResultsItems> Results { get; set; }

        /// <summary>
        /// Usage statistics
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::OpenRouter.RerankPostResponsesContentApplicationJsonSchemaUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankCreateRerankResponse200" /> class.
        /// </summary>
        /// <param name="model">
        /// The model used for reranking
        /// </param>
        /// <param name="results">
        /// List of rerank results sorted by relevance
        /// </param>
        /// <param name="id">
        /// Unique identifier for the rerank response (ORID format)
        /// </param>
        /// <param name="provider">
        /// The provider that served the rerank request
        /// </param>
        /// <param name="usage">
        /// Usage statistics
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankCreateRerankResponse200(
            string model,
            global::System.Collections.Generic.IList<global::OpenRouter.RerankPostResponsesContentApplicationJsonSchemaResultsItems> results,
            string? id,
            string? provider,
            global::OpenRouter.RerankPostResponsesContentApplicationJsonSchemaUsage? usage)
        {
            this.Id = id;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Provider = provider;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankCreateRerankResponse200" /> class.
        /// </summary>
        public RerankCreateRerankResponse200()
        {
        }
    }
}