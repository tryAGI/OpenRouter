
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ObservabilityBraintrustDestinationType
    {
        /// <summary>
        ///
        /// </summary>
        Braintrust,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityBraintrustDestinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityBraintrustDestinationType value)
        {
            return value switch
            {
                ObservabilityBraintrustDestinationType.Braintrust => "braintrust",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityBraintrustDestinationType? ToEnum(string value)
        {
            return value switch
            {
                "braintrust" => ObservabilityBraintrustDestinationType.Braintrust,
                _ => null,
            };
        }
    }
}