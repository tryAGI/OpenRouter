
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Provider routing preferences and provider-specific passthrough configuration.
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
        /// List of provider slugs to ignore. If provided, this list is merged with your account-wide ignored provider settings for this request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignore")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ImageGenerationProviderPreferencesIgnoreItems>? Ignore { get; set; }

        /// <summary>
        /// List of provider slugs to allow. If provided, this list is merged with your account-wide allowed provider settings for this request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("only")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ImageGenerationProviderPreferencesOnlyItems>? Only { get; set; }

        /// <summary>
        /// Provider-specific options keyed by provider slug. Only options for the matched provider are forwarded; the rest are ignored. Unrecognized keys are silently dropped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::OpenRouter.ImageGenerationProviderPreferencesOptions? Options { get; set; }

        /// <summary>
        /// An ordered list of provider slugs. The router will attempt to use the first provider in the subset of this list that supports your requested model, and fall back to the next if it is unavailable. If no providers are available, the request will fail with an error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ImageGenerationProviderPreferencesOrderItems>? Order { get; set; }

        /// <summary>
        /// The sorting strategy to use for this request, if "order" is not specified. When set, no load balancing is performed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ImageGenerationProviderPreferencesSort?, object>))]
        public global::OpenRouter.OneOf<global::OpenRouter.ImageGenerationProviderPreferencesSort?, object>? Sort { get; set; }

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
        /// <param name="ignore">
        /// List of provider slugs to ignore. If provided, this list is merged with your account-wide ignored provider settings for this request.
        /// </param>
        /// <param name="only">
        /// List of provider slugs to allow. If provided, this list is merged with your account-wide allowed provider settings for this request.
        /// </param>
        /// <param name="options">
        /// Provider-specific options keyed by provider slug. Only options for the matched provider are forwarded; the rest are ignored. Unrecognized keys are silently dropped.
        /// </param>
        /// <param name="order">
        /// An ordered list of provider slugs. The router will attempt to use the first provider in the subset of this list that supports your requested model, and fall back to the next if it is unavailable. If no providers are available, the request will fail with an error message.
        /// </param>
        /// <param name="sort">
        /// The sorting strategy to use for this request, if "order" is not specified. When set, no load balancing is performed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationProviderPreferences(
            bool? allowFallbacks,
            global::System.Collections.Generic.IList<global::OpenRouter.ImageGenerationProviderPreferencesIgnoreItems>? ignore,
            global::System.Collections.Generic.IList<global::OpenRouter.ImageGenerationProviderPreferencesOnlyItems>? only,
            global::OpenRouter.ImageGenerationProviderPreferencesOptions? options,
            global::System.Collections.Generic.IList<global::OpenRouter.ImageGenerationProviderPreferencesOrderItems>? order,
            global::OpenRouter.OneOf<global::OpenRouter.ImageGenerationProviderPreferencesSort?, object>? sort)
        {
            this.AllowFallbacks = allowFallbacks;
            this.Ignore = ignore;
            this.Only = only;
            this.Options = options;
            this.Order = order;
            this.Sort = sort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationProviderPreferences" /> class.
        /// </summary>
        public ImageGenerationProviderPreferences()
        {
        }

    }
}