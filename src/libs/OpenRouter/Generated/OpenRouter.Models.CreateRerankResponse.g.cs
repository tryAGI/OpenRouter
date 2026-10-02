
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Rerank response containing ranked results<br/>
    /// Example: {"id":"gen-rerank-1234567890-abc","model":"cohere/rerank-v3.5","results":[{"document":{"text":"Paris is the capital of France."},"index":0,"relevance_score":0.98}],"usage":{"search_units":1,"total_tokens":150}}
    /// </summary>
    public sealed partial class CreateRerankResponse
    {
        /// <summary>
        /// Unique identifier for the rerank response (ORID format)<br/>
        /// Example: gen-rerank-1234567890-abc
        /// </summary>
        /// <example>gen-rerank-1234567890-abc</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The model used for reranking<br/>
        /// Example: cohere/rerank-v3.5
        /// </summary>
        /// <example>cohere/rerank-v3.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The provider that served the rerank request<br/>
        /// Example: Cohere
        /// </summary>
        /// <example>Cohere</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// List of rerank results sorted by relevance<br/>
        /// Example: [{"document":{"text":"Paris is the capital of France."},"index":0,"relevance_score":0.98}]
        /// </summary>
        /// <example>[{"document":{"text":"Paris is the capital of France."},"index":0,"relevance_score":0.98}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.CreateRerankResponseResult> Results { get; set; }

        /// <summary>
        /// Usage statistics<br/>
        /// Example: {"search_units":1,"total_tokens":150}
        /// </summary>
        /// <example>{"search_units":1,"total_tokens":150}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::OpenRouter.CreateRerankResponseUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRerankResponse" /> class.
        /// </summary>
        /// <param name="model">
        /// The model used for reranking<br/>
        /// Example: cohere/rerank-v3.5
        /// </param>
        /// <param name="results">
        /// List of rerank results sorted by relevance<br/>
        /// Example: [{"document":{"text":"Paris is the capital of France."},"index":0,"relevance_score":0.98}]
        /// </param>
        /// <param name="id">
        /// Unique identifier for the rerank response (ORID format)<br/>
        /// Example: gen-rerank-1234567890-abc
        /// </param>
        /// <param name="provider">
        /// The provider that served the rerank request<br/>
        /// Example: Cohere
        /// </param>
        /// <param name="usage">
        /// Usage statistics<br/>
        /// Example: {"search_units":1,"total_tokens":150}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRerankResponse(
            string model,
            global::System.Collections.Generic.IList<global::OpenRouter.CreateRerankResponseResult> results,
            string? id,
            string? provider,
            global::OpenRouter.CreateRerankResponseUsage? usage)
        {
            this.Id = id;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Provider = provider;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRerankResponse" /> class.
        /// </summary>
        public CreateRerankResponse()
        {
        }

    }
}