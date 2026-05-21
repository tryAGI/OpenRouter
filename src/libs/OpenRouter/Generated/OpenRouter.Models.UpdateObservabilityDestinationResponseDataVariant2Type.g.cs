
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: braintrust
    /// </summary>
    public enum UpdateObservabilityDestinationResponseDataVariant2Type
    {
        /// <summary>
        /// braintrust
        /// </summary>
        Braintrust,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateObservabilityDestinationResponseDataVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateObservabilityDestinationResponseDataVariant2Type value)
        {
            return value switch
            {
                UpdateObservabilityDestinationResponseDataVariant2Type.Braintrust => "braintrust",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateObservabilityDestinationResponseDataVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "braintrust" => UpdateObservabilityDestinationResponseDataVariant2Type.Braintrust,
                _ => null,
            };
        }
    }
}