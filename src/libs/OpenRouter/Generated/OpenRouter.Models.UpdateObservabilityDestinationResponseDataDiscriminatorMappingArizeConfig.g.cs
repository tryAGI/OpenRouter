
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateObservabilityDestinationResponseDataDiscriminatorMappingArizeConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

        /// <summary>
        /// Default Value: https://otlp.arize.com
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseUrl")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// Custom HTTP headers to include in requests to this destination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// The name of the tracing project in Arize AX
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spaceKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpaceKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObservabilityDestinationResponseDataDiscriminatorMappingArizeConfig" /> class.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="modelId">
        /// The name of the tracing project in Arize AX
        /// </param>
        /// <param name="spaceKey"></param>
        /// <param name="baseUrl">
        /// Default Value: https://otlp.arize.com
        /// </param>
        /// <param name="headers">
        /// Custom HTTP headers to include in requests to this destination.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateObservabilityDestinationResponseDataDiscriminatorMappingArizeConfig(
            string apiKey,
            string modelId,
            string spaceKey,
            string? baseUrl,
            global::System.Collections.Generic.Dictionary<string, string>? headers)
        {
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.BaseUrl = baseUrl;
            this.Headers = headers;
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.SpaceKey = spaceKey ?? throw new global::System.ArgumentNullException(nameof(spaceKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObservabilityDestinationResponseDataDiscriminatorMappingArizeConfig" /> class.
        /// </summary>
        public UpdateObservabilityDestinationResponseDataDiscriminatorMappingArizeConfig()
        {
        }

    }
}