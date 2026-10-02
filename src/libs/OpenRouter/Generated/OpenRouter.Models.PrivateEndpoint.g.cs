
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"base_url":"https://contoso.openai.azure.com","declared_region":"us","declared_zdr":true,"id":"5b1c4c4e-7d0a-4a8e-9f3a-2d6c1b0e8a11","model_name":"OpenAI: GPT-4o","model_permaslug":"openai/gpt-4o-2024-08-06","model_slug":"openai/gpt-4o","pricing":{"completion":"0.00001","prompt":"0.0000025"},"provider_name":"Azure","provider_slug":"azure","status":"active","upstream_model_id":"gpt-4o-prod"}
    /// </summary>
    public sealed partial class PrivateEndpoint
    {
        /// <summary>
        /// HTTPS base URL of your deployment, or `null` for providers whose URL is derived from the BYOK credential (Azure, Amazon Bedrock, Google Vertex).<br/>
        /// Example: https://contoso.openai.azure.com
        /// </summary>
        /// <example>https://contoso.openai.azure.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// Where you attest this deployment processes data. `global` means not regional; `null` means undeclared.<br/>
        /// Example: us
        /// </summary>
        /// <example>us</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("declared_region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.PrivateEndpointDeclaredRegionJsonConverter))]
        public global::OpenRouter.PrivateEndpointDeclaredRegion? DeclaredRegion { get; set; }

        /// <summary>
        /// Whether you attest this deployment retains no prompt or completion data. `null` means undeclared.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("declared_zdr")]
        public bool? DeclaredZdr { get; set; }

        /// <summary>
        /// Stable identifier of the private endpoint.<br/>
        /// Example: 5b1c4c4e-7d0a-4a8e-9f3a-2d6c1b0e8a11
        /// </summary>
        /// <example>5b1c4c4e-7d0a-4a8e-9f3a-2d6c1b0e8a11</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Display name of the model, or `null` when the model is no longer listed.<br/>
        /// Example: OpenAI: GPT-4o
        /// </summary>
        /// <example>OpenAI: GPT-4o</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        public string? ModelName { get; set; }

        /// <summary>
        /// Permanent slug of the model this endpoint serves.<br/>
        /// Example: openai/gpt-4o-2024-08-06
        /// </summary>
        /// <example>openai/gpt-4o-2024-08-06</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_permaslug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelPermaslug { get; set; }

        /// <summary>
        /// Public model slug, or `null` when the model is no longer listed.<br/>
        /// Example: openai/gpt-4o
        /// </summary>
        /// <example>openai/gpt-4o</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_slug")]
        public string? ModelSlug { get; set; }

        /// <summary>
        /// Negotiated per-token rates reported for requests routed to this endpoint.<br/>
        /// Example: {"completion":"0.00001","prompt":"0.0000025"}
        /// </summary>
        /// <example>{"completion":"0.00001","prompt":"0.0000025"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.PrivateEndpointPricing Pricing { get; set; }

        /// <summary>
        /// Display name of the upstream provider.<br/>
        /// Example: Azure
        /// </summary>
        /// <example>Azure</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderName { get; set; }

        /// <summary>
        /// Slug of the upstream provider, or `null` when the provider is no longer listed.<br/>
        /// Example: azure
        /// </summary>
        /// <example>azure</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_slug")]
        public string? ProviderSlug { get; set; }

        /// <summary>
        /// Lifecycle state. `draft` endpoints are not routable until validated and activated; `disabled` endpoints are activated but temporarily not routable.<br/>
        /// Example: active
        /// </summary>
        /// <example>active</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.PrivateEndpointStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.PrivateEndpointStatus Status { get; set; }

        /// <summary>
        /// Model or deployment identifier sent to the upstream provider.<br/>
        /// Example: gpt-4o-prod
        /// </summary>
        /// <example>gpt-4o-prod</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstream_model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpstreamModelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateEndpoint" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable identifier of the private endpoint.<br/>
        /// Example: 5b1c4c4e-7d0a-4a8e-9f3a-2d6c1b0e8a11
        /// </param>
        /// <param name="modelPermaslug">
        /// Permanent slug of the model this endpoint serves.<br/>
        /// Example: openai/gpt-4o-2024-08-06
        /// </param>
        /// <param name="pricing">
        /// Negotiated per-token rates reported for requests routed to this endpoint.<br/>
        /// Example: {"completion":"0.00001","prompt":"0.0000025"}
        /// </param>
        /// <param name="providerName">
        /// Display name of the upstream provider.<br/>
        /// Example: Azure
        /// </param>
        /// <param name="status">
        /// Lifecycle state. `draft` endpoints are not routable until validated and activated; `disabled` endpoints are activated but temporarily not routable.<br/>
        /// Example: active
        /// </param>
        /// <param name="upstreamModelId">
        /// Model or deployment identifier sent to the upstream provider.<br/>
        /// Example: gpt-4o-prod
        /// </param>
        /// <param name="baseUrl">
        /// HTTPS base URL of your deployment, or `null` for providers whose URL is derived from the BYOK credential (Azure, Amazon Bedrock, Google Vertex).<br/>
        /// Example: https://contoso.openai.azure.com
        /// </param>
        /// <param name="declaredRegion">
        /// Where you attest this deployment processes data. `global` means not regional; `null` means undeclared.<br/>
        /// Example: us
        /// </param>
        /// <param name="declaredZdr">
        /// Whether you attest this deployment retains no prompt or completion data. `null` means undeclared.<br/>
        /// Example: true
        /// </param>
        /// <param name="modelName">
        /// Display name of the model, or `null` when the model is no longer listed.<br/>
        /// Example: OpenAI: GPT-4o
        /// </param>
        /// <param name="modelSlug">
        /// Public model slug, or `null` when the model is no longer listed.<br/>
        /// Example: openai/gpt-4o
        /// </param>
        /// <param name="providerSlug">
        /// Slug of the upstream provider, or `null` when the provider is no longer listed.<br/>
        /// Example: azure
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateEndpoint(
            global::System.Guid id,
            string modelPermaslug,
            global::OpenRouter.PrivateEndpointPricing pricing,
            string providerName,
            global::OpenRouter.PrivateEndpointStatus status,
            string upstreamModelId,
            string? baseUrl,
            global::OpenRouter.PrivateEndpointDeclaredRegion? declaredRegion,
            bool? declaredZdr,
            string? modelName,
            string? modelSlug,
            string? providerSlug)
        {
            this.BaseUrl = baseUrl;
            this.DeclaredRegion = declaredRegion;
            this.DeclaredZdr = declaredZdr;
            this.Id = id;
            this.ModelName = modelName;
            this.ModelPermaslug = modelPermaslug ?? throw new global::System.ArgumentNullException(nameof(modelPermaslug));
            this.ModelSlug = modelSlug;
            this.Pricing = pricing ?? throw new global::System.ArgumentNullException(nameof(pricing));
            this.ProviderName = providerName ?? throw new global::System.ArgumentNullException(nameof(providerName));
            this.ProviderSlug = providerSlug;
            this.Status = status;
            this.UpstreamModelId = upstreamModelId ?? throw new global::System.ArgumentNullException(nameof(upstreamModelId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateEndpoint" /> class.
        /// </summary>
        public PrivateEndpoint()
        {
        }

    }
}