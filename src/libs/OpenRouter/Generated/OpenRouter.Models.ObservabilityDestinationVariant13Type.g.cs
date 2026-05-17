
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: s3
    /// </summary>
    public enum ObservabilityDestinationVariant13Type
    {
        /// <summary>
        /// s3
        /// </summary>
        S3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityDestinationVariant13TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityDestinationVariant13Type value)
        {
            return value switch
            {
                ObservabilityDestinationVariant13Type.S3 => "s3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityDestinationVariant13Type? ToEnum(string value)
        {
            return value switch
            {
                "s3" => ObservabilityDestinationVariant13Type.S3,
                _ => null,
            };
        }
    }
}