
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ObservabilityDatadogDestinationType
    {
        /// <summary>
        ///
        /// </summary>
        Datadog,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityDatadogDestinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityDatadogDestinationType value)
        {
            return value switch
            {
                ObservabilityDatadogDestinationType.Datadog => "datadog",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityDatadogDestinationType? ToEnum(string value)
        {
            return value switch
            {
                "datadog" => ObservabilityDatadogDestinationType.Datadog,
                _ => null,
            };
        }
    }
}