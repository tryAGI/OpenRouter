
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Latency percentiles in milliseconds over the last 30 minutes. Latency measures time to first token. Only visible when authenticated with an API key or cookie; returns null for unauthenticated requests.<br/>
    /// Example: {"p50":25.5,"p75":35.2,"p90":48.7,"p99":85.3}
    /// </summary>
    public sealed partial class PercentileStats
    {
        /// <summary>
        /// Median (50th percentile)<br/>
        /// Example: 25.5F
        /// </summary>
        /// <example>25.5F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("p50")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double P50 { get; set; }

        /// <summary>
        /// 75th percentile<br/>
        /// Example: 35.2F
        /// </summary>
        /// <example>35.2F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("p75")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double P75 { get; set; }

        /// <summary>
        /// 90th percentile<br/>
        /// Example: 48.7F
        /// </summary>
        /// <example>48.7F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("p90")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double P90 { get; set; }

        /// <summary>
        /// 99th percentile<br/>
        /// Example: 85.3F
        /// </summary>
        /// <example>85.3F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("p99")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double P99 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PercentileStats" /> class.
        /// </summary>
        /// <param name="p50">
        /// Median (50th percentile)<br/>
        /// Example: 25.5F
        /// </param>
        /// <param name="p75">
        /// 75th percentile<br/>
        /// Example: 35.2F
        /// </param>
        /// <param name="p90">
        /// 90th percentile<br/>
        /// Example: 48.7F
        /// </param>
        /// <param name="p99">
        /// 99th percentile<br/>
        /// Example: 85.3F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PercentileStats(
            double p50,
            double p75,
            double p90,
            double p99)
        {
            this.P50 = p50;
            this.P75 = p75;
            this.P90 = p90;
            this.P99 = p99;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PercentileStats" /> class.
        /// </summary>
        public PercentileStats()
        {
        }

    }
}