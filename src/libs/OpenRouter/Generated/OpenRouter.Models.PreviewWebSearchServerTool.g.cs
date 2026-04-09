
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Web search preview tool configuration
    /// </summary>
    public sealed partial class PreviewWebSearchServerTool
    {
        /// <summary>
        /// Which search engine to use. "auto" (default) uses native if the provider supports it, otherwise Exa. "native" forces the provider's built-in search. "exa" forces the Exa search API. "firecrawl" uses Firecrawl (requires BYOK). "parallel" uses the Parallel search API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("engine")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.WebSearchEngineEnumJsonConverter))]
        public global::OpenRouter.WebSearchEngineEnum? Engine { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::OpenRouter.WebSearchDomainFilter? Filters { get; set; }

        /// <summary>
        /// Maximum number of search results to return per search call. Defaults to 5. Applies to Exa, Firecrawl, and Parallel engines; ignored with native provider search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_results")]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Size of the search context for web search tools
        /// </summary>
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_location")]
        public global::OpenRouter.PreviewWebSearchUserLocation? UserLocation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewWebSearchServerTool" /> class.
        /// </summary>
        /// <param name="engine">
        /// Which search engine to use. "auto" (default) uses native if the provider supports it, otherwise Exa. "native" forces the provider's built-in search. "exa" forces the Exa search API. "firecrawl" uses Firecrawl (requires BYOK). "parallel" uses the Parallel search API.
        /// </param>
        /// <param name="filters"></param>
        /// <param name="maxResults">
        /// Maximum number of search results to return per search call. Defaults to 5. Applies to Exa, Firecrawl, and Parallel engines; ignored with native provider search.
        /// </param>
        /// <param name="searchContextSize">
        /// Size of the search context for web search tools
        /// </param>
        /// <param name="type"></param>
        /// <param name="userLocation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PreviewWebSearchServerTool(
            global::OpenRouter.WebSearchEngineEnum? engine,
            global::OpenRouter.WebSearchDomainFilter? filters,
            int? maxResults,
            global::OpenRouter.SearchContextSizeEnum? searchContextSize,
            global::OpenRouter.PreviewWebSearchServerToolType type,
            global::OpenRouter.PreviewWebSearchUserLocation? userLocation)
        {
            this.Engine = engine;
            this.Filters = filters;
            this.MaxResults = maxResults;
            this.SearchContextSize = searchContextSize;
            this.Type = type;
            this.UserLocation = userLocation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewWebSearchServerTool" /> class.
        /// </summary>
        public PreviewWebSearchServerTool()
        {
        }
    }
}