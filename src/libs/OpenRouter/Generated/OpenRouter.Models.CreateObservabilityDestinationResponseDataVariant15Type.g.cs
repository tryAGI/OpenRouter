
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: snowflake
    /// </summary>
    public enum CreateObservabilityDestinationResponseDataVariant15Type
    {
        /// <summary>
        /// snowflake
        /// </summary>
        Snowflake,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateObservabilityDestinationResponseDataVariant15TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateObservabilityDestinationResponseDataVariant15Type value)
        {
            return value switch
            {
                CreateObservabilityDestinationResponseDataVariant15Type.Snowflake => "snowflake",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateObservabilityDestinationResponseDataVariant15Type? ToEnum(string value)
        {
            return value switch
            {
                "snowflake" => CreateObservabilityDestinationResponseDataVariant15Type.Snowflake,
                _ => null,
            };
        }
    }
}