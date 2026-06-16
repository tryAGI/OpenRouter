
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Web search tool using OpenAI Responses API syntax. Automatically converted to openrouter:web_search.
    /// </summary>
    public sealed partial class ChatWebSearchShorthand
    {
        /// <summary>
        /// Limit search results to these domains. Supported by Exa, Firecrawl, Parallel, Perplexity, and most native providers (Anthropic, OpenAI, xAI). Cannot be used with excluded_domains.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_domains")]
        public global::System.Collections.Generic.IList<string>? AllowedDomains { get; set; }

        /// <summary>
        /// Which search engine to use. "auto" (default) uses native if the provider supports it, otherwise Exa. "native" forces the provider's built-in search. "exa" forces the Exa search API. "firecrawl" uses Firecrawl (requires BYOK). "parallel" uses the Parallel search API. "perplexity" uses the Perplexity Search API (raw ranked results).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("engine")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.WebSearchEngineEnumJsonConverter))]
        public global::OpenRouter.WebSearchEngineEnum? Engine { get; set; }

        /// <summary>
        /// Exclude search results from these domains. Supported by Exa, Firecrawl, Parallel, Perplexity, Anthropic, and xAI. Not supported with OpenAI (silently ignored). Cannot be used with allowed_domains.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excluded_domains")]
        public global::System.Collections.Generic.IList<string>? ExcludedDomains { get; set; }

        /// <summary>
        /// Exact maximum number of characters of content per search result. Applies to the Exa, Parallel, and Perplexity engines; ignored with native provider search and Firecrawl. For Exa, caps highlight content per result. For Parallel, caps excerpt content per result (default 1,500 when omitted). For Perplexity, maps to the native `max_tokens_per_page` parameter (converted from characters to tokens) and trims the response to the exact character cap. When both `max_characters` and `search_context_size` are set, `max_characters` takes precedence. When omitted, falls back to `search_context_size` mapping (Exa) or engine defaults (Parallel, Perplexity).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_characters")]
        public int? MaxCharacters { get; set; }

        /// <summary>
        /// Maximum number of search results to return per search call. Defaults to 5. Applies to Exa, Firecrawl, Parallel, and Perplexity engines; ignored with native provider search. Perplexity supports a maximum of 20; values above 20 are clamped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_results")]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Maximum total number of search results across all search calls in a single request. Once this limit is reached, the tool will stop returning new results. Useful for controlling cost and context size in agentic loops. Defaults to 50 when not specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_total_results")]
        public int? MaxTotalResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::OpenRouter.WebSearchConfig? Parameters { get; set; }

        /// <summary>
        /// How much context to retrieve per result. Applies to Exa, Parallel, and Perplexity engines; ignored with native provider search and Firecrawl. For Exa, pins a fixed per-result character cap (low=5,000, medium=15,000, high=30,000); when omitted, Exa picks an adaptive size per query and document (typically ~2,000–4,000 characters per result). For Parallel, controls the total characters across all results; when omitted, Parallel uses its own default size. For Perplexity, maps directly to the Search API's native search_context_size parameter. Overridden by `max_characters` when both are set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_context_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.SearchQualityLevelJsonConverter))]
        public global::OpenRouter.SearchQualityLevel? SearchContextSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatWebSearchShorthandTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ChatWebSearchShorthandType Type { get; set; }

        /// <summary>
        /// Approximate user location for location-biased results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_location")]
        public global::OpenRouter.WebSearchUserLocationServerTool? UserLocation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatWebSearchShorthand" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="allowedDomains">
        /// Limit search results to these domains. Supported by Exa, Firecrawl, Parallel, Perplexity, and most native providers (Anthropic, OpenAI, xAI). Cannot be used with excluded_domains.
        /// </param>
        /// <param name="engine">
        /// Which search engine to use. "auto" (default) uses native if the provider supports it, otherwise Exa. "native" forces the provider's built-in search. "exa" forces the Exa search API. "firecrawl" uses Firecrawl (requires BYOK). "parallel" uses the Parallel search API. "perplexity" uses the Perplexity Search API (raw ranked results).
        /// </param>
        /// <param name="excludedDomains">
        /// Exclude search results from these domains. Supported by Exa, Firecrawl, Parallel, Perplexity, Anthropic, and xAI. Not supported with OpenAI (silently ignored). Cannot be used with allowed_domains.
        /// </param>
        /// <param name="maxCharacters">
        /// Exact maximum number of characters of content per search result. Applies to the Exa, Parallel, and Perplexity engines; ignored with native provider search and Firecrawl. For Exa, caps highlight content per result. For Parallel, caps excerpt content per result (default 1,500 when omitted). For Perplexity, maps to the native `max_tokens_per_page` parameter (converted from characters to tokens) and trims the response to the exact character cap. When both `max_characters` and `search_context_size` are set, `max_characters` takes precedence. When omitted, falls back to `search_context_size` mapping (Exa) or engine defaults (Parallel, Perplexity).
        /// </param>
        /// <param name="maxResults">
        /// Maximum number of search results to return per search call. Defaults to 5. Applies to Exa, Firecrawl, Parallel, and Perplexity engines; ignored with native provider search. Perplexity supports a maximum of 20; values above 20 are clamped.
        /// </param>
        /// <param name="maxTotalResults">
        /// Maximum total number of search results across all search calls in a single request. Once this limit is reached, the tool will stop returning new results. Useful for controlling cost and context size in agentic loops. Defaults to 50 when not specified.
        /// </param>
        /// <param name="parameters"></param>
        /// <param name="searchContextSize">
        /// How much context to retrieve per result. Applies to Exa, Parallel, and Perplexity engines; ignored with native provider search and Firecrawl. For Exa, pins a fixed per-result character cap (low=5,000, medium=15,000, high=30,000); when omitted, Exa picks an adaptive size per query and document (typically ~2,000–4,000 characters per result). For Parallel, controls the total characters across all results; when omitted, Parallel uses its own default size. For Perplexity, maps directly to the Search API's native search_context_size parameter. Overridden by `max_characters` when both are set.
        /// </param>
        /// <param name="userLocation">
        /// Approximate user location for location-biased results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatWebSearchShorthand(
            global::OpenRouter.ChatWebSearchShorthandType type,
            global::System.Collections.Generic.IList<string>? allowedDomains,
            global::OpenRouter.WebSearchEngineEnum? engine,
            global::System.Collections.Generic.IList<string>? excludedDomains,
            int? maxCharacters,
            int? maxResults,
            int? maxTotalResults,
            global::OpenRouter.WebSearchConfig? parameters,
            global::OpenRouter.SearchQualityLevel? searchContextSize,
            global::OpenRouter.WebSearchUserLocationServerTool? userLocation)
        {
            this.AllowedDomains = allowedDomains;
            this.Engine = engine;
            this.ExcludedDomains = excludedDomains;
            this.MaxCharacters = maxCharacters;
            this.MaxResults = maxResults;
            this.MaxTotalResults = maxTotalResults;
            this.Parameters = parameters;
            this.SearchContextSize = searchContextSize;
            this.Type = type;
            this.UserLocation = userLocation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatWebSearchShorthand" /> class.
        /// </summary>
        public ChatWebSearchShorthand()
        {
        }

    }
}