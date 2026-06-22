
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An endpoint that serves a given image model.
    /// </summary>
    public sealed partial class ImageEndpoint
    {
        /// <summary>
        /// Provider-specific options accepted under provider.options[provider_slug].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_passthrough_parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AllowedPassthroughParameters { get; set; }

        /// <summary>
        /// Billable pricing lines for this endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ImagePricingEntry> Pricing { get; set; }

        /// <summary>
        /// Provider display name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderName { get; set; }

        /// <summary>
        /// Provider slug
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderSlug { get; set; }

        /// <summary>
        /// Provider tag for request-side selection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_tag")]
        public string? ProviderTag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object SupportedParameters { get; set; }

        /// <summary>
        /// Whether this endpoint supports native SSE streaming (`stream: true` in the request).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_streaming")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SupportsStreaming { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageEndpoint" /> class.
        /// </summary>
        /// <param name="allowedPassthroughParameters">
        /// Provider-specific options accepted under provider.options[provider_slug].
        /// </param>
        /// <param name="pricing">
        /// Billable pricing lines for this endpoint.
        /// </param>
        /// <param name="providerName">
        /// Provider display name
        /// </param>
        /// <param name="providerSlug">
        /// Provider slug
        /// </param>
        /// <param name="supportedParameters"></param>
        /// <param name="supportsStreaming">
        /// Whether this endpoint supports native SSE streaming (`stream: true` in the request).
        /// </param>
        /// <param name="providerTag">
        /// Provider tag for request-side selection
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageEndpoint(
            global::System.Collections.Generic.IList<string> allowedPassthroughParameters,
            global::System.Collections.Generic.IList<global::OpenRouter.ImagePricingEntry> pricing,
            string providerName,
            string providerSlug,
            object supportedParameters,
            bool supportsStreaming,
            string? providerTag)
        {
            this.AllowedPassthroughParameters = allowedPassthroughParameters ?? throw new global::System.ArgumentNullException(nameof(allowedPassthroughParameters));
            this.Pricing = pricing ?? throw new global::System.ArgumentNullException(nameof(pricing));
            this.ProviderName = providerName ?? throw new global::System.ArgumentNullException(nameof(providerName));
            this.ProviderSlug = providerSlug ?? throw new global::System.ArgumentNullException(nameof(providerSlug));
            this.ProviderTag = providerTag;
            this.SupportedParameters = supportedParameters ?? throw new global::System.ArgumentNullException(nameof(supportedParameters));
            this.SupportsStreaming = supportsStreaming;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageEndpoint" /> class.
        /// </summary>
        public ImageEndpoint()
        {
        }

    }
}