
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: posthog
    /// </summary>
    public enum UpdateObservabilityDestinationResponseDataVariant11Type
    {
        /// <summary>
        /// posthog
        /// </summary>
        Posthog,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateObservabilityDestinationResponseDataVariant11TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateObservabilityDestinationResponseDataVariant11Type value)
        {
            return value switch
            {
                UpdateObservabilityDestinationResponseDataVariant11Type.Posthog => "posthog",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateObservabilityDestinationResponseDataVariant11Type? ToEnum(string value)
        {
            return value switch
            {
                "posthog" => UpdateObservabilityDestinationResponseDataVariant11Type.Posthog,
                _ => null,
            };
        }
    }
}