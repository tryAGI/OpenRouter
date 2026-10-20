
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Provider routing preferences and provider-specific passthrough configuration.<br/>
    /// Example: {"allow_fallbacks":false,"only":["google-ai-studio"]}
    /// </summary>
    public sealed partial class ImageGenerationProviderPreferences
    {
        /// <summary>
        /// Whether to allow backup providers to serve requests<br/>
        /// - true: (default) when the primary provider (or your custom providers in "order") is unavailable, use the next best provider.<br/>
        /// - false: use only the primary/custom provider, and return the upstream error if it's unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_fallbacks")]
        public bool? AllowFallbacks { get; set; }

        /// <summary>
        /// Data collection setting. If no available model provider meets the requirement, your request will return an error.<br/>
        /// - allow: (default) allow providers which store user data non-transiently and may train on it<br/>
        /// - deny: use only providers which do not collect user data.<br/>
        /// Example: allow
        /// </summary>
        /// <example>allow</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_collection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ImageGenerationProviderPreferencesDataCollectionJsonConverter))]
        public global::OpenRouter.ImageGenerationProviderPreferencesDataCollection? DataCollection { get; set; }

        /// <summary>
        /// List of provider slugs to ignore. If provided, this list is merged with your account-wide ignored provider settings for this request.<br/>
        /// Example: [openai, anthropic]
        /// </summary>
        /// <example>[openai, anthropic]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignore")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ProviderName?, string>>? Ignore { get; set; }

        /// <summary>
        /// List of provider slugs to allow. If provided, this list is merged with your account-wide allowed provider settings for this request.<br/>
        /// Example: [openai, anthropic]
        /// </summary>
        /// <example>[openai, anthropic]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("only")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ProviderName?, string>>? Only { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AllOfJsonConverter<global::OpenRouter.ProviderOptions, object>))]
        public global::OpenRouter.AllOf<global::OpenRouter.ProviderOptions, object>? Options { get; set; }

        /// <summary>
        /// An ordered list of provider slugs. The router will attempt to use the first provider in the subset of this list that supports your requested model, and fall back to the next if it is unavailable. If no providers are available, the request will fail with an error message.<br/>
        /// Example: [openai, anthropic]
        /// </summary>
        /// <example>[openai, anthropic]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ProviderName?, string>>? Order { get; set; }

        /// <summary>
        /// The sorting strategy to use for this request, if "order" is not specified. When set, no load balancing is performed.<br/>
        /// Example: price
        /// </summary>
        /// <example>price</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<global::OpenRouter.ProviderSort?, global::OpenRouter.ProviderSortConfig>))]
        public global::OpenRouter.AnyOf<global::OpenRouter.ProviderSort?, global::OpenRouter.ProviderSortConfig>? Sort { get; set; }

        /// <summary>
        /// Whether to restrict routing to only ZDR (Zero Data Retention) endpoints. When true, only endpoints that do not retain prompts will be used.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("zdr")]
        public bool? Zdr { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationProviderPreferences" /> class.
        /// </summary>
        /// <param name="allowFallbacks">
        /// Whether to allow backup providers to serve requests<br/>
        /// - true: (default) when the primary provider (or your custom providers in "order") is unavailable, use the next best provider.<br/>
        /// - false: use only the primary/custom provider, and return the upstream error if it's unavailable.
        /// </param>
        /// <param name="dataCollection">
        /// Data collection setting. If no available model provider meets the requirement, your request will return an error.<br/>
        /// - allow: (default) allow providers which store user data non-transiently and may train on it<br/>
        /// - deny: use only providers which do not collect user data.<br/>
        /// Example: allow
        /// </param>
        /// <param name="ignore">
        /// List of provider slugs to ignore. If provided, this list is merged with your account-wide ignored provider settings for this request.<br/>
        /// Example: [openai, anthropic]
        /// </param>
        /// <param name="only">
        /// List of provider slugs to allow. If provided, this list is merged with your account-wide allowed provider settings for this request.<br/>
        /// Example: [openai, anthropic]
        /// </param>
        /// <param name="options"></param>
        /// <param name="order">
        /// An ordered list of provider slugs. The router will attempt to use the first provider in the subset of this list that supports your requested model, and fall back to the next if it is unavailable. If no providers are available, the request will fail with an error message.<br/>
        /// Example: [openai, anthropic]
        /// </param>
        /// <param name="sort">
        /// The sorting strategy to use for this request, if "order" is not specified. When set, no load balancing is performed.<br/>
        /// Example: price
        /// </param>
        /// <param name="zdr">
        /// Whether to restrict routing to only ZDR (Zero Data Retention) endpoints. When true, only endpoints that do not retain prompts will be used.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationProviderPreferences(
            bool? allowFallbacks,
            global::OpenRouter.ImageGenerationProviderPreferencesDataCollection? dataCollection,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ProviderName?, string>>? ignore,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ProviderName?, string>>? only,
            global::OpenRouter.AllOf<global::OpenRouter.ProviderOptions, object>? options,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ProviderName?, string>>? order,
            global::OpenRouter.AnyOf<global::OpenRouter.ProviderSort?, global::OpenRouter.ProviderSortConfig>? sort,
            bool? zdr)
        {
            this.AllowFallbacks = allowFallbacks;
            this.DataCollection = dataCollection;
            this.Ignore = ignore;
            this.Only = only;
            this.Options = options;
            this.Order = order;
            this.Sort = sort;
            this.Zdr = zdr;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationProviderPreferences" /> class.
        /// </summary>
        public ImageGenerationProviderPreferences()
        {
        }

    }
}