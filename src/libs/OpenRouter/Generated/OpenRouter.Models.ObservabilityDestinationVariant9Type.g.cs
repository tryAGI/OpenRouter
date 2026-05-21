
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: opik
    /// </summary>
    public enum ObservabilityDestinationVariant9Type
    {
        /// <summary>
        /// opik
        /// </summary>
        Opik,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityDestinationVariant9TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityDestinationVariant9Type value)
        {
            return value switch
            {
                ObservabilityDestinationVariant9Type.Opik => "opik",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityDestinationVariant9Type? ToEnum(string value)
        {
            return value switch
            {
                "opik" => ObservabilityDestinationVariant9Type.Opik,
                _ => null,
            };
        }
    }
}