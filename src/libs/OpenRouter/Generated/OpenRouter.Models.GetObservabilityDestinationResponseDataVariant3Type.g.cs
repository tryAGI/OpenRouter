
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: clickhouse
    /// </summary>
    public enum GetObservabilityDestinationResponseDataVariant3Type
    {
        /// <summary>
        /// clickhouse
        /// </summary>
        Clickhouse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetObservabilityDestinationResponseDataVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetObservabilityDestinationResponseDataVariant3Type value)
        {
            return value switch
            {
                GetObservabilityDestinationResponseDataVariant3Type.Clickhouse => "clickhouse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetObservabilityDestinationResponseDataVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "clickhouse" => GetObservabilityDestinationResponseDataVariant3Type.Clickhouse,
                _ => null,
            };
        }
    }
}