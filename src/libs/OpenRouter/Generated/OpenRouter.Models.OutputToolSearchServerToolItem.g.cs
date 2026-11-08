
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An openrouter:tool_search server tool output item<br/>
    /// Example: {"id":"ts_tmp_abc123","query":"weather tools","status":"completed","type":"openrouter:tool_search"}
    /// </summary>
    public sealed partial class OutputToolSearchServerToolItem
    {
        /// <summary>
        /// The JSON arguments of the model call, verbatim. Replaying the item reuses them.<br/>
        /// Example: {"query":"weather tools"}
        /// </summary>
        /// <example>{"query":"weather tools"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public string? Arguments { get; set; }

        /// <summary>
        /// The ID of the model call that ran the search. Replaying the item reuses it.<br/>
        /// Example: call_search_1
        /// </summary>
        /// <example>call_search_1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        public string? CallId { get; set; }

        /// <summary>
        /// What the announced index added and removed since the previous one, when the request opted into `announce_catalog_changes` and the catalog changed between model turns. Replaying the item shows the same lines.<br/>
        /// Example: Added since the previous index: mcp__okta (113).
        /// </summary>
        /// <example>Added since the previous index: mcp__okta (113).</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalog_changes")]
        public string? CatalogChanges { get; set; }

        /// <summary>
        /// The deferred-tool index the router showed the model with a pre-search, listing tool sources and names. Replaying the item shows the same index.<br/>
        /// Example: Deferred tools, found with tool_search and called with tool_exec:<br/>
        /// Sources: mcp__sentry (12).
        /// </summary>
        /// <example>
        /// Deferred tools, found with tool_search and called with tool_exec:<br/>
        /// Sources: mcp__sentry (12).
        /// </example>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalog_index")]
        public string? CatalogIndex { get; set; }

        /// <summary>
        /// The error message when the tool call failed before producing a result. Set together with `status: 'failed'`; absent on a successful call.<br/>
        /// Example: Tool execution failed
        /// </summary>
        /// <example>Tool execution failed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// How the model saw the matches. `compact` means each tool by name, description, and input shape, plus a call example. Replaying the item renders the same result.<br/>
        /// Example: compact
        /// </summary>
        /// <example>compact</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputToolSearchServerToolItemFormatJsonConverter))]
        public global::OpenRouter.OutputToolSearchServerToolItemFormat? Format { get; set; }

        /// <summary>
        /// The guidance the model got when the search matched no tools.<br/>
        /// Example: No tools matched. Search again with other keywords, or load tools by exact name with "select:Name1,Name2".
        /// </summary>
        /// <example>No tools matched. Search again with other keywords, or load tools by exact name with "select:Name1,Name2".</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hint")]
        public string? Hint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matches")]
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputToolSearchServerToolItemMatche>? Matches { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// The other deferred tools of each source a match came from, by name, when the search listed siblings. Replaying the item shows the same names.<br/>
        /// Example: {"mcp__tavily":["mcp__tavily__tavily_extract","mcp__tavily__tavily_crawl"]}
        /// </summary>
        /// <example>{"mcp__tavily":["mcp__tavily__tavily_extract","mcp__tavily__tavily_crawl"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Sources { get; set; }

        /// <summary>
        /// Example: completed
        /// </summary>
        /// <example>completed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.FailableToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.FailableToolCallStatus Status { get; set; }

        /// <summary>
        /// The IDs of every tool call in the model response that ran the search, in order. Replaying the item keeps those calls in one turn.<br/>
        /// Example: [call_search_1, call_exec_1]
        /// </summary>
        /// <example>[call_search_1, call_exec_1]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_call_ids")]
        public global::System.Collections.Generic.IList<string>? TurnCallIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputToolSearchServerToolItemTypeJsonConverter))]
        public global::OpenRouter.OutputToolSearchServerToolItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputToolSearchServerToolItem" /> class.
        /// </summary>
        /// <param name="status">
        /// Example: completed
        /// </param>
        /// <param name="arguments">
        /// The JSON arguments of the model call, verbatim. Replaying the item reuses them.<br/>
        /// Example: {"query":"weather tools"}
        /// </param>
        /// <param name="callId">
        /// The ID of the model call that ran the search. Replaying the item reuses it.<br/>
        /// Example: call_search_1
        /// </param>
        /// <param name="catalogChanges">
        /// What the announced index added and removed since the previous one, when the request opted into `announce_catalog_changes` and the catalog changed between model turns. Replaying the item shows the same lines.<br/>
        /// Example: Added since the previous index: mcp__okta (113).
        /// </param>
        /// <param name="catalogIndex">
        /// The deferred-tool index the router showed the model with a pre-search, listing tool sources and names. Replaying the item shows the same index.<br/>
        /// Example: Deferred tools, found with tool_search and called with tool_exec:<br/>
        /// Sources: mcp__sentry (12).
        /// </param>
        /// <param name="error">
        /// The error message when the tool call failed before producing a result. Set together with `status: 'failed'`; absent on a successful call.<br/>
        /// Example: Tool execution failed
        /// </param>
        /// <param name="format">
        /// How the model saw the matches. `compact` means each tool by name, description, and input shape, plus a call example. Replaying the item renders the same result.<br/>
        /// Example: compact
        /// </param>
        /// <param name="hint">
        /// The guidance the model got when the search matched no tools.<br/>
        /// Example: No tools matched. Search again with other keywords, or load tools by exact name with "select:Name1,Name2".
        /// </param>
        /// <param name="id"></param>
        /// <param name="matches"></param>
        /// <param name="query"></param>
        /// <param name="sources">
        /// The other deferred tools of each source a match came from, by name, when the search listed siblings. Replaying the item shows the same names.<br/>
        /// Example: {"mcp__tavily":["mcp__tavily__tavily_extract","mcp__tavily__tavily_crawl"]}
        /// </param>
        /// <param name="turnCallIds">
        /// The IDs of every tool call in the model response that ran the search, in order. Replaying the item keeps those calls in one turn.<br/>
        /// Example: [call_search_1, call_exec_1]
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputToolSearchServerToolItem(
            global::OpenRouter.FailableToolCallStatus status,
            string? arguments,
            string? callId,
            string? catalogChanges,
            string? catalogIndex,
            string? error,
            global::OpenRouter.OutputToolSearchServerToolItemFormat? format,
            string? hint,
            string? id,
            global::System.Collections.Generic.IList<global::OpenRouter.OutputToolSearchServerToolItemMatche>? matches,
            string? query,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? sources,
            global::System.Collections.Generic.IList<string>? turnCallIds,
            global::OpenRouter.OutputToolSearchServerToolItemType type)
        {
            this.Arguments = arguments;
            this.CallId = callId;
            this.CatalogChanges = catalogChanges;
            this.CatalogIndex = catalogIndex;
            this.Error = error;
            this.Format = format;
            this.Hint = hint;
            this.Id = id;
            this.Matches = matches;
            this.Query = query;
            this.Sources = sources;
            this.Status = status;
            this.TurnCallIds = turnCallIds;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputToolSearchServerToolItem" /> class.
        /// </summary>
        public OutputToolSearchServerToolItem()
        {
        }

    }
}