
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum InternChatMessageDiscriminatorRole
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
    public static class InternChatMessageDiscriminatorRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InternChatMessageDiscriminatorRole value)
        {
            return value switch
            {
                InternChatMessageDiscriminatorRole.Assistant => "assistant",
                InternChatMessageDiscriminatorRole.Developer => "developer",
                InternChatMessageDiscriminatorRole.System => "system",
                InternChatMessageDiscriminatorRole.Tool => "tool",
                InternChatMessageDiscriminatorRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InternChatMessageDiscriminatorRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => InternChatMessageDiscriminatorRole.Assistant,
                "developer" => InternChatMessageDiscriminatorRole.Developer,
                "system" => InternChatMessageDiscriminatorRole.System,
                "tool" => InternChatMessageDiscriminatorRole.Tool,
                "user" => InternChatMessageDiscriminatorRole.User,
                _ => null,
            };
        }
    }
}