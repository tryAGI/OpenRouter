
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
        /// Parameters the upstream supports beyond the tested ones. Replaces the earlier declaration; tested parameters stay. Order and repeated names are ignored, but the list holds at most as many entries as there are declarable parameters, repeats included. `tool_choice` requires `tools` to be tested or declared.<br/>
        /// Example: [temperature, seed]
        /// </summary>
        /// <example>[temperature, seed]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("declared_parameters")]
        public global::System.Collections.Generic.IList<global::OpenRouter.PrivateEndpointDeclaredParameter>? DeclaredParameters { get; set; }

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
        /// Cap on completion tokens per request. Requests asking for more skip this endpoint, and the default output length stays within it. When omitted, the cap is copied from the public endpoint for the same model and provider, if there is one.<br/>
        /// Example: 131072
        /// </summary>
        /// <example>131072</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")]
        public int? MaxCompletionTokens { get; set; }

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
        /// Example: {"cache_read":"0.00000025","cache_write":"0.000003125","completion":"0.00001","prompt":"0.0000025"}
        /// </summary>
        /// <example>{"cache_read":"0.00000025","cache_write":"0.000003125","completion":"0.00001","prompt":"0.0000025"}</example>
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
        /// Capabilities and limits to set over the ones copied from the public endpoint for this model and provider (or from the model). Omitted fields keep the copied values.<br/>
        /// Example: {"context_length":128000,"reasoning":{"supported":true}}
        /// </summary>
        /// <example>{"context_length":128000,"reasoning":{"supported":true}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::OpenRouter.UpdatePrivateEndpointSettingsRequest? Settings { get; set; }

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
        /// <param name="declaredParameters">
        /// Parameters the upstream supports beyond the tested ones. Replaces the earlier declaration; tested parameters stay. Order and repeated names are ignored, but the list holds at most as many entries as there are declarable parameters, repeats included. `tool_choice` requires `tools` to be tested or declared.<br/>
        /// Example: [temperature, seed]
        /// </param>
        /// <param name="declaredRegion">
        /// Attest where this deployment processes data.<br/>
        /// Example: us
        /// </param>
        /// <param name="declaredZdr">
        /// Attest that this deployment retains no prompt or completion data.
        /// </param>
        /// <param name="maxCompletionTokens">
        /// Cap on completion tokens per request. Requests asking for more skip this endpoint, and the default output length stays within it. When omitted, the cap is copied from the public endpoint for the same model and provider, if there is one.<br/>
        /// Example: 131072
        /// </param>
        /// <param name="pricing">
        /// Negotiated per-token rates reported for requests routed to this endpoint.<br/>
        /// Example: {"cache_read":"0.00000025","cache_write":"0.000003125","completion":"0.00001","prompt":"0.0000025"}
        /// </param>
        /// <param name="settings">
        /// Capabilities and limits to set over the ones copied from the public endpoint for this model and provider (or from the model). Omitted fields keep the copied values.<br/>
        /// Example: {"context_length":128000,"reasoning":{"supported":true}}
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
            global::System.Collections.Generic.IList<global::OpenRouter.PrivateEndpointDeclaredParameter>? declaredParameters,
            global::OpenRouter.CreatePrivateEndpointRequestDeclaredRegion? declaredRegion,
            bool? declaredZdr,
            int? maxCompletionTokens,
            global::OpenRouter.PrivateEndpointPricing? pricing,
            global::OpenRouter.UpdatePrivateEndpointSettingsRequest? settings)
        {
            this.Activate = activate;
            this.BaseUrl = baseUrl;
            this.DeclaredParameters = declaredParameters;
            this.DeclaredRegion = declaredRegion;
            this.DeclaredZdr = declaredZdr;
            this.MaxCompletionTokens = maxCompletionTokens;
            this.ModelPermaslug = modelPermaslug ?? throw new global::System.ArgumentNullException(nameof(modelPermaslug));
            this.Pricing = pricing;
            this.ProviderSlug = providerSlug ?? throw new global::System.ArgumentNullException(nameof(providerSlug));
            this.Settings = settings;
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