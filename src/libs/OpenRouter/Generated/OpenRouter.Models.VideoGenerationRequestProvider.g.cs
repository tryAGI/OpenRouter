
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Provider routing preferences (order, only, ignore), request-level data policy (zdr, data_collection) and provider-specific passthrough configuration. Sorting by price, latency, or throughput and automatic provider fallbacks are not supported. No video endpoint currently offers Zero Data Retention, so `zdr: true` fails routing.
    /// </summary>
    public sealed partial class VideoGenerationRequestProvider
    {
        /// <summary>
        /// Data collection setting. If no available model provider meets the requirement, your request will return an error.<br/>
        /// - allow: (default) allow providers that may train on user data<br/>
        /// - deny: use only providers that do not train on user data. Providers may still retain prompts; set `zdr: true` to exclude retention.<br/>
        /// Example: allow
        /// </summary>
        /// <example>allow</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_collection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.VideoGenerationRequestProviderDataCollectionJsonConverter))]
        public global::OpenRouter.VideoGenerationRequestProviderDataCollection? DataCollection { get; set; }

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
        /// An ordered list of provider slugs to prefer when choosing an eligible video endpoint. The request is submitted to one endpoint and is not retried on another provider if submission fails.<br/>
        /// Example: [minimax]
        /// </summary>
        /// <example>[minimax]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ProviderName?, string>>? Order { get; set; }

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
        /// Initializes a new instance of the <see cref="VideoGenerationRequestProvider" /> class.
        /// </summary>
        /// <param name="dataCollection">
        /// Data collection setting. If no available model provider meets the requirement, your request will return an error.<br/>
        /// - allow: (default) allow providers that may train on user data<br/>
        /// - deny: use only providers that do not train on user data. Providers may still retain prompts; set `zdr: true` to exclude retention.<br/>
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
        /// An ordered list of provider slugs to prefer when choosing an eligible video endpoint. The request is submitted to one endpoint and is not retried on another provider if submission fails.<br/>
        /// Example: [minimax]
        /// </param>
        /// <param name="zdr">
        /// Whether to restrict routing to only ZDR (Zero Data Retention) endpoints. When true, only endpoints that do not retain prompts will be used.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoGenerationRequestProvider(
            global::OpenRouter.VideoGenerationRequestProviderDataCollection? dataCollection,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ProviderName?, string>>? ignore,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ProviderName?, string>>? only,
            global::OpenRouter.AllOf<global::OpenRouter.ProviderOptions, object>? options,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ProviderName?, string>>? order,
            bool? zdr)
        {
            this.DataCollection = dataCollection;
            this.Ignore = ignore;
            this.Only = only;
            this.Options = options;
            this.Order = order;
            this.Zdr = zdr;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoGenerationRequestProvider" /> class.
        /// </summary>
        public VideoGenerationRequestProvider()
        {
        }

    }
}