
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Throughput percentiles in tokens per second. Only meaningful for text generation; null for workloads without token throughput.
    /// </summary>
    public sealed partial class PublicEndpointPerfLast30mByWorkloadEmbeddingsThroughput
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}