
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum AlignmentChatRejectedRole
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlignmentChatRejectedRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlignmentChatRejectedRole value)
        {
            return value switch
            {
                AlignmentChatRejectedRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlignmentChatRejectedRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AlignmentChatRejectedRole.Assistant,
                _ => null,
            };
        }
    }
}