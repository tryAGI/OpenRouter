
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: grafana
    /// </summary>
    public enum GetObservabilityDestinationResponseDataVariant5Type
    {
        /// <summary>
        /// grafana
        /// </summary>
        Grafana,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetObservabilityDestinationResponseDataVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetObservabilityDestinationResponseDataVariant5Type value)
        {
            return value switch
            {
                GetObservabilityDestinationResponseDataVariant5Type.Grafana => "grafana",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetObservabilityDestinationResponseDataVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "grafana" => GetObservabilityDestinationResponseDataVariant5Type.Grafana,
                _ => null,
            };
        }
    }
}