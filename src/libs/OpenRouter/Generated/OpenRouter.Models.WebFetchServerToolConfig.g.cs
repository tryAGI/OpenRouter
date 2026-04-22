
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Configuration for the openrouter:web_fetch server tool
    /// </summary>
    public sealed partial class WebFetchServerToolConfig
    {
        /// <summary>
        /// Only fetch from these domains.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_domains")]
        public global::System.Collections.Generic.IList<string>? AllowedDomains { get; set; }

        /// <summary>
        /// Never fetch from these domains.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked_domains")]
        public global::System.Collections.Generic.IList<string>? BlockedDomains { get; set; }

        /// <summary>
        /// Which fetch engine to use. "auto" (default) uses native if the provider supports it, otherwise Exa. "native" forces the provider's built-in fetch. "exa" uses Exa Contents API (supports BYOK). "openrouter" uses direct HTTP fetch. "firecrawl" uses Firecrawl scrape (requires BYOK).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("engine")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.WebFetchEngineEnumJsonConverter))]
        public global::OpenRouter.WebFetchEngineEnum? Engine { get; set; }

        /// <summary>
        /// Maximum content length in approximate tokens. Content exceeding this limit is truncated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_content_tokens")]
        public int? MaxContentTokens { get; set; }

        /// <summary>
        /// Maximum number of web fetches per request. Once exceeded, the tool returns an error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_uses")]
        public int? MaxUses { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebFetchServerToolConfig" /> class.
        /// </summary>
        /// <param name="allowedDomains">
        /// Only fetch from these domains.
        /// </param>
        /// <param name="blockedDomains">
        /// Never fetch from these domains.
        /// </param>
        /// <param name="engine">
        /// Which fetch engine to use. "auto" (default) uses native if the provider supports it, otherwise Exa. "native" forces the provider's built-in fetch. "exa" uses Exa Contents API (supports BYOK). "openrouter" uses direct HTTP fetch. "firecrawl" uses Firecrawl scrape (requires BYOK).
        /// </param>
        /// <param name="maxContentTokens">
        /// Maximum content length in approximate tokens. Content exceeding this limit is truncated.
        /// </param>
        /// <param name="maxUses">
        /// Maximum number of web fetches per request. Once exceeded, the tool returns an error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebFetchServerToolConfig(
            global::System.Collections.Generic.IList<string>? allowedDomains,
            global::System.Collections.Generic.IList<string>? blockedDomains,
            global::OpenRouter.WebFetchEngineEnum? engine,
            int? maxContentTokens,
            int? maxUses)
        {
            this.AllowedDomains = allowedDomains;
            this.BlockedDomains = blockedDomains;
            this.Engine = engine;
            this.MaxContentTokens = maxContentTokens;
            this.MaxUses = maxUses;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebFetchServerToolConfig" /> class.
        /// </summary>
        public WebFetchServerToolConfig()
        {
        }
    }
}