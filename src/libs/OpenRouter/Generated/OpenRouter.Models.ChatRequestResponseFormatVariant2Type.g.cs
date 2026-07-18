
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: json_object
    /// </summary>
    public enum ChatRequestResponseFormatVariant2Type
    {
        /// <summary>
        /// json_object
        /// </summary>
        JsonObject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestResponseFormatVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestResponseFormatVariant2Type value)
        {
            return value switch
            {
                ChatRequestResponseFormatVariant2Type.JsonObject => "json_object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestResponseFormatVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => ChatRequestResponseFormatVariant2Type.JsonObject,
                _ => null,
            };
        }
    }
}