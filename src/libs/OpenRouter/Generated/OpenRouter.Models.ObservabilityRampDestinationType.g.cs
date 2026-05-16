
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ObservabilityRampDestinationType
    {
        /// <summary>
        /// 
        /// </summary>
        Ramp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityRampDestinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityRampDestinationType value)
        {
            return value switch
            {
                ObservabilityRampDestinationType.Ramp => "ramp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityRampDestinationType? ToEnum(string value)
        {
            return value switch
            {
                "ramp" => ObservabilityRampDestinationType.Ramp,
                _ => null,
            };
        }
    }
}