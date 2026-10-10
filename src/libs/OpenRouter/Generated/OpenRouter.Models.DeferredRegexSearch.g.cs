
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Versioned safe-regex retrieval over supplied tool definitions.<br/>
    /// Example: {"max_results":5,"type":"regex"}
    /// </summary>
    public sealed partial class DeferredRegexSearch
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.DeferredRegexSearchTypeJsonConverter))]
        public global::OpenRouter.DeferredRegexSearchType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeferredRegexSearch" /> class.
        /// </summary>
        /// <param name="maxResults"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeferredRegexSearch(
            int? maxResults,
            global::OpenRouter.DeferredRegexSearchType type)
        {
            this.MaxResults = maxResults;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeferredRegexSearch" /> class.
        /// </summary>
        public DeferredRegexSearch()
        {
        }

    }
}