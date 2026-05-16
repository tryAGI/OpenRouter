
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ObservabilityGrafanaDestinationConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

        /// <summary>
        /// Default Value: https://otlp-gateway-prod-us-west-0.grafana.net
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseUrl")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// Custom HTTP headers to include in requests to this destination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instanceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InstanceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservabilityGrafanaDestinationConfig" /> class.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="instanceId"></param>
        /// <param name="baseUrl">
        /// Default Value: https://otlp-gateway-prod-us-west-0.grafana.net
        /// </param>
        /// <param name="headers">
        /// Custom HTTP headers to include in requests to this destination.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ObservabilityGrafanaDestinationConfig(
            string apiKey,
            string instanceId,
            string? baseUrl,
            global::System.Collections.Generic.Dictionary<string, string>? headers)
        {
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.BaseUrl = baseUrl;
            this.Headers = headers;
            this.InstanceId = instanceId ?? throw new global::System.ArgumentNullException(nameof(instanceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservabilityGrafanaDestinationConfig" /> class.
        /// </summary>
        public ObservabilityGrafanaDestinationConfig()
        {
        }

    }
}