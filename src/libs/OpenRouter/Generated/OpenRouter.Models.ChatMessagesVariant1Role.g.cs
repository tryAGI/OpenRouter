
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: assistant
    /// </summary>
    public enum ChatMessagesVariant1Role
    {
        /// <summary>
        /// assistant
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatMessagesVariant1RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMessagesVariant1Role value)
        {
            return value switch
            {
                ChatMessagesVariant1Role.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMessagesVariant1Role? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatMessagesVariant1Role.Assistant,
                _ => null,
            };
        }
    }
}