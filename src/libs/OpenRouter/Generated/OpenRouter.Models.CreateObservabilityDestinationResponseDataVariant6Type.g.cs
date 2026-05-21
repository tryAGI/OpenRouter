
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: langfuse
    /// </summary>
    public enum CreateObservabilityDestinationResponseDataVariant6Type
    {
        /// <summary>
        /// langfuse
        /// </summary>
        Langfuse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateObservabilityDestinationResponseDataVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateObservabilityDestinationResponseDataVariant6Type value)
        {
            return value switch
            {
                CreateObservabilityDestinationResponseDataVariant6Type.Langfuse => "langfuse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateObservabilityDestinationResponseDataVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "langfuse" => CreateObservabilityDestinationResponseDataVariant6Type.Langfuse,
                _ => null,
            };
        }
    }
}