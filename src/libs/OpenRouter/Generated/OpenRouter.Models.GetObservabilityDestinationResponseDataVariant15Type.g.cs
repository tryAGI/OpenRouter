
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: snowflake
    /// </summary>
    public enum GetObservabilityDestinationResponseDataVariant15Type
    {
        /// <summary>
        /// snowflake
        /// </summary>
        Snowflake,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetObservabilityDestinationResponseDataVariant15TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetObservabilityDestinationResponseDataVariant15Type value)
        {
            return value switch
            {
                GetObservabilityDestinationResponseDataVariant15Type.Snowflake => "snowflake",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetObservabilityDestinationResponseDataVariant15Type? ToEnum(string value)
        {
            return value switch
            {
                "snowflake" => GetObservabilityDestinationResponseDataVariant15Type.Snowflake,
                _ => null,
            };
        }
    }
}