
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: opik
    /// </summary>
    public enum GetObservabilityDestinationResponseDataVariant9Type
    {
        /// <summary>
        /// opik
        /// </summary>
        Opik,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetObservabilityDestinationResponseDataVariant9TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetObservabilityDestinationResponseDataVariant9Type value)
        {
            return value switch
            {
                GetObservabilityDestinationResponseDataVariant9Type.Opik => "opik",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetObservabilityDestinationResponseDataVariant9Type? ToEnum(string value)
        {
            return value switch
            {
                "opik" => GetObservabilityDestinationResponseDataVariant9Type.Opik,
                _ => null,
            };
        }
    }
}