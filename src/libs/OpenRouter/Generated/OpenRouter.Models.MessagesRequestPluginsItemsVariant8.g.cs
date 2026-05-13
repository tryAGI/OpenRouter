
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// web variant
    /// </summary>
    public sealed partial class MessagesRequestPluginsItemsVariant8
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.WebSearchPluginIdJsonConverter))]
        public global::OpenRouter.WebSearchPluginId Id { get; set; }

        /// <summary>
        /// Set to false to disable the web-search plugin for this request. Defaults to true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The search engine to use for web search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("engine")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.WebSearchEngineJsonConverter))]
        public global::OpenRouter.WebSearchEngine? Engine { get; set; }

        /// <summary>
        /// A list of domains to exclude from web search results. Supports wildcards (e.g. "*.substack.com") and path filtering (e.g. "openai.com/blog").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_domains")]
        public global::System.Collections.Generic.IList<string>? ExcludeDomains { get; set; }

        /// <summary>
        /// A list of domains to restrict web search results to. Supports wildcards (e.g. "*.substack.com") and path filtering (e.g. "openai.com/blog").
        /// </summary>
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_prompt")]
        public string? SearchPrompt { get; set; }

        /// <summary>
        /// Approximate user location for location-biased search results. Passed through to native providers that support it (e.g. Anthropic).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_location")]
        public global::OpenRouter.WebSearchPluginUserLocation? UserLocation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestPluginsItemsVariant8" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="enabled">
        /// Set to false to disable the web-search plugin for this request. Defaults to true.
        /// </param>
        /// <param name="engine">
        /// The search engine to use for web search.
        /// </param>
        /// <param name="excludeDomains">
        /// A list of domains to exclude from web search results. Supports wildcards (e.g. "*.substack.com") and path filtering (e.g. "openai.com/blog").
        /// </param>
        /// <param name="includeDomains">
        /// A list of domains to restrict web search results to. Supports wildcards (e.g. "*.substack.com") and path filtering (e.g. "openai.com/blog").
        /// </param>
        /// <param name="maxResults"></param>
        /// <param name="maxUses">
        /// Maximum number of times the model can invoke web search in a single turn. Passed through to native providers that support it (e.g. Anthropic).
        /// </param>
        /// <param name="searchPrompt"></param>
        /// <param name="userLocation">
        /// Approximate user location for location-biased search results. Passed through to native providers that support it (e.g. Anthropic).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequestPluginsItemsVariant8(
            global::OpenRouter.WebSearchPluginId id,
            bool? enabled,
            global::OpenRouter.WebSearchEngine? engine,
            global::System.Collections.Generic.IList<string>? excludeDomains,
            global::System.Collections.Generic.IList<string>? includeDomains,
            int? maxResults,
            int? maxUses,
            string? searchPrompt,
            global::OpenRouter.WebSearchPluginUserLocation? userLocation)
        {
            this.Id = id;
            this.Enabled = enabled;
            this.Engine = engine;
            this.ExcludeDomains = excludeDomains;
            this.IncludeDomains = includeDomains;
            this.MaxResults = maxResults;
            this.MaxUses = maxUses;
            this.SearchPrompt = searchPrompt;
            this.UserLocation = userLocation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestPluginsItemsVariant8" /> class.
        /// </summary>
        public MessagesRequestPluginsItemsVariant8()
        {
        }

    }
}