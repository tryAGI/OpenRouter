
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Throughput percentiles in tokens per second over the last 30 minutes. Throughput measures output token generation speed. Only visible when authenticated with an API key or cookie; returns null for unauthenticated requests.
    /// </summary>
    public sealed partial class PublicEndpointThroughputLast30m
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}