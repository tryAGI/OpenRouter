
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
        /// Universal profile only, for searches the router answers through the `tool_search` wrapper. Unless false, a search that matches nothing also names the deferred sources this search covers (namespaces, MCP servers, and shared `&lt;server&gt;_` prefixes; up to 40 names or 2,000 characters, with a count of any omitted) and tells the model that a source the search does not cover is unreachable through it in this request, so it can make a client tool call the task already needs (or a read-only one) and search again on a later turn instead of concluding the integration is missing. A hit gets the same guidance after its matches when, as a heuristic on the model's own words, the query's leading word has 3 to 64 characters, no query word names a searchable source, and the leading word is not among the words of the deferred tools' names (the union of every deferred tool name's tokens, whole and split as the search index splits names; a camel-case word counts when each of its parts is), with descriptions left out so a tool that merely mentions another product cannot mask it (`jira create issue` answered with another tracker's issue tools). Direct tools, including a client's built-in tools, are already in the tool list and are not named. False: a miss suggests other keywords and the closest names only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("miss_sources")]
        public bool? MissSources { get; set; }

        /// <summary>
        /// Universal profile only, for searches the router answers through the `tool_search` wrapper; code-mode `search()` and a client-owned tool search list the matched tools alone. When true, each result also names up to 16 other deferred tools of every source a match came from, so a model that found one tool of an MCP server learns its neighbours without another search. Absent or false: results list the matched tools alone.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("siblings")]
        public bool? Siblings { get; set; }

        /// <summary>
        /// Universal profile only, for keyword searches the router answers through the `tool_search` wrapper. When true, a result spreads across sources: of the 3 x limit best-scoring candidates, those scoring at least 60% of the best match take at most 2 slots per source (MCP server, namespace or shared `&lt;server&gt;_` prefix; a tool with no source is never capped), and the remaining slots fill in score order, so a catalog with several systems for one job (web search, page extraction) shows one of each instead of the top system's siblings. Absent or false: results are the best matches in score order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spread")]
        public bool? Spread { get; set; }

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
        /// <param name="missSources">
        /// Universal profile only, for searches the router answers through the `tool_search` wrapper. Unless false, a search that matches nothing also names the deferred sources this search covers (namespaces, MCP servers, and shared `&lt;server&gt;_` prefixes; up to 40 names or 2,000 characters, with a count of any omitted) and tells the model that a source the search does not cover is unreachable through it in this request, so it can make a client tool call the task already needs (or a read-only one) and search again on a later turn instead of concluding the integration is missing. A hit gets the same guidance after its matches when, as a heuristic on the model's own words, the query's leading word has 3 to 64 characters, no query word names a searchable source, and the leading word is not among the words of the deferred tools' names (the union of every deferred tool name's tokens, whole and split as the search index splits names; a camel-case word counts when each of its parts is), with descriptions left out so a tool that merely mentions another product cannot mask it (`jira create issue` answered with another tracker's issue tools). Direct tools, including a client's built-in tools, are already in the tool list and are not named. False: a miss suggests other keywords and the closest names only.
        /// </param>
        /// <param name="siblings">
        /// Universal profile only, for searches the router answers through the `tool_search` wrapper; code-mode `search()` and a client-owned tool search list the matched tools alone. When true, each result also names up to 16 other deferred tools of every source a match came from, so a model that found one tool of an MCP server learns its neighbours without another search. Absent or false: results list the matched tools alone.
        /// </param>
        /// <param name="spread">
        /// Universal profile only, for keyword searches the router answers through the `tool_search` wrapper. When true, a result spreads across sources: of the 3 x limit best-scoring candidates, those scoring at least 60% of the best match take at most 2 slots per source (MCP server, namespace or shared `&lt;server&gt;_` prefix; a tool with no source is never capped), and the remaining slots fill in score order, so a catalog with several systems for one job (web search, page extraction) shows one of each instead of the top system's siblings. Absent or false: results are the best matches in score order.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeferredBm25Search(
            int? maxResults,
            bool? missSources,
            bool? siblings,
            bool? spread,
            global::OpenRouter.DeferredBm25SearchType type)
        {
            this.MaxResults = maxResults;
            this.MissSources = missSources;
            this.Siblings = siblings;
            this.Spread = spread;
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