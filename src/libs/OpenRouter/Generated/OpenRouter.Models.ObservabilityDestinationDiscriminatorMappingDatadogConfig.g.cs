
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ObservabilityDestinationDiscriminatorMappingDatadogConfig
    {
        /// <summary>
        /// Datadog API key must have LLM Observability permissions. Create at: 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

        /// <summary>
        /// Custom HTTP headers to include in requests to this destination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Name to identify your application in Datadog LLM Observability
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mlApp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MlApp { get; set; }

        /// <summary>
        /// Datadog API URL for your region (e.g., https://api.datadoghq.com, https://api.us3.datadoghq.com, https://api.datadoghq.eu)<br/>
        /// Default Value: https://api.us5.datadoghq.com
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservabilityDestinationDiscriminatorMappingDatadogConfig" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// Datadog API key must have LLM Observability permissions. Create at: 
        /// </param>
        /// <param name="mlApp">
        /// Name to identify your application in Datadog LLM Observability
        /// </param>
        /// <param name="headers">
        /// Custom HTTP headers to include in requests to this destination.
        /// </param>
        /// <param name="url">
        /// Datadog API URL for your region (e.g., https://api.datadoghq.com, https://api.us3.datadoghq.com, https://api.datadoghq.eu)<br/>
        /// Default Value: https://api.us5.datadoghq.com
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ObservabilityDestinationDiscriminatorMappingDatadogConfig(
            string apiKey,
            string mlApp,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            string? url)
        {
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.Headers = headers;
            this.MlApp = mlApp ?? throw new global::System.ArgumentNullException(nameof(mlApp));
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservabilityDestinationDiscriminatorMappingDatadogConfig" /> class.
        /// </summary>
        public ObservabilityDestinationDiscriminatorMappingDatadogConfig()
        {
        }

    }
}