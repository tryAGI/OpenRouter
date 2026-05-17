
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: langfuse
    /// </summary>
    public enum UpdateObservabilityDestinationResponseDataVariant6Type
    {
        /// <summary>
        /// langfuse
        /// </summary>
        Langfuse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateObservabilityDestinationResponseDataVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateObservabilityDestinationResponseDataVariant6Type value)
        {
            return value switch
            {
                UpdateObservabilityDestinationResponseDataVariant6Type.Langfuse => "langfuse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateObservabilityDestinationResponseDataVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "langfuse" => UpdateObservabilityDestinationResponseDataVariant6Type.Langfuse,
                _ => null,
            };
        }
    }
}