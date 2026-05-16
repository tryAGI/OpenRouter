
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ObservabilityOtelCollectorDestinationType
    {
        /// <summary>
        /// 
        /// </summary>
        OtelCollector,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityOtelCollectorDestinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityOtelCollectorDestinationType value)
        {
            return value switch
            {
                ObservabilityOtelCollectorDestinationType.OtelCollector => "otel-collector",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityOtelCollectorDestinationType? ToEnum(string value)
        {
            return value switch
            {
                "otel-collector" => ObservabilityOtelCollectorDestinationType.OtelCollector,
                _ => null,
            };
        }
    }
}