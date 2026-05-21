
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateObservabilityDestinationResponseDataDiscriminatorMappingRampConfig
    {
        /// <summary>
        /// Generate this in your Ramp integration settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

        /// <summary>
        /// Default Value: https://api.ramp.com/developer/v1/ai-usage/openrouter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseUrl")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// Custom HTTP headers to include in requests to Ramp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObservabilityDestinationResponseDataDiscriminatorMappingRampConfig" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// Generate this in your Ramp integration settings.
        /// </param>
        /// <param name="baseUrl">
        /// Default Value: https://api.ramp.com/developer/v1/ai-usage/openrouter
        /// </param>
        /// <param name="headers">
        /// Custom HTTP headers to include in requests to Ramp.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateObservabilityDestinationResponseDataDiscriminatorMappingRampConfig(
            string apiKey,
            string? baseUrl,
            global::System.Collections.Generic.Dictionary<string, string>? headers)
        {
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.BaseUrl = baseUrl;
            this.Headers = headers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObservabilityDestinationResponseDataDiscriminatorMappingRampConfig" /> class.
        /// </summary>
        public UpdateObservabilityDestinationResponseDataDiscriminatorMappingRampConfig()
        {
        }

    }
}