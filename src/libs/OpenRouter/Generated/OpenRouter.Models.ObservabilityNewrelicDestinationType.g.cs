
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ObservabilityNewrelicDestinationType
    {
        /// <summary>
        /// 
        /// </summary>
        Newrelic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityNewrelicDestinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityNewrelicDestinationType value)
        {
            return value switch
            {
                ObservabilityNewrelicDestinationType.Newrelic => "newrelic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityNewrelicDestinationType? ToEnum(string value)
        {
            return value switch
            {
                "newrelic" => ObservabilityNewrelicDestinationType.Newrelic,
                _ => null,
            };
        }
    }
}