
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: grammar
    /// </summary>
    public enum ChatRequestResponseFormatVariant1Type
    {
        /// <summary>
        /// grammar
        /// </summary>
        Grammar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestResponseFormatVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestResponseFormatVariant1Type value)
        {
            return value switch
            {
                ChatRequestResponseFormatVariant1Type.Grammar => "grammar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestResponseFormatVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "grammar" => ChatRequestResponseFormatVariant1Type.Grammar,
                _ => null,
            };
        }
    }
}