
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: sentry
    /// </summary>
    public enum ObservabilityDestinationVariant14Type
    {
        /// <summary>
        /// sentry
        /// </summary>
        Sentry,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityDestinationVariant14TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityDestinationVariant14Type value)
        {
            return value switch
            {
                ObservabilityDestinationVariant14Type.Sentry => "sentry",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityDestinationVariant14Type? ToEnum(string value)
        {
            return value switch
            {
                "sentry" => ObservabilityDestinationVariant14Type.Sentry,
                _ => null,
            };
        }
    }
}