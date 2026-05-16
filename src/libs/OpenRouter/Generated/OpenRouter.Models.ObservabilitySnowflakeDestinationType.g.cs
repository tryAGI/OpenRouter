
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ObservabilitySnowflakeDestinationType
    {
        /// <summary>
        /// 
        /// </summary>
        Snowflake,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilitySnowflakeDestinationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilitySnowflakeDestinationType value)
        {
            return value switch
            {
                ObservabilitySnowflakeDestinationType.Snowflake => "snowflake",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilitySnowflakeDestinationType? ToEnum(string value)
        {
            return value switch
            {
                "snowflake" => ObservabilitySnowflakeDestinationType.Snowflake,
                _ => null,
            };
        }
    }
}