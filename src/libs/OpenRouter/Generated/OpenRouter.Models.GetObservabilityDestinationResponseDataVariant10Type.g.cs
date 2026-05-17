
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: otel-collector
    /// </summary>
    public enum GetObservabilityDestinationResponseDataVariant10Type
    {
        /// <summary>
        /// otel-collector
        /// </summary>
        OtelCollector,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetObservabilityDestinationResponseDataVariant10TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetObservabilityDestinationResponseDataVariant10Type value)
        {
            return value switch
            {
                GetObservabilityDestinationResponseDataVariant10Type.OtelCollector => "otel-collector",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetObservabilityDestinationResponseDataVariant10Type? ToEnum(string value)
        {
            return value switch
            {
                "otel-collector" => GetObservabilityDestinationResponseDataVariant10Type.OtelCollector,
                _ => null,
            };
        }
    }
}