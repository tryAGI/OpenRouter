
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: langfuse
    /// </summary>
    public enum GetObservabilityDestinationResponseDataVariant6Type
    {
        /// <summary>
        /// langfuse
        /// </summary>
        Langfuse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetObservabilityDestinationResponseDataVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetObservabilityDestinationResponseDataVariant6Type value)
        {
            return value switch
            {
                GetObservabilityDestinationResponseDataVariant6Type.Langfuse => "langfuse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetObservabilityDestinationResponseDataVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "langfuse" => GetObservabilityDestinationResponseDataVariant6Type.Langfuse,
                _ => null,
            };
        }
    }
}