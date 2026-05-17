
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: s3
    /// </summary>
    public enum GetObservabilityDestinationResponseDataVariant13Type
    {
        /// <summary>
        /// s3
        /// </summary>
        S3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetObservabilityDestinationResponseDataVariant13TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetObservabilityDestinationResponseDataVariant13Type value)
        {
            return value switch
            {
                GetObservabilityDestinationResponseDataVariant13Type.S3 => "s3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetObservabilityDestinationResponseDataVariant13Type? ToEnum(string value)
        {
            return value switch
            {
                "s3" => GetObservabilityDestinationResponseDataVariant13Type.S3,
                _ => null,
            };
        }
    }
}