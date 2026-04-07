
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebSearchPlugin
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_results")]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_prompt")]
        public string? SearchPrompt { get; set; }

        /// <summary>
        /// The search engine to use for web search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("engine")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.WebSearchEngineJsonConverter))]
        public global::OpenRouter.WebSearchEngine? Engine { get; set; }

        /// <summary>
        /// A list of domains to restrict web search results to. Supports wildcards (e.g. "*.substack.com") and path filtering (e.g. "openai.com/blog").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_domains")]
        public global::System.Collections.Generic.IList<string>? IncludeDomains { get; set; }

        /// <summary>
        /// A list of domains to exclude from web search results. Supports wildcards (e.g. "*.substack.com") and path filtering (e.g. "openai.com/blog").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_domains")]
        public global::System.Collections.Generic.IList<string>? ExcludeDomains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchPlugin" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="enabled">
        /// Set to false to disable the web-search plugin for this request. Defaults to true.
        /// </param>
        /// <param name="maxResults"></param>
        /// <param name="searchPrompt"></param>
        /// <param name="engine">
        /// The search engine to use for web search.
        /// </param>
        /// <param name="includeDomains">
        /// A list of domains to restrict web search results to. Supports wildcards (e.g. "*.substack.com") and path filtering (e.g. "openai.com/blog").
        /// </param>
        /// <param name="excludeDomains">
        /// A list of domains to exclude from web search results. Supports wildcards (e.g. "*.substack.com") and path filtering (e.g. "openai.com/blog").
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchPlugin(
            global::OpenRouter.WebSearchPluginId id,
            bool? enabled,
            int? maxResults,
            string? searchPrompt,
            global::OpenRouter.WebSearchEngine? engine,
            global::System.Collections.Generic.IList<string>? includeDomains,
            global::System.Collections.Generic.IList<string>? excludeDomains)
        {
            this.Id = id;
            this.Enabled = enabled;
            this.MaxResults = maxResults;
            this.SearchPrompt = searchPrompt;
            this.Engine = engine;
            this.IncludeDomains = includeDomains;
            this.ExcludeDomains = excludeDomains;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchPlugin" /> class.
        /// </summary>
        public WebSearchPlugin()
        {
        }
    }
}