
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: grafana
    /// </summary>
    public enum ObservabilityDestinationVariant5Type
    {
        /// <summary>
        /// grafana
        /// </summary>
        Grafana,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityDestinationVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityDestinationVariant5Type value)
        {
            return value switch
            {
                ObservabilityDestinationVariant5Type.Grafana => "grafana",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityDestinationVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "grafana" => ObservabilityDestinationVariant5Type.Grafana,
                _ => null,
            };
        }
    }
}