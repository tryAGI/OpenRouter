
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: json_schema
    /// </summary>
    public enum ChatRequestResponseFormatVariant3Type
    {
        /// <summary>
        /// json_schema
        /// </summary>
        JsonSchema,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestResponseFormatVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestResponseFormatVariant3Type value)
        {
            return value switch
            {
                ChatRequestResponseFormatVariant3Type.JsonSchema => "json_schema",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestResponseFormatVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "json_schema" => ChatRequestResponseFormatVariant3Type.JsonSchema,
                _ => null,
            };
        }
    }
}