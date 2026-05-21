
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: ramp
    /// </summary>
    public enum CreateObservabilityDestinationResponseDataVariant12Type
    {
        /// <summary>
        /// ramp
        /// </summary>
        Ramp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateObservabilityDestinationResponseDataVariant12TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateObservabilityDestinationResponseDataVariant12Type value)
        {
            return value switch
            {
                CreateObservabilityDestinationResponseDataVariant12Type.Ramp => "ramp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateObservabilityDestinationResponseDataVariant12Type? ToEnum(string value)
        {
            return value switch
            {
                "ramp" => CreateObservabilityDestinationResponseDataVariant12Type.Ramp,
                _ => null,
            };
        }
    }
}