
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Tool call type<br/>
    /// Example: function
    /// </summary>
    public enum ChatStreamToolCallType
    {
        /// <summary>
        ///
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatStreamToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatStreamToolCallType value)
        {
            return value switch
            {
                ChatStreamToolCallType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatStreamToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "function" => ChatStreamToolCallType.Function,
                _ => null,
            };
        }
    }
}