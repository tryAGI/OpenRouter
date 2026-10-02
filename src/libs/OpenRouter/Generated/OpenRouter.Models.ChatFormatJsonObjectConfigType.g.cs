
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ChatFormatJsonObjectConfigType
    {
        /// <summary>
        ///
        /// </summary>
        JsonObject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatFormatJsonObjectConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatFormatJsonObjectConfigType value)
        {
            return value switch
            {
                ChatFormatJsonObjectConfigType.JsonObject => "json_object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatFormatJsonObjectConfigType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => ChatFormatJsonObjectConfigType.JsonObject,
                _ => null,
            };
        }
    }
}