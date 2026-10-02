
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// When multiple model providers are available, optionally indicate your routing preference.<br/>
    /// Example: {"allow_fallbacks":true}
    /// </summary>
    public sealed partial class ProviderPreferences
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ProviderPreferencesDataCollectionJsonConverter))]
        public global::OpenRouter.ProviderPreferencesDataCollection? DataCollection { get; set; }

        /// <summary>
        /// Whether to restrict routing to only models that allow text distillation. When true, only models where the author has allowed distillation will be used.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforce_distillable_text")]
        public bool? EnforceDistillableText { get; set; }

        /// <summary>
        /// List of provider slugs to ignore. If provided, this list is merged with your account-wide ignored provider settings for this request.<br/>
        /// Example: [openai, anthropic]
        /// </summary>
        /// <example>[openai, anthropic]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignore")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ProviderName?, string>>? Ignore { get; set; }

        /// <summary>
        /// The object specifying the maximum price you want to pay for this request. USD price per million tokens, for prompt and completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_price")]
        public global::OpenRouter.ProviderPreferencesMaxPrice? MaxPrice { get; set; }

        /// <summary>
        /// List of provider slugs to allow. If provided, this list is merged with your account-wide allowed provider settings for this request.<br/>
        /// Example: [openai, anthropic]
        /// </summary>
        /// <example>[openai, anthropic]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("only")]
        public global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ProviderName?, string>>? Only { get; set; }

        /// <summary>
        /// Provider-specific options keyed by provider slug. Only options for the matched provider are forwarded; the rest are ignored. Unrecognized keys are silently dropped.<br/>
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
        /// Preferred maximum latency (in seconds). Can be a number (applies to p50) or an object with percentile-specific cutoffs. Endpoints above the threshold(s) may still be used, but are deprioritized in routing. When using fallback models, this may cause a fallback model to be used instead of the primary model if it meets the threshold.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("preferred_max_latency")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.PreferredMaxLatencyJsonConverter))]
        public global::OpenRouter.PreferredMaxLatency? PreferredMaxLatency { get; set; }

        /// <summary>
        /// Preferred minimum throughput (in tokens per second). Can be a number (applies to p50) or an object with percentile-specific cutoffs. Endpoints below the threshold(s) may still be used, but are deprioritized in routing. When using fallback models, this may cause a fallback model to be used instead of the primary model if it meets the threshold.<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("preferred_min_throughput")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.PreferredMinThroughputJsonConverter))]
        public global::OpenRouter.PreferredMinThroughput? PreferredMinThroughput { get; set; }

        /// <summary>
        /// A list of quantization levels to filter the provider by.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantizations")]
        public global::System.Collections.Generic.IList<global::OpenRouter.Quantization>? Quantizations { get; set; }

        /// <summary>
        /// Whether to filter providers to only those that support the parameters you've provided. If this setting is omitted or set to false, then providers will receive only the parameters they support, and ignore the rest.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_parameters")]
        public bool? RequireParameters { get; set; }

        /// <summary>
        /// The sorting strategy to use for this request, if "order" is not specified. When set, no load balancing is performed.<br/>
        /// Example: price
        /// </summary>
        /// <example>price</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<global::OpenRouter.ProviderSort?, global::OpenRouter.ProviderSortConfig, object>))]
        public global::OpenRouter.AnyOf<global::OpenRouter.ProviderSort?, global::OpenRouter.ProviderSortConfig, object>? Sort { get; set; }

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
        /// Initializes a new instance of the <see cref="ProviderPreferences" /> class.
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
        /// <param name="enforceDistillableText">
        /// Whether to restrict routing to only models that allow text distillation. When true, only models where the author has allowed distillation will be used.<br/>
        /// Example: true
        /// </param>
        /// <param name="ignore">
        /// List of provider slugs to ignore. If provided, this list is merged with your account-wide ignored provider settings for this request.<br/>
        /// Example: [openai, anthropic]
        /// </param>
        /// <param name="maxPrice">
        /// The object specifying the maximum price you want to pay for this request. USD price per million tokens, for prompt and completion.
        /// </param>
        /// <param name="only">
        /// List of provider slugs to allow. If provided, this list is merged with your account-wide allowed provider settings for this request.<br/>
        /// Example: [openai, anthropic]
        /// </param>
        /// <param name="options">
        /// Provider-specific options keyed by provider slug. Only options for the matched provider are forwarded; the rest are ignored. Unrecognized keys are silently dropped.<br/>
        /// Example: {"openai":{"max_tokens":1000}}
        /// </param>
        /// <param name="order">
        /// An ordered list of provider slugs. The router will attempt to use the first provider in the subset of this list that supports your requested model, and fall back to the next if it is unavailable. If no providers are available, the request will fail with an error message.<br/>
        /// Example: [openai, anthropic]
        /// </param>
        /// <param name="preferredMaxLatency">
        /// Preferred maximum latency (in seconds). Can be a number (applies to p50) or an object with percentile-specific cutoffs. Endpoints above the threshold(s) may still be used, but are deprioritized in routing. When using fallback models, this may cause a fallback model to be used instead of the primary model if it meets the threshold.<br/>
        /// Example: 5
        /// </param>
        /// <param name="preferredMinThroughput">
        /// Preferred minimum throughput (in tokens per second). Can be a number (applies to p50) or an object with percentile-specific cutoffs. Endpoints below the threshold(s) may still be used, but are deprioritized in routing. When using fallback models, this may cause a fallback model to be used instead of the primary model if it meets the threshold.<br/>
        /// Example: 100
        /// </param>
        /// <param name="quantizations">
        /// A list of quantization levels to filter the provider by.
        /// </param>
        /// <param name="requireParameters">
        /// Whether to filter providers to only those that support the parameters you've provided. If this setting is omitted or set to false, then providers will receive only the parameters they support, and ignore the rest.
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
        public ProviderPreferences(
            bool? allowFallbacks,
            global::OpenRouter.ProviderPreferencesDataCollection? dataCollection,
            bool? enforceDistillableText,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ProviderName?, string>>? ignore,
            global::OpenRouter.ProviderPreferencesMaxPrice? maxPrice,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ProviderName?, string>>? only,
            global::OpenRouter.ProviderOptions? options,
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<global::OpenRouter.ProviderName?, string>>? order,
            global::OpenRouter.PreferredMaxLatency? preferredMaxLatency,
            global::OpenRouter.PreferredMinThroughput? preferredMinThroughput,
            global::System.Collections.Generic.IList<global::OpenRouter.Quantization>? quantizations,
            bool? requireParameters,
            global::OpenRouter.AnyOf<global::OpenRouter.ProviderSort?, global::OpenRouter.ProviderSortConfig, object>? sort,
            bool? zdr)
        {
            this.AllowFallbacks = allowFallbacks;
            this.DataCollection = dataCollection;
            this.EnforceDistillableText = enforceDistillableText;
            this.Ignore = ignore;
            this.MaxPrice = maxPrice;
            this.Only = only;
            this.Options = options;
            this.Order = order;
            this.PreferredMaxLatency = preferredMaxLatency;
            this.PreferredMinThroughput = preferredMinThroughput;
            this.Quantizations = quantizations;
            this.RequireParameters = requireParameters;
            this.Sort = sort;
            this.Zdr = zdr;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderPreferences" /> class.
        /// </summary>
        public ProviderPreferences()
        {
        }

    }
}