
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
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
        /// Initializes a new instance of the <see cref="UpdatePrivateEndpointRequest" /> class.
        /// </summary>
        /// <param name="upstreamModelId">
        /// Model or deployment identifier sent to the upstream provider.<br/>
        /// Example: gpt-4o-prod
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePrivateEndpointRequest(
            string upstreamModelId,
            string? baseUrl,
            global::OpenRouter.UpdatePrivateEndpointRequestDeclaredRegion? declaredRegion,
            bool? declaredZdr)
        {
            this.BaseUrl = baseUrl;
            this.DeclaredRegion = declaredRegion;
            this.DeclaredZdr = declaredZdr;
            this.UpstreamModelId = upstreamModelId ?? throw new global::System.ArgumentNullException(nameof(upstreamModelId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePrivateEndpointRequest" /> class.
        /// </summary>
        public UpdatePrivateEndpointRequest()
        {
        }

    }
}