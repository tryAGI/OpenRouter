
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// How this metric value should be formatted for display (e.g. percent → multiply by 100 and append %, currency → prefix with $)
    /// </summary>
    public enum AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItemsDisplayFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Currency,
        /// <summary>
        /// 
        /// </summary>
        Latency,
        /// <summary>
        /// 
        /// </summary>
        Number,
        /// <summary>
        /// 
        /// </summary>
        Percent,
        /// <summary>
        /// 
        /// </summary>
        Throughput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItemsDisplayFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItemsDisplayFormat value)
        {
            return value switch
            {
                AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItemsDisplayFormat.Currency => "currency",
                AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItemsDisplayFormat.Latency => "latency",
                AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItemsDisplayFormat.Number => "number",
                AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItemsDisplayFormat.Percent => "percent",
                AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItemsDisplayFormat.Throughput => "throughput",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItemsDisplayFormat? ToEnum(string value)
        {
            return value switch
            {
                "currency" => AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItemsDisplayFormat.Currency,
                "latency" => AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItemsDisplayFormat.Latency,
                "number" => AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItemsDisplayFormat.Number,
                "percent" => AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItemsDisplayFormat.Percent,
                "throughput" => AnalyticsMetaGetResponsesContentApplicationJsonSchemaDataMetricsItemsDisplayFormat.Throughput,
                _ => null,
            };
        }
    }
}