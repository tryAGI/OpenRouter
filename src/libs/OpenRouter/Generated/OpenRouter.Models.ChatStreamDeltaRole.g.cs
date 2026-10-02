
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The role of the message author<br/>
    /// Example: assistant
    /// </summary>
    public enum ChatStreamDeltaRole
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatStreamDeltaRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatStreamDeltaRole value)
        {
            return value switch
            {
                ChatStreamDeltaRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatStreamDeltaRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatStreamDeltaRole.Assistant,
                _ => null,
            };
        }
    }
}