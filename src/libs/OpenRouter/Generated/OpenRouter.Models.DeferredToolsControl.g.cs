
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Opt-in versioned router-level deferred-tool protocol. Replay assistant reasoning unchanged on continuation. The portable profile needs the catalog unchanged across a continuation; the universal profile accepts a changed catalog and, with `announce_catalog_changes`, tells the model about it.<br/>
    /// Example: {"profile":"portable","protocol":"v1","search":{"max_results":5,"type":"bm25"},"validation":"runtime"}
    /// </summary>
    public sealed partial class DeferredToolsControl
    {
        /// <summary>
        /// Universal profile only. When true, a catalog whose deferred tools changed between two of the model's own turns (a client that connects MCP servers while the model works) is re-announced before the next model turn, with the sources added, changed and removed since the previous index, or that no deferred tools remain. Applies when the router lists the catalog itself; a client whose own tool search was adopted lists its deferred tools itself and is not re-announced. The announcement shares the result budget of the turn and is skipped when it does not fit. Absent or false: the catalog index is announced on a user turn only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("announce_catalog_changes")]
        public bool? AnnounceCatalogChanges { get; set; }

        /// <summary>
        /// How a universal `tool_search` query reaches the client's own tool search. Absent or `keywords`: a `select:` query becomes the words of the selected names and the limit is always filled. `native`: a `select:` query passes through verbatim when the client search documents `select:`, and the limit field is sent only when the model gave one, unless the client search requires it, in which case its documented default is sent. Experimental.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cascade_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.DeferredToolsControlCascadeModeJsonConverter))]
        public global::OpenRouter.DeferredToolsControlCascadeMode? CascadeMode { get; set; }

        /// <summary>
        /// Universal profile only. Caller text announced to the model with the deferred catalog before its first turn, for example which sources the task needs. Repeated only when it changes. Trimmed before the length bounds apply. Recorded in the `catalog_index` discovery record of the response, so it is replayed with the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hint")]
        public string? Hint { get; set; }

        /// <summary>
        /// How the universal profile exposes the hidden catalog to the provider. Absent or `wrappers`: the `tool_search` and `tool_exec` tools. `code_mode`: one `tool_code` tool that runs a short JavaScript program in which `search()` and `call()` reach the catalog, so several searches and calls complete in one tool result. Experimental.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interface")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.DeferredToolsControlInterfaceJsonConverter))]
        public global::OpenRouter.DeferredToolsControlInterface? Interface { get; set; }

        /// <summary>
        /// Universal profile only. When fewer tools than this would be deferred, the universal profile defers none of them and sends the client tools unchanged, so a harness with a handful of non-core tools and no MCP servers pays no search turn for them. Counted after the interface exclusions; ignored with a custom search, whose client decides what it loads. Absent: every wrappable tool in scope is deferred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_deferred_tools")]
        public int? MinDeferredTools { get; set; }

        /// <summary>
        /// Loading profile. `portable` serves the `defer_loading` tools with router-built search and call wrappers on any model and keeps the catalog fixed. `universal` defers every wrappable tool behind the same wrappers so the provider-facing tool list never changes (unless `min_deferred_tools` inlines a small catalog), and rebuilds the catalog from each request so tools can be added or removed mid-conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.DeferredToolsControlProfileJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.DeferredToolsControlProfile Profile { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protocol")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.DeferredToolsControlProtocolJsonConverter))]
        public global::OpenRouter.DeferredToolsControlProtocol Protocol { get; set; }

        /// <summary>
        /// Which tools the universal profile defers. Absent or `all`: every wrappable tool outside the coding-harness core set. `mcp`: only MCP server tools (`mcp__*` names and Responses namespaces outside `functions`); the harness keeps its own built-in tools direct. `client`: only the tools the client itself marked `defer_loading`, so a harness with its own tool search keeps its other direct tools direct; an adopted client tool search is still replaced by the router wrappers, and a client-deferred tool the router cannot wrap stays direct. Experimental.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.DeferredToolsControlScopeJsonConverter))]
        public global::OpenRouter.DeferredToolsControlScope? Scope { get; set; }

        /// <summary>
        /// Router-local regex/BM25 or caller-owned custom search.<br/>
        /// Example: {"max_results":5,"type":"bm25"}
        /// </summary>
        /// <example>{"max_results":5,"type":"bm25"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("search")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.DeferredToolsSearchStrategyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.DeferredToolsSearchStrategy Search { get; set; }

        /// <summary>
        /// Where tool-call arguments are checked against the original schema. Only `runtime` (in OpenRouter) is available in this release.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.DeferredToolsControlValidationJsonConverter))]
        public global::OpenRouter.DeferredToolsControlValidation Validation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeferredToolsControl" /> class.
        /// </summary>
        /// <param name="profile">
        /// Loading profile. `portable` serves the `defer_loading` tools with router-built search and call wrappers on any model and keeps the catalog fixed. `universal` defers every wrappable tool behind the same wrappers so the provider-facing tool list never changes (unless `min_deferred_tools` inlines a small catalog), and rebuilds the catalog from each request so tools can be added or removed mid-conversation.
        /// </param>
        /// <param name="search">
        /// Router-local regex/BM25 or caller-owned custom search.<br/>
        /// Example: {"max_results":5,"type":"bm25"}
        /// </param>
        /// <param name="announceCatalogChanges">
        /// Universal profile only. When true, a catalog whose deferred tools changed between two of the model's own turns (a client that connects MCP servers while the model works) is re-announced before the next model turn, with the sources added, changed and removed since the previous index, or that no deferred tools remain. Applies when the router lists the catalog itself; a client whose own tool search was adopted lists its deferred tools itself and is not re-announced. The announcement shares the result budget of the turn and is skipped when it does not fit. Absent or false: the catalog index is announced on a user turn only.
        /// </param>
        /// <param name="cascadeMode">
        /// How a universal `tool_search` query reaches the client's own tool search. Absent or `keywords`: a `select:` query becomes the words of the selected names and the limit is always filled. `native`: a `select:` query passes through verbatim when the client search documents `select:`, and the limit field is sent only when the model gave one, unless the client search requires it, in which case its documented default is sent. Experimental.
        /// </param>
        /// <param name="hint">
        /// Universal profile only. Caller text announced to the model with the deferred catalog before its first turn, for example which sources the task needs. Repeated only when it changes. Trimmed before the length bounds apply. Recorded in the `catalog_index` discovery record of the response, so it is replayed with the conversation.
        /// </param>
        /// <param name="interface">
        /// How the universal profile exposes the hidden catalog to the provider. Absent or `wrappers`: the `tool_search` and `tool_exec` tools. `code_mode`: one `tool_code` tool that runs a short JavaScript program in which `search()` and `call()` reach the catalog, so several searches and calls complete in one tool result. Experimental.
        /// </param>
        /// <param name="minDeferredTools">
        /// Universal profile only. When fewer tools than this would be deferred, the universal profile defers none of them and sends the client tools unchanged, so a harness with a handful of non-core tools and no MCP servers pays no search turn for them. Counted after the interface exclusions; ignored with a custom search, whose client decides what it loads. Absent: every wrappable tool in scope is deferred.
        /// </param>
        /// <param name="protocol"></param>
        /// <param name="scope">
        /// Which tools the universal profile defers. Absent or `all`: every wrappable tool outside the coding-harness core set. `mcp`: only MCP server tools (`mcp__*` names and Responses namespaces outside `functions`); the harness keeps its own built-in tools direct. `client`: only the tools the client itself marked `defer_loading`, so a harness with its own tool search keeps its other direct tools direct; an adopted client tool search is still replaced by the router wrappers, and a client-deferred tool the router cannot wrap stays direct. Experimental.
        /// </param>
        /// <param name="validation">
        /// Where tool-call arguments are checked against the original schema. Only `runtime` (in OpenRouter) is available in this release.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeferredToolsControl(
            global::OpenRouter.DeferredToolsControlProfile profile,
            global::OpenRouter.DeferredToolsSearchStrategy search,
            bool? announceCatalogChanges,
            global::OpenRouter.DeferredToolsControlCascadeMode? cascadeMode,
            string? hint,
            global::OpenRouter.DeferredToolsControlInterface? @interface,
            int? minDeferredTools,
            global::OpenRouter.DeferredToolsControlProtocol protocol,
            global::OpenRouter.DeferredToolsControlScope? scope,
            global::OpenRouter.DeferredToolsControlValidation validation)
        {
            this.AnnounceCatalogChanges = announceCatalogChanges;
            this.CascadeMode = cascadeMode;
            this.Hint = hint;
            this.Interface = @interface;
            this.MinDeferredTools = minDeferredTools;
            this.Profile = profile;
            this.Protocol = protocol;
            this.Scope = scope;
            this.Search = search;
            this.Validation = validation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeferredToolsControl" /> class.
        /// </summary>
        public DeferredToolsControl()
        {
        }

    }
}