
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Deterministic BM25 retrieval over supplied tool definitions.<br/>
    /// Example: {"max_results":5,"type":"bm25"}
    /// </summary>
    public sealed partial class DeferredBm25Search
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_results")]
        public int? MaxResults { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.DeferredBm25SearchTypeJsonConverter))]
        public global::OpenRouter.DeferredBm25SearchType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeferredBm25Search" /> class.
        /// </summary>
        /// <param name="maxResults"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeferredBm25Search(
            int? maxResults,
            global::OpenRouter.DeferredBm25SearchType type)
        {
            this.MaxResults = maxResults;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeferredBm25Search" /> class.
        /// </summary>
        public DeferredBm25Search()
        {
        }

    }
}