
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PrivateEndpointResponse
    {
        /// <summary>
        /// Example: {"base_url":"https://contoso.openai.azure.com","declared_region":"us","declared_zdr":true,"id":"5b1c4c4e-7d0a-4a8e-9f3a-2d6c1b0e8a11","model_name":"OpenAI: GPT-4o","model_permaslug":"openai/gpt-4o-2024-08-06","model_slug":"openai/gpt-4o","pricing":{"completion":"0.00001","prompt":"0.0000025"},"provider_name":"Azure","provider_slug":"azure","status":"active","upstream_model_id":"gpt-4o-prod"}
        /// </summary>
        /// <example>{"base_url":"https://contoso.openai.azure.com","declared_region":"us","declared_zdr":true,"id":"5b1c4c4e-7d0a-4a8e-9f3a-2d6c1b0e8a11","model_name":"OpenAI: GPT-4o","model_permaslug":"openai/gpt-4o-2024-08-06","model_slug":"openai/gpt-4o","pricing":{"completion":"0.00001","prompt":"0.0000025"},"provider_name":"Azure","provider_slug":"azure","status":"active","upstream_model_id":"gpt-4o-prod"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.PrivateEndpoint Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateEndpointResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Example: {"base_url":"https://contoso.openai.azure.com","declared_region":"us","declared_zdr":true,"id":"5b1c4c4e-7d0a-4a8e-9f3a-2d6c1b0e8a11","model_name":"OpenAI: GPT-4o","model_permaslug":"openai/gpt-4o-2024-08-06","model_slug":"openai/gpt-4o","pricing":{"completion":"0.00001","prompt":"0.0000025"},"provider_name":"Azure","provider_slug":"azure","status":"active","upstream_model_id":"gpt-4o-prod"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PrivateEndpointResponse(
            global::OpenRouter.PrivateEndpoint data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivateEndpointResponse" /> class.
        /// </summary>
        public PrivateEndpointResponse()
        {
        }

    }
}