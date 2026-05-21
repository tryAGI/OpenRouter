
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: clickhouse
    /// </summary>
    public enum ObservabilityDestinationVariant3Type
    {
        /// <summary>
        /// clickhouse
        /// </summary>
        Clickhouse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityDestinationVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityDestinationVariant3Type value)
        {
            return value switch
            {
                ObservabilityDestinationVariant3Type.Clickhouse => "clickhouse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityDestinationVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "clickhouse" => ObservabilityDestinationVariant3Type.Clickhouse,
                _ => null,
            };
        }
    }
}