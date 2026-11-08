
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
        /// Universal profile only, for searches the router answers through the `tool_search` wrapper. When true, a search that matches nothing also names the deferred sources this search covers (namespaces, MCP servers, and shared `&lt;server&gt;_` prefixes; up to 40 names or 2,000 characters, with a count of any omitted) and tells the model that a source the search does not cover is unreachable through it in this request, so it can make a client tool call the task already needs (or a read-only one) and search again on a later turn instead of concluding the integration is missing. Direct tools, including a client's built-in tools, are already in the tool list and are not named. Absent or false: a miss suggests other keywords and the closest names only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("miss_sources")]
        public bool? MissSources { get; set; }

        /// <summary>
        /// Universal profile only, for searches the router answers through the `tool_search` wrapper; code-mode `search()` and a client-owned tool search list the matched tools alone. When true, each result also names up to 16 other deferred tools of every source a match came from, so a model that found one tool of an MCP server learns its neighbours without another search. Absent or false: results list the matched tools alone.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("siblings")]
        public bool? Siblings { get; set; }

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
        /// <param name="missSources">
        /// Universal profile only, for searches the router answers through the `tool_search` wrapper. When true, a search that matches nothing also names the deferred sources this search covers (namespaces, MCP servers, and shared `&lt;server&gt;_` prefixes; up to 40 names or 2,000 characters, with a count of any omitted) and tells the model that a source the search does not cover is unreachable through it in this request, so it can make a client tool call the task already needs (or a read-only one) and search again on a later turn instead of concluding the integration is missing. Direct tools, including a client's built-in tools, are already in the tool list and are not named. Absent or false: a miss suggests other keywords and the closest names only.
        /// </param>
        /// <param name="siblings">
        /// Universal profile only, for searches the router answers through the `tool_search` wrapper; code-mode `search()` and a client-owned tool search list the matched tools alone. When true, each result also names up to 16 other deferred tools of every source a match came from, so a model that found one tool of an MCP server learns its neighbours without another search. Absent or false: results list the matched tools alone.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeferredRegexSearch(
            int? maxResults,
            bool? missSources,
            bool? siblings,
            global::OpenRouter.DeferredRegexSearchType type)
        {
            this.MaxResults = maxResults;
            this.MissSources = missSources;
            this.Siblings = siblings;
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