
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Opt-in versioned router-level deferred-tool protocol. Replay assistant reasoning unchanged on continuation; keep the catalog unchanged.<br/>
    /// Example: {"profile":"portable","protocol":"v1","search":{"max_results":5,"type":"bm25"},"validation":"runtime"}
    /// </summary>
    public sealed partial class DeferredToolsControl
    {
        /// <summary>
        /// How the universal profile exposes the hidden catalog to the provider. Absent or `wrappers`: the `tool_search` and `tool_exec` tools. `code_mode`: one `tool_code` tool that runs a short JavaScript program in which `search()` and `call()` reach the catalog, so several searches and calls complete in one tool result. Experimental.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interface")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.DeferredToolsControlInterfaceJsonConverter))]
        public global::OpenRouter.DeferredToolsControlInterface? Interface { get; set; }

        /// <summary>
        /// Loading profile. `portable` serves the `defer_loading` tools with router-built search and call wrappers on any model and keeps the catalog fixed. `universal` defers every wrappable tool behind the same wrappers so the provider-facing tool list never changes, and rebuilds the catalog from each request so tools can be added or removed mid-conversation.
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
        /// Which tools the universal profile defers. Absent or `all`: every wrappable tool outside the coding-harness core set. `mcp`: only MCP server tools (`mcp__*` names and Responses namespaces outside `functions`); the harness keeps its own built-in tools direct. Experimental.
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
        /// Loading profile. `portable` serves the `defer_loading` tools with router-built search and call wrappers on any model and keeps the catalog fixed. `universal` defers every wrappable tool behind the same wrappers so the provider-facing tool list never changes, and rebuilds the catalog from each request so tools can be added or removed mid-conversation.
        /// </param>
        /// <param name="search">
        /// Router-local regex/BM25 or caller-owned custom search.<br/>
        /// Example: {"max_results":5,"type":"bm25"}
        /// </param>
        /// <param name="interface">
        /// How the universal profile exposes the hidden catalog to the provider. Absent or `wrappers`: the `tool_search` and `tool_exec` tools. `code_mode`: one `tool_code` tool that runs a short JavaScript program in which `search()` and `call()` reach the catalog, so several searches and calls complete in one tool result. Experimental.
        /// </param>
        /// <param name="protocol"></param>
        /// <param name="scope">
        /// Which tools the universal profile defers. Absent or `all`: every wrappable tool outside the coding-harness core set. `mcp`: only MCP server tools (`mcp__*` names and Responses namespaces outside `functions`); the harness keeps its own built-in tools direct. Experimental.
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
            global::OpenRouter.DeferredToolsControlInterface? @interface,
            global::OpenRouter.DeferredToolsControlProtocol protocol,
            global::OpenRouter.DeferredToolsControlScope? scope,
            global::OpenRouter.DeferredToolsControlValidation validation)
        {
            this.Interface = @interface;
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