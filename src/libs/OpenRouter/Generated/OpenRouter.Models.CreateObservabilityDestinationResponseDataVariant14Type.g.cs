
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: sentry
    /// </summary>
    public enum CreateObservabilityDestinationResponseDataVariant14Type
    {
        /// <summary>
        /// sentry
        /// </summary>
        Sentry,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateObservabilityDestinationResponseDataVariant14TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateObservabilityDestinationResponseDataVariant14Type value)
        {
            return value switch
            {
                CreateObservabilityDestinationResponseDataVariant14Type.Sentry => "sentry",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateObservabilityDestinationResponseDataVariant14Type? ToEnum(string value)
        {
            return value switch
            {
                "sentry" => CreateObservabilityDestinationResponseDataVariant14Type.Sentry,
                _ => null,
            };
        }
    }
}