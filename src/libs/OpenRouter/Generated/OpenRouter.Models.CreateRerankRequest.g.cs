
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRerankRequest
    {
        /// <summary>
        /// The list of documents to rerank
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Documents { get; set; }

        /// <summary>
        /// The rerank model to use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProvider? Provider { get; set; }

        /// <summary>
        /// The search query to rerank documents against
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Number of most relevant documents to return
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_n")]
        public int? TopN { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRerankRequest" /> class.
        /// </summary>
        /// <param name="documents">
        /// The list of documents to rerank
        /// </param>
        /// <param name="model">
        /// The rerank model to use
        /// </param>
        /// <param name="query">
        /// The search query to rerank documents against
        /// </param>
        /// <param name="provider"></param>
        /// <param name="topN">
        /// Number of most relevant documents to return
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRerankRequest(
            global::System.Collections.Generic.IList<string> documents,
            string model,
            string query,
            global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProvider? provider,
            int? topN)
        {
            this.Documents = documents ?? throw new global::System.ArgumentNullException(nameof(documents));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Provider = provider;
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.TopN = topN;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRerankRequest" /> class.
        /// </summary>
        public CreateRerankRequest()
        {
        }
    }
}