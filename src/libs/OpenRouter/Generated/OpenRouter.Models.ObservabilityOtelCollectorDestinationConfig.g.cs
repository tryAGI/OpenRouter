
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ObservabilityOtelCollectorDestinationConfig
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Endpoint { get; set; }

        /// <summary>
        /// Custom HTTP headers as a JSON object. For Axiom, use {"Authorization": "Bearer xaat-xxx", "X-Axiom-Dataset": "your-dataset"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// OTLP/HTTP metrics URL. Required when `shouldSendMetrics` (Send OTLP metrics) is true; ignored otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metricsEndpoint")]
        public string? MetricsEndpoint { get; set; }

        /// <summary>
        /// Also send OTLP metrics for each delivered generation to the metrics endpoint, with the same headers.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shouldSendMetrics")]
        public bool? ShouldSendMetrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservabilityOtelCollectorDestinationConfig" /> class.
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="headers">
        /// Custom HTTP headers as a JSON object. For Axiom, use {"Authorization": "Bearer xaat-xxx", "X-Axiom-Dataset": "your-dataset"}
        /// </param>
        /// <param name="metricsEndpoint">
        /// OTLP/HTTP metrics URL. Required when `shouldSendMetrics` (Send OTLP metrics) is true; ignored otherwise.
        /// </param>
        /// <param name="shouldSendMetrics">
        /// Also send OTLP metrics for each delivered generation to the metrics endpoint, with the same headers.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ObservabilityOtelCollectorDestinationConfig(
            string endpoint,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            string? metricsEndpoint,
            bool? shouldSendMetrics)
        {
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.Headers = headers;
            this.MetricsEndpoint = metricsEndpoint;
            this.ShouldSendMetrics = shouldSendMetrics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservabilityOtelCollectorDestinationConfig" /> class.
        /// </summary>
        public ObservabilityOtelCollectorDestinationConfig()
        {
        }

    }
}