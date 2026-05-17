
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: posthog
    /// </summary>
    public enum CreateObservabilityDestinationResponseDataVariant11Type
    {
        /// <summary>
        /// posthog
        /// </summary>
        Posthog,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateObservabilityDestinationResponseDataVariant11TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateObservabilityDestinationResponseDataVariant11Type value)
        {
            return value switch
            {
                CreateObservabilityDestinationResponseDataVariant11Type.Posthog => "posthog",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateObservabilityDestinationResponseDataVariant11Type? ToEnum(string value)
        {
            return value switch
            {
                "posthog" => CreateObservabilityDestinationResponseDataVariant11Type.Posthog,
                _ => null,
            };
        }
    }
}