
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Web search preview tool configuration<br/>
    /// Example: {"type":"web_search_preview"}
    /// </summary>
    public sealed partial class PreviewWebSearchServerTool
    {
        /// <summary>
        /// Which search engine to use. "auto" (default) uses native if the provider supports it, otherwise Exa. "native" forces the provider's built-in search. "exa" forces the Exa search API. "firecrawl" uses Firecrawl (requires BYOK). "parallel" uses the Parallel search API. "perplexity" uses the Perplexity Search API (raw ranked results).<br/>
        /// Example: auto
        /// </summary>
        /// <example>auto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("engine")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.WebSearchEngineEnumJsonConverter))]
        public global::OpenRouter.WebSearchEngineEnum? Engine { get; set; }

        /// <summary>
        /// Example: {"allowed_domains":["example.com"],"blocked_domains":["spam.com"],"excluded_domains":["spam.com"]}
        /// </summary>
        /// <example>{"allowed_domains":["example.com"],"blocked_domains":["spam.com"],"excluded_domains":["spam.com"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::OpenRouter.WebSearchDomainFilter? Filters { get; set; }

        /// <summary>
        /// Maximum number of search results to return per search call. Defaults to 5. Applies to Exa, Firecrawl, Parallel, and Perplexity engines; ignored with native provider search. Perplexity supports a maximum of 20; values above 20 are clamped.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_results")]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Maximum number of web searches the model may perform in a single request. Once reached, further search calls return an error result instead of executing. Applies to the Exa, Firecrawl, Parallel, and Perplexity engines. With native provider search, forwarded only to Anthropic (as `max_uses`); other native search providers have no equivalent parameter and ignore it.<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
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
        /// Size of the search context for web search tools<br/>
        /// Example: medium
        /// </summary>
        /// <example>medium</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_context_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.SearchContextSizeEnumJsonConverter))]
        public global::OpenRouter.SearchContextSizeEnum? SearchContextSize { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.PreviewWebSearchServerToolTypeJsonConverter))]
        public global::OpenRouter.PreviewWebSearchServerToolType Type { get; set; }

        /// <summary>
        /// Example: {"city":"San Francisco","country":"USA","region":"California","timezone":"America/Los_Angeles","type":"approximate"}
        /// </summary>
        /// <example>{"city":"San Francisco","country":"USA","region":"California","timezone":"America/Los_Angeles","type":"approximate"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_location")]
        public global::OpenRouter.PreviewWebSearchUserLocation? UserLocation { get; set; }

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
        /// Initializes a new instance of the <see cref="PreviewWebSearchServerTool" /> class.
        /// </summary>
        /// <param name="engine">
        /// Which search engine to use. "auto" (default) uses native if the provider supports it, otherwise Exa. "native" forces the provider's built-in search. "exa" forces the Exa search API. "firecrawl" uses Firecrawl (requires BYOK). "parallel" uses the Parallel search API. "perplexity" uses the Perplexity Search API (raw ranked results).<br/>
        /// Example: auto
        /// </param>
        /// <param name="filters">
        /// Example: {"allowed_domains":["example.com"],"blocked_domains":["spam.com"],"excluded_domains":["spam.com"]}
        /// </param>
        /// <param name="maxResults">
        /// Maximum number of search results to return per search call. Defaults to 5. Applies to Exa, Firecrawl, Parallel, and Perplexity engines; ignored with native provider search. Perplexity supports a maximum of 20; values above 20 are clamped.<br/>
        /// Example: 5
        /// </param>
        /// <param name="maxUses">
        /// Maximum number of web searches the model may perform in a single request. Once reached, further search calls return an error result instead of executing. Applies to the Exa, Firecrawl, Parallel, and Perplexity engines. With native provider search, forwarded only to Anthropic (as `max_uses`); other native search providers have no equivalent parameter and ignore it.<br/>
        /// Example: 3
        /// </param>
        /// <param name="mode">
        /// Engine-native search mode. Exa supports instant, fast, auto (default), deep-lite, deep, and deep-reasoning. Parallel supports turbo, fast, basic (default), and advanced. Modes unsupported by the selected engine are ignored.<br/>
        /// Example: auto
        /// </param>
        /// <param name="searchContextSize">
        /// Size of the search context for web search tools<br/>
        /// Example: medium
        /// </param>
        /// <param name="type"></param>
        /// <param name="userLocation">
        /// Example: {"city":"San Francisco","country":"USA","region":"California","timezone":"America/Los_Angeles","type":"approximate"}
        /// </param>
        /// <param name="xSearch">
        /// Enable SpaceXAI X (Twitter) search alongside native web search, with optional filters. Only applies to SpaceXAI endpoints with native search; omit to search the web only. X search is billed separately by SpaceXAI, per post and per user profile fetched.<br/>
        /// Example: {"allowed_x_handles":["OpenRouterAI"],"from_date":"2025-01-01"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PreviewWebSearchServerTool(
            global::OpenRouter.WebSearchEngineEnum? engine,
            global::OpenRouter.WebSearchDomainFilter? filters,
            int? maxResults,
            int? maxUses,
            global::OpenRouter.WebSearchMode? mode,
            global::OpenRouter.SearchContextSizeEnum? searchContextSize,
            global::OpenRouter.PreviewWebSearchServerToolType type,
            global::OpenRouter.PreviewWebSearchUserLocation? userLocation,
            global::OpenRouter.XSearchOptions? xSearch)
        {
            this.Engine = engine;
            this.Filters = filters;
            this.MaxResults = maxResults;
            this.MaxUses = maxUses;
            this.Mode = mode;
            this.SearchContextSize = searchContextSize;
            this.Type = type;
            this.UserLocation = userLocation;
            this.XSearch = xSearch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewWebSearchServerTool" /> class.
        /// </summary>
        public PreviewWebSearchServerTool()
        {
        }

    }
}