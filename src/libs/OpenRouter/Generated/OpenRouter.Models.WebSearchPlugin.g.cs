
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"enabled":true,"id":"web","max_results":5}
    /// </summary>
    public sealed partial class WebSearchPlugin
    {
        /// <summary>
        /// Set to false to disable the web-search plugin for this request. Defaults to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The search engine to use for web search.<br/>
        /// Example: exa
        /// </summary>
        /// <example>exa</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("engine")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.WebSearchEngineJsonConverter))]
        public global::OpenRouter.WebSearchEngine? Engine { get; set; }

        /// <summary>
        /// A list of domains to exclude from web search results. Supports wildcards (e.g. "*.substack.com") and path filtering (e.g. "openai.com/blog").<br/>
        /// Example: [example.com, *.substack.com, openai.com/blog]
        /// </summary>
        /// <example>[example.com, *.substack.com, openai.com/blog]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_domains")]
        public global::System.Collections.Generic.IList<string>? ExcludeDomains { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.WebSearchPluginIdJsonConverter))]
        public global::OpenRouter.WebSearchPluginId Id { get; set; }

        /// <summary>
        /// A list of domains to restrict web search results to. Supports wildcards (e.g. "*.substack.com") and path filtering (e.g. "openai.com/blog").<br/>
        /// Example: [example.com, *.substack.com, openai.com/blog]
        /// </summary>
        /// <example>[example.com, *.substack.com, openai.com/blog]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_domains")]
        public global::System.Collections.Generic.IList<string>? IncludeDomains { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_results")]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Maximum number of times the model can invoke web search in a single turn. Passed through to native providers that support it (e.g. Anthropic).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_uses")]
        public int? MaxUses { get; set; }

        /// <summary>
        /// Engine-native search mode. Exa supports instant, fast, auto (default), deep-lite, deep, and deep-reasoning. Parallel supports turbo, fast, basic (default), and advanced. Modes unsupported by the selected engine are ignored.<br/>
        /// Example: auto
        /// </summary>
        /// <example>auto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.WebSearchModeJsonConverter))]
        public global::OpenRouter.WebSearchMode? Mode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_prompt")]
        public string? SearchPrompt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_location")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AllOfJsonConverter<global::OpenRouter.WebSearchUserLocation, object>))]
        public global::OpenRouter.AllOf<global::OpenRouter.WebSearchUserLocation, object>? UserLocation { get; set; }

        /// <summary>
        /// Enable SpaceXAI X (Twitter) search alongside native web search, with optional filters. Only applies to SpaceXAI endpoints with native search; omit to search the web only. X search is billed separately by SpaceXAI, per post and per user profile fetched.<br/>
        /// Example: {"allowed_x_handles":["OpenRouterAI"],"from_date":"2025-01-01"}
        /// </summary>
        /// <example>{"allowed_x_handles":["OpenRouterAI"],"from_date":"2025-01-01"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("x_search")]
        public global::OpenRouter.XSearchOptions? XSearch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchPlugin" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Set to false to disable the web-search plugin for this request. Defaults to true.
        /// </param>
        /// <param name="engine">
        /// The search engine to use for web search.<br/>
        /// Example: exa
        /// </param>
        /// <param name="excludeDomains">
        /// A list of domains to exclude from web search results. Supports wildcards (e.g. "*.substack.com") and path filtering (e.g. "openai.com/blog").<br/>
        /// Example: [example.com, *.substack.com, openai.com/blog]
        /// </param>
        /// <param name="id"></param>
        /// <param name="includeDomains">
        /// A list of domains to restrict web search results to. Supports wildcards (e.g. "*.substack.com") and path filtering (e.g. "openai.com/blog").<br/>
        /// Example: [example.com, *.substack.com, openai.com/blog]
        /// </param>
        /// <param name="maxResults"></param>
        /// <param name="maxUses">
        /// Maximum number of times the model can invoke web search in a single turn. Passed through to native providers that support it (e.g. Anthropic).
        /// </param>
        /// <param name="mode">
        /// Engine-native search mode. Exa supports instant, fast, auto (default), deep-lite, deep, and deep-reasoning. Parallel supports turbo, fast, basic (default), and advanced. Modes unsupported by the selected engine are ignored.<br/>
        /// Example: auto
        /// </param>
        /// <param name="searchPrompt"></param>
        /// <param name="userLocation"></param>
        /// <param name="xSearch">
        /// Enable SpaceXAI X (Twitter) search alongside native web search, with optional filters. Only applies to SpaceXAI endpoints with native search; omit to search the web only. X search is billed separately by SpaceXAI, per post and per user profile fetched.<br/>
        /// Example: {"allowed_x_handles":["OpenRouterAI"],"from_date":"2025-01-01"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchPlugin(
            bool? enabled,
            global::OpenRouter.WebSearchEngine? engine,
            global::System.Collections.Generic.IList<string>? excludeDomains,
            global::OpenRouter.WebSearchPluginId id,
            global::System.Collections.Generic.IList<string>? includeDomains,
            int? maxResults,
            int? maxUses,
            global::OpenRouter.WebSearchMode? mode,
            string? searchPrompt,
            global::OpenRouter.AllOf<global::OpenRouter.WebSearchUserLocation, object>? userLocation,
            global::OpenRouter.XSearchOptions? xSearch)
        {
            this.Enabled = enabled;
            this.Engine = engine;
            this.ExcludeDomains = excludeDomains;
            this.Id = id;
            this.IncludeDomains = includeDomains;
            this.MaxResults = maxResults;
            this.MaxUses = maxUses;
            this.Mode = mode;
            this.SearchPrompt = searchPrompt;
            this.UserLocation = userLocation;
            this.XSearch = xSearch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchPlugin" /> class.
        /// </summary>
        public WebSearchPlugin()
        {
        }

    }
}