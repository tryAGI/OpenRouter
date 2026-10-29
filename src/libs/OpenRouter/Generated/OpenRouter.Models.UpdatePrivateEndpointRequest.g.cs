
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Only the fields present change. `base_url`, `upstream_model_id`, `declared_zdr` and `declared_region` are accepted on a draft only; `pricing` and `declared_parameters` replace their value; `settings` is itself a partial update where `null` clears a limit or restores the provider default.<br/>
    /// Example: {"declared_parameters":["seed"],"settings":{"context_length":128000}}
    /// </summary>
    public sealed partial class UpdatePrivateEndpointRequest
    {
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UpdatePrivateEndpointRequestDeclaredRegionJsonConverter))]
        public global::OpenRouter.UpdatePrivateEndpointRequestDeclaredRegion? DeclaredRegion { get; set; }

        /// <summary>
        /// Attest that this deployment retains no prompt or completion data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("declared_zdr")]
        public bool? DeclaredZdr { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AllOfJsonConverter<global::OpenRouter.PrivateEndpointPricing, object>))]
        public global::OpenRouter.AllOf<global::OpenRouter.PrivateEndpointPricing, object>? Pricing { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AllOfJsonConverter<global::OpenRouter.UpdatePrivateEndpointSettingsRequest, object>))]
        public global::OpenRouter.AllOf<global::OpenRouter.UpdatePrivateEndpointSettingsRequest, object>? Settings { get; set; }

        /// <summary>
        /// Model or deployment identifier sent to the upstream provider.<br/>
        /// Example: gpt-4o-prod
        /// </summary>
        /// <example>gpt-4o-prod</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("upstream_model_id")]
        public string? UpstreamModelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePrivateEndpointRequest" /> class.
        /// </summary>
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
        /// <param name="pricing"></param>
        /// <param name="settings"></param>
        /// <param name="upstreamModelId">
        /// Model or deployment identifier sent to the upstream provider.<br/>
        /// Example: gpt-4o-prod
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePrivateEndpointRequest(
            string? baseUrl,
            global::System.Collections.Generic.IList<global::OpenRouter.PrivateEndpointDeclaredParameter>? declaredParameters,
            global::OpenRouter.UpdatePrivateEndpointRequestDeclaredRegion? declaredRegion,
            bool? declaredZdr,
            global::OpenRouter.AllOf<global::OpenRouter.PrivateEndpointPricing, object>? pricing,
            global::OpenRouter.AllOf<global::OpenRouter.UpdatePrivateEndpointSettingsRequest, object>? settings,
            string? upstreamModelId)
        {
            this.BaseUrl = baseUrl;
            this.DeclaredParameters = declaredParameters;
            this.DeclaredRegion = declaredRegion;
            this.DeclaredZdr = declaredZdr;
            this.Pricing = pricing;
            this.Settings = settings;
            this.UpstreamModelId = upstreamModelId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePrivateEndpointRequest" /> class.
        /// </summary>
        public UpdatePrivateEndpointRequest()
        {
        }

    }
}