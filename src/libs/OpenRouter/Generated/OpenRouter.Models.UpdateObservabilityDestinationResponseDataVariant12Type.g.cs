
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: ramp
    /// </summary>
    public enum UpdateObservabilityDestinationResponseDataVariant12Type
    {
        /// <summary>
        /// ramp
        /// </summary>
        Ramp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateObservabilityDestinationResponseDataVariant12TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateObservabilityDestinationResponseDataVariant12Type value)
        {
            return value switch
            {
                UpdateObservabilityDestinationResponseDataVariant12Type.Ramp => "ramp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateObservabilityDestinationResponseDataVariant12Type? ToEnum(string value)
        {
            return value switch
            {
                "ramp" => UpdateObservabilityDestinationResponseDataVariant12Type.Ramp,
                _ => null,
            };
        }
    }
}