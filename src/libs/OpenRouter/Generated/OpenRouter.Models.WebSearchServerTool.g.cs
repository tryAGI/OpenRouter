
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Web search tool configuration (2025-08-26 version)
    /// </summary>
    public sealed partial class WebSearchServerTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.WebSearchServerToolTypeJsonConverter))]
        public global::OpenRouter.WebSearchServerToolType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::OpenRouter.WebSearchDomainFilter? Filters { get; set; }

        /// <summary>
        /// Size of the search context for web search tools
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_context_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.SearchContextSizeEnumJsonConverter))]
        public global::OpenRouter.SearchContextSizeEnum? SearchContextSize { get; set; }

        /// <summary>
        /// User location information for web search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_location")]
        public global::OpenRouter.WebSearchUserLocation? UserLocation { get; set; }

        /// <summary>
        /// Which search engine to use. "auto" (default) uses native if the provider supports it, otherwise Exa. "native" forces the provider's built-in search. "exa" forces the Exa search API. "firecrawl" uses Firecrawl (requires BYOK). "parallel" uses the Parallel search API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("engine")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.WebSearchEngineEnumJsonConverter))]
        public global::OpenRouter.WebSearchEngineEnum? Engine { get; set; }

        /// <summary>
        /// Maximum number of search results to return per search call. Defaults to 5. Applies to Exa, Firecrawl, and Parallel engines; ignored with native provider search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_results")]
        public double? MaxResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchServerTool" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="filters"></param>
        /// <param name="searchContextSize">
        /// Size of the search context for web search tools
        /// </param>
        /// <param name="userLocation">
        /// User location information for web search
        /// </param>
        /// <param name="engine">
        /// Which search engine to use. "auto" (default) uses native if the provider supports it, otherwise Exa. "native" forces the provider's built-in search. "exa" forces the Exa search API. "firecrawl" uses Firecrawl (requires BYOK). "parallel" uses the Parallel search API.
        /// </param>
        /// <param name="maxResults">
        /// Maximum number of search results to return per search call. Defaults to 5. Applies to Exa, Firecrawl, and Parallel engines; ignored with native provider search.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchServerTool(
            global::OpenRouter.WebSearchServerToolType type,
            global::OpenRouter.WebSearchDomainFilter? filters,
            global::OpenRouter.SearchContextSizeEnum? searchContextSize,
            global::OpenRouter.WebSearchUserLocation? userLocation,
            global::OpenRouter.WebSearchEngineEnum? engine,
            double? maxResults)
        {
            this.Type = type;
            this.Filters = filters;
            this.SearchContextSize = searchContextSize;
            this.UserLocation = userLocation;
            this.Engine = engine;
            this.MaxResults = maxResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchServerTool" /> class.
        /// </summary>
        public WebSearchServerTool()
        {
        }
    }
}