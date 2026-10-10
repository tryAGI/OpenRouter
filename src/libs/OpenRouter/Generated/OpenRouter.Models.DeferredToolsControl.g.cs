
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
        /// Loading profile. Only `portable` is available in this release: OpenRouter serves deferral with router-built search and call wrappers on any model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.DeferredToolsControlProfileJsonConverter))]
        public global::OpenRouter.DeferredToolsControlProfile Profile { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protocol")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.DeferredToolsControlProtocolJsonConverter))]
        public global::OpenRouter.DeferredToolsControlProtocol Protocol { get; set; }

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
        /// <param name="search">
        /// Router-local regex/BM25 or caller-owned custom search.<br/>
        /// Example: {"max_results":5,"type":"bm25"}
        /// </param>
        /// <param name="profile">
        /// Loading profile. Only `portable` is available in this release: OpenRouter serves deferral with router-built search and call wrappers on any model.
        /// </param>
        /// <param name="protocol"></param>
        /// <param name="validation">
        /// Where tool-call arguments are checked against the original schema. Only `runtime` (in OpenRouter) is available in this release.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeferredToolsControl(
            global::OpenRouter.DeferredToolsSearchStrategy search,
            global::OpenRouter.DeferredToolsControlProfile profile,
            global::OpenRouter.DeferredToolsControlProtocol protocol,
            global::OpenRouter.DeferredToolsControlValidation validation)
        {
            this.Profile = profile;
            this.Protocol = protocol;
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