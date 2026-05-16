
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ObservabilityWeaveDestinationType
    {
        /// <summary>
        /// 
        /// </summary>
        Weave,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityWeaveDestinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityWeaveDestinationType value)
        {
            return value switch
            {
                ObservabilityWeaveDestinationType.Weave => "weave",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityWeaveDestinationType? ToEnum(string value)
        {
            return value switch
            {
                "weave" => ObservabilityWeaveDestinationType.Weave,
                _ => null,
            };
        }
    }
}