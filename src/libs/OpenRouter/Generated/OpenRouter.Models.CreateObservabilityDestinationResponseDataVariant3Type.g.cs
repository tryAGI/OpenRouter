
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: clickhouse
    /// </summary>
    public enum CreateObservabilityDestinationResponseDataVariant3Type
    {
        /// <summary>
        /// clickhouse
        /// </summary>
        Clickhouse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateObservabilityDestinationResponseDataVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateObservabilityDestinationResponseDataVariant3Type value)
        {
            return value switch
            {
                CreateObservabilityDestinationResponseDataVariant3Type.Clickhouse => "clickhouse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateObservabilityDestinationResponseDataVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "clickhouse" => CreateObservabilityDestinationResponseDataVariant3Type.Clickhouse,
                _ => null,
            };
        }
    }
}