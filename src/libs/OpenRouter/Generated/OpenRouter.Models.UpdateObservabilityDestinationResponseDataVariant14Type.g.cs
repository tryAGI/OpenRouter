
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: sentry
    /// </summary>
    public enum UpdateObservabilityDestinationResponseDataVariant14Type
    {
        /// <summary>
        /// sentry
        /// </summary>
        Sentry,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateObservabilityDestinationResponseDataVariant14TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateObservabilityDestinationResponseDataVariant14Type value)
        {
            return value switch
            {
                UpdateObservabilityDestinationResponseDataVariant14Type.Sentry => "sentry",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateObservabilityDestinationResponseDataVariant14Type? ToEnum(string value)
        {
            return value switch
            {
                "sentry" => UpdateObservabilityDestinationResponseDataVariant14Type.Sentry,
                _ => null,
            };
        }
    }
}