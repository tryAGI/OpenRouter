
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: posthog
    /// </summary>
    public enum ObservabilityDestinationVariant11Type
    {
        /// <summary>
        /// posthog
        /// </summary>
        Posthog,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityDestinationVariant11TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityDestinationVariant11Type value)
        {
            return value switch
            {
                ObservabilityDestinationVariant11Type.Posthog => "posthog",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityDestinationVariant11Type? ToEnum(string value)
        {
            return value switch
            {
                "posthog" => ObservabilityDestinationVariant11Type.Posthog,
                _ => null,
            };
        }
    }
}