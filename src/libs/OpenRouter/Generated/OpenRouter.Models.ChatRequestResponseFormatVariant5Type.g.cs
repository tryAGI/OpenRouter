
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: text
    /// </summary>
    public enum ChatRequestResponseFormatVariant5Type
    {
        /// <summary>
        /// text
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestResponseFormatVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestResponseFormatVariant5Type value)
        {
            return value switch
            {
                ChatRequestResponseFormatVariant5Type.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestResponseFormatVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "text" => ChatRequestResponseFormatVariant5Type.Text,
                _ => null,
            };
        }
    }
}