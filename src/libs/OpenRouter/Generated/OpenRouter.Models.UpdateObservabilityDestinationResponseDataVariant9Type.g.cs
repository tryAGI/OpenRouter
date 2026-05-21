
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: opik
    /// </summary>
    public enum UpdateObservabilityDestinationResponseDataVariant9Type
    {
        /// <summary>
        /// opik
        /// </summary>
        Opik,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateObservabilityDestinationResponseDataVariant9TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateObservabilityDestinationResponseDataVariant9Type value)
        {
            return value switch
            {
                UpdateObservabilityDestinationResponseDataVariant9Type.Opik => "opik",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateObservabilityDestinationResponseDataVariant9Type? ToEnum(string value)
        {
            return value switch
            {
                "opik" => UpdateObservabilityDestinationResponseDataVariant9Type.Opik,
                _ => null,
            };
        }
    }
}