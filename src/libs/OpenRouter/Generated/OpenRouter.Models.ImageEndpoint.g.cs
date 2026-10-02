
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An endpoint that serves a given image model.<br/>
    /// Example: {"allowed_passthrough_parameters":[],"pricing":[{"billable":"output_image","cost_usd":0.05,"unit":"image"}],"provider_name":"Bytedance","provider_slug":"bytedance","provider_tag":"bytedance","supported_parameters":{"resolution":{"type":"enum","values":["1K","2K","4K"]},"seed":{"type":"boolean"}},"supports_streaming":false}
    /// </summary>
    public sealed partial class ImageEndpoint
    {
        /// <summary>
        /// Provider-specific options accepted under provider.options[provider_slug].<br/>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_passthrough_parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AllowedPassthroughParameters { get; set; }

        /// <summary>
        /// Billable pricing lines for this endpoint.<br/>
        /// Example: [{"billable":"output_image","cost_usd":0.05,"unit":"image"}]
        /// </summary>
        /// <example>[{"billable":"output_image","cost_usd":0.05,"unit":"image"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ImagePricingEntry> Pricing { get; set; }

        /// <summary>
        /// Provider display name<br/>
        /// Example: Bytedance
        /// </summary>
        /// <example>Bytedance</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderName { get; set; }

        /// <summary>
        /// Provider slug<br/>
        /// Example: bytedance
        /// </summary>
        /// <example>bytedance</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderSlug { get; set; }

        /// <summary>
        /// Provider tag for request-side selection<br/>
        /// Example: bytedance
        /// </summary>
        /// <example>bytedance</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_tag")]
        public string? ProviderTag { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_parameters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AllOfJsonConverter<global::System.Collections.Generic.Dictionary<string, global::OpenRouter.CapabilityDescriptor>, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AllOf<global::System.Collections.Generic.Dictionary<string, global::OpenRouter.CapabilityDescriptor>, object> SupportedParameters { get; set; }

        /// <summary>
        /// Whether this endpoint supports native SSE streaming (`stream: true` in the request).<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
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
        /// Provider-specific options accepted under provider.options[provider_slug].<br/>
        /// Example: []
        /// </param>
        /// <param name="pricing">
        /// Billable pricing lines for this endpoint.<br/>
        /// Example: [{"billable":"output_image","cost_usd":0.05,"unit":"image"}]
        /// </param>
        /// <param name="providerName">
        /// Provider display name<br/>
        /// Example: Bytedance
        /// </param>
        /// <param name="providerSlug">
        /// Provider slug<br/>
        /// Example: bytedance
        /// </param>
        /// <param name="supportedParameters"></param>
        /// <param name="supportsStreaming">
        /// Whether this endpoint supports native SSE streaming (`stream: true` in the request).<br/>
        /// Example: false
        /// </param>
        /// <param name="providerTag">
        /// Provider tag for request-side selection<br/>
        /// Example: bytedance
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageEndpoint(
            global::System.Collections.Generic.IList<string> allowedPassthroughParameters,
            global::System.Collections.Generic.IList<global::OpenRouter.ImagePricingEntry> pricing,
            string providerName,
            string providerSlug,
            global::OpenRouter.AllOf<global::System.Collections.Generic.Dictionary<string, global::OpenRouter.CapabilityDescriptor>, object> supportedParameters,
            bool supportsStreaming,
            string? providerTag)
        {
            this.AllowedPassthroughParameters = allowedPassthroughParameters ?? throw new global::System.ArgumentNullException(nameof(allowedPassthroughParameters));
            this.Pricing = pricing ?? throw new global::System.ArgumentNullException(nameof(pricing));
            this.ProviderName = providerName ?? throw new global::System.ArgumentNullException(nameof(providerName));
            this.ProviderSlug = providerSlug ?? throw new global::System.ArgumentNullException(nameof(providerSlug));
            this.ProviderTag = providerTag;
            this.SupportedParameters = supportedParameters;
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