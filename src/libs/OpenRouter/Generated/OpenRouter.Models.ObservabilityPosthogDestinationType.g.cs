
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ObservabilityPosthogDestinationType
    {
        /// <summary>
        /// 
        /// </summary>
        Posthog,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityPosthogDestinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityPosthogDestinationType value)
        {
            return value switch
            {
                ObservabilityPosthogDestinationType.Posthog => "posthog",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityPosthogDestinationType? ToEnum(string value)
        {
            return value switch
            {
                "posthog" => ObservabilityPosthogDestinationType.Posthog,
                _ => null,
            };
        }
    }
}