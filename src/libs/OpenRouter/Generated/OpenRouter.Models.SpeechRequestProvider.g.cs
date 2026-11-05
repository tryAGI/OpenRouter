
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Provider configuration: provider routing preferences (`order`, `only`, `ignore`, `allow_fallbacks`), data policy routing preferences (`zdr`, `data_collection`) and provider-specific passthrough options
    /// </summary>
    public sealed partial class SpeechRequestProvider
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.SpeechRequestProviderDataCollectionJsonConverter))]
        public global::OpenRouter.SpeechRequestProviderDataCollection? DataCollection { get; set; }

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
        /// Provider-specific options keyed by provider slug. The provider segment is case-insensitive; an endpoint tag after `/` must match the endpoint slug exactly. Only options for the matched provider are forwarded; the rest are ignored. Unrecognized keys are silently dropped.<br/>
        /// Example: {"openai":{"max_tokens":1000}}
        /// </summary>
        /// <example>{"openai":{"max_tokens":1000}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::OpenRouter.ProviderOptions? Options { get; set; }

        /// <summary>
        /// An ordered list of provider slugs. The router will attempt to use the first provider in the subset of this list that supports your requested model, and fall back to the next if it is unavailable. If no providers are available, the request will fail with an error message.<br/>
        /// Example: [openai, anthropic]
        /// </summary>
        /// <example>[openai, anthropic]</example>
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
        /// Initializes a new instance of the <see cref="SpeechRequestProvider" /> class.
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
        /// <param name="options">
        /// Provider-specific options keyed by provider slug. The provider segment is case-insensitive; an endpoint tag after `/` must match the endpoint slug exactly. Only options for the matched provider are forwarded; the rest are ignored. Unrecognized keys are silently dropped.<br/>
        /// Example: {"openai":{"max_tokens":1000}}
        /// </param>
        /// <param name="order">
        /// An ordered list of provider slugs. The router will attempt to use the first provider in the subset of this list that supports your requested model, and fall back to the next if it is unavailable. If no providers are available, the request will fail with an error message.<br/>
        /// Example: [openai, anthropic]
        /// </param>
        /// <param name="zdr">
        /// Whether to restrict routing to only ZDR (Zero Data Retention) endpoints. When true, only endpoints that do not retain prompts will be used.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechRequestProvider(
            bool? allowFallbacks,
            global::OpenRouter.SpeechRequestProviderDataCollection? dataCollection,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ProviderName?, string>>? ignore,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ProviderName?, string>>? only,
            global::OpenRouter.ProviderOptions? options,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ProviderName?, string>>? order,
            bool? zdr)
        {
            this.AllowFallbacks = allowFallbacks;
            this.DataCollection = dataCollection;
            this.Ignore = ignore;
            this.Only = only;
            this.Options = options;
            this.Order = order;
            this.Zdr = zdr;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechRequestProvider" /> class.
        /// </summary>
        public SpeechRequestProvider()
        {
        }

    }
}