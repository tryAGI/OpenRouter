
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: clickhouse
    /// </summary>
    public enum UpdateObservabilityDestinationResponseDataVariant3Type
    {
        /// <summary>
        /// clickhouse
        /// </summary>
        Clickhouse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateObservabilityDestinationResponseDataVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateObservabilityDestinationResponseDataVariant3Type value)
        {
            return value switch
            {
                UpdateObservabilityDestinationResponseDataVariant3Type.Clickhouse => "clickhouse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateObservabilityDestinationResponseDataVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "clickhouse" => UpdateObservabilityDestinationResponseDataVariant3Type.Clickhouse,
                _ => null,
            };
        }
    }
}