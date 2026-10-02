
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicEndpointPerfLast30mByWorkloadTextGeneration
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AllOfJsonConverter<global::OpenRouter.PercentileStats, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AllOf<global::OpenRouter.PercentileStats, object> Latency { get; set; }

        /// <summary>
        /// Total requests admitted for this workload in the window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_count")]
        public int? RequestCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("throughput")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AllOfJsonConverter<global::OpenRouter.PercentileStats, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AllOf<global::OpenRouter.PercentileStats, object> Throughput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicEndpointPerfLast30mByWorkloadTextGeneration" /> class.
        /// </summary>
        /// <param name="latency"></param>
        /// <param name="throughput"></param>
        /// <param name="requestCount">
        /// Total requests admitted for this workload in the window.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicEndpointPerfLast30mByWorkloadTextGeneration(
            global::OpenRouter.AllOf<global::OpenRouter.PercentileStats, object> latency,
            global::OpenRouter.AllOf<global::OpenRouter.PercentileStats, object> throughput,
            int? requestCount)
        {
            this.Latency = latency;
            this.RequestCount = requestCount;
            this.Throughput = throughput;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicEndpointPerfLast30mByWorkloadTextGeneration" /> class.
        /// </summary>
        public PublicEndpointPerfLast30mByWorkloadTextGeneration()
        {
        }

    }
}