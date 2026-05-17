
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: grafana
    /// </summary>
    public enum CreateObservabilityDestinationResponseDataVariant5Type
    {
        /// <summary>
        /// grafana
        /// </summary>
        Grafana,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateObservabilityDestinationResponseDataVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateObservabilityDestinationResponseDataVariant5Type value)
        {
            return value switch
            {
                CreateObservabilityDestinationResponseDataVariant5Type.Grafana => "grafana",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateObservabilityDestinationResponseDataVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "grafana" => CreateObservabilityDestinationResponseDataVariant5Type.Grafana,
                _ => null,
            };
        }
    }
}