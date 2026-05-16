
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ObservabilityOpikDestinationType
    {
        /// <summary>
        /// 
        /// </summary>
        Opik,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityOpikDestinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityOpikDestinationType value)
        {
            return value switch
            {
                ObservabilityOpikDestinationType.Opik => "opik",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityOpikDestinationType? ToEnum(string value)
        {
            return value switch
            {
                "opik" => ObservabilityOpikDestinationType.Opik,
                _ => null,
            };
        }
    }
}