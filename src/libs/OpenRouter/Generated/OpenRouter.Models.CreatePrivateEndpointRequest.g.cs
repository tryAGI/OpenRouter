
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreatePrivateEndpointRequest
    {
        /// <summary>
        /// Validate and activate in the same call. On a failed validation the draft is kept and returned with a 422, so fix it and call `/validate` and `/activate` instead of creating it again.<br/>
        /// Example: {"workspace_id":"550e8400-e29b-41d4-a716-446655440000"}
        /// </summary>
        /// <example>{"workspace_id":"550e8400-e29b-41d4-a716-446655440000"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("activate")]
        public global::OpenRouter.PrivateEndpointActivation? Activate { get; set; }

        /// <summary>
        /// HTTPS base URL of your deployment. Required unless the provider derives its URL from the BYOK credential (Azure, Amazon Bedrock, Google Vertex).<br/>
        /// Example: https://contoso.openai.azure.com
        /// </summary>
        /// <example>https://contoso.openai.azure.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// Attest where this deployment processes data.<br/>
        /// Example: us
        /// </summary>
        /// <example>us</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("declared_region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.CreatePrivateEndpointRequestDeclaredRegionJsonConverter))]
        public global::OpenRouter.CreatePrivateEndpointRequestDeclaredRegion? DeclaredRegion { get; set; }

        /// <summary>
        /// Attest that this deployment retains no prompt or completion data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("declared_zdr")]
        public bool? DeclaredZdr { get; set; }

        /// <summary>
        /// Permanent slug of the model this endpoint serves.<br/>
        /// Example: openai/gpt-4o-2024-08-06
        /// </summary>
        /// <example>openai/gpt-4o-2024-08-06</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_permaslug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelPermaslug { get; set; }

        /// <summary>
        /// Negotiated per-token rates reported for requests routed to this endpoint.<br/>
        /// Example: {"completion":"0.00001","prompt":"0.0000025"}
        /// </summary>
        /// <example>{"completion":"0.00001","prompt":"0.0000025"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        public global::OpenRouter.PrivateEndpointPricing? Pricing { get; set; }

        /// <summary>
        /// Slug of the upstream provider.<br/>
        /// Example: azure
        /// </summary>
        /// <example>azure</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderSlug { get; set; }

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
        /// Initializes a new instance of the <see cref="CreatePrivateEndpointRequest" /> class.
        /// </summary>
        /// <param name="modelPermaslug">
        /// Permanent slug of the model this endpoint serves.<br/>
        /// Example: openai/gpt-4o-2024-08-06
        /// </param>
        /// <param name="providerSlug">
        /// Slug of the upstream provider.<br/>
        /// Example: azure
        /// </param>
        /// <param name="upstreamModelId">
        /// Model or deployment identifier sent to the upstream provider.<br/>
        /// Example: gpt-4o-prod
        /// </param>
        /// <param name="activate">
        /// Validate and activate in the same call. On a failed validation the draft is kept and returned with a 422, so fix it and call `/validate` and `/activate` instead of creating it again.<br/>
        /// Example: {"workspace_id":"550e8400-e29b-41d4-a716-446655440000"}
        /// </param>
        /// <param name="baseUrl">
        /// HTTPS base URL of your deployment. Required unless the provider derives its URL from the BYOK credential (Azure, Amazon Bedrock, Google Vertex).<br/>
        /// Example: https://contoso.openai.azure.com
        /// </param>
        /// <param name="declaredRegion">
        /// Attest where this deployment processes data.<br/>
        /// Example: us
        /// </param>
        /// <param name="declaredZdr">
        /// Attest that this deployment retains no prompt or completion data.
        /// </param>
        /// <param name="pricing">
        /// Negotiated per-token rates reported for requests routed to this endpoint.<br/>
        /// Example: {"completion":"0.00001","prompt":"0.0000025"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePrivateEndpointRequest(
            string modelPermaslug,
            string providerSlug,
            string upstreamModelId,
            global::OpenRouter.PrivateEndpointActivation? activate,
            string? baseUrl,
            global::OpenRouter.CreatePrivateEndpointRequestDeclaredRegion? declaredRegion,
            bool? declaredZdr,
            global::OpenRouter.PrivateEndpointPricing? pricing)
        {
            this.Activate = activate;
            this.BaseUrl = baseUrl;
            this.DeclaredRegion = declaredRegion;
            this.DeclaredZdr = declaredZdr;
            this.ModelPermaslug = modelPermaslug ?? throw new global::System.ArgumentNullException(nameof(modelPermaslug));
            this.Pricing = pricing;
            this.ProviderSlug = providerSlug ?? throw new global::System.ArgumentNullException(nameof(providerSlug));
            this.UpstreamModelId = upstreamModelId ?? throw new global::System.ArgumentNullException(nameof(upstreamModelId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePrivateEndpointRequest" /> class.
        /// </summary>
        public CreatePrivateEndpointRequest()
        {
        }

    }
}