
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: sentry
    /// </summary>
    public enum GetObservabilityDestinationResponseDataVariant14Type
    {
        /// <summary>
        /// sentry
        /// </summary>
        Sentry,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetObservabilityDestinationResponseDataVariant14TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetObservabilityDestinationResponseDataVariant14Type value)
        {
            return value switch
            {
                GetObservabilityDestinationResponseDataVariant14Type.Sentry => "sentry",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetObservabilityDestinationResponseDataVariant14Type? ToEnum(string value)
        {
            return value switch
            {
                "sentry" => GetObservabilityDestinationResponseDataVariant14Type.Sentry,
                _ => null,
            };
        }
    }
}