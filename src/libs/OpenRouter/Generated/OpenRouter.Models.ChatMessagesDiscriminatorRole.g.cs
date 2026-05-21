
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatMessagesDiscriminatorRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        Developer,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        Tool,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatMessagesDiscriminatorRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMessagesDiscriminatorRole value)
        {
            return value switch
            {
                ChatMessagesDiscriminatorRole.Assistant => "assistant",
                ChatMessagesDiscriminatorRole.Developer => "developer",
                ChatMessagesDiscriminatorRole.System => "system",
                ChatMessagesDiscriminatorRole.Tool => "tool",
                ChatMessagesDiscriminatorRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMessagesDiscriminatorRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatMessagesDiscriminatorRole.Assistant,
                "developer" => ChatMessagesDiscriminatorRole.Developer,
                "system" => ChatMessagesDiscriminatorRole.System,
                "tool" => ChatMessagesDiscriminatorRole.Tool,
                "user" => ChatMessagesDiscriminatorRole.User,
                _ => null,
            };
        }
    }
}