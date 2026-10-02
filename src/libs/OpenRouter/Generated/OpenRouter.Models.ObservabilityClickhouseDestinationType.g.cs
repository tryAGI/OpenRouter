
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ObservabilityClickhouseDestinationType
    {
        /// <summary>
        ///
        /// </summary>
        Clickhouse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityClickhouseDestinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityClickhouseDestinationType value)
        {
            return value switch
            {
                ObservabilityClickhouseDestinationType.Clickhouse => "clickhouse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityClickhouseDestinationType? ToEnum(string value)
        {
            return value switch
            {
                "clickhouse" => ObservabilityClickhouseDestinationType.Clickhouse,
                _ => null,
            };
        }
    }
}