
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: langfuse
    /// </summary>
    public enum ObservabilityDestinationVariant6Type
    {
        /// <summary>
        /// langfuse
        /// </summary>
        Langfuse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityDestinationVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityDestinationVariant6Type value)
        {
            return value switch
            {
                ObservabilityDestinationVariant6Type.Langfuse => "langfuse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityDestinationVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "langfuse" => ObservabilityDestinationVariant6Type.Langfuse,
                _ => null,
            };
        }
    }
}