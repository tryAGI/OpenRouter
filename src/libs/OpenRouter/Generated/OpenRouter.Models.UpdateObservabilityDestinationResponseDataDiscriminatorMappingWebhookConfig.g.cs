
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateObservabilityDestinationResponseDataDiscriminatorMappingWebhookConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Default Value: POST
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UpdateObservabilityDestinationResponseDataDiscriminatorMappingWebhookConfigMethodJsonConverter))]
        public global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingWebhookConfigMethod? Method { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObservabilityDestinationResponseDataDiscriminatorMappingWebhookConfig" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="headers"></param>
        /// <param name="method">
        /// Default Value: POST
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateObservabilityDestinationResponseDataDiscriminatorMappingWebhookConfig(
            string url,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::OpenRouter.UpdateObservabilityDestinationResponseDataDiscriminatorMappingWebhookConfigMethod? method)
        {
            this.Headers = headers;
            this.Method = method;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObservabilityDestinationResponseDataDiscriminatorMappingWebhookConfig" /> class.
        /// </summary>
        public UpdateObservabilityDestinationResponseDataDiscriminatorMappingWebhookConfig()
        {
        }

    }
}