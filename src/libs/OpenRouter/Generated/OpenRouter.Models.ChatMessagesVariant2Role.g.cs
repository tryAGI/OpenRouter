
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: developer
    /// </summary>
    public enum ChatMessagesVariant2Role
    {
        /// <summary>
        /// developer
        /// </summary>
        Developer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatMessagesVariant2RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMessagesVariant2Role value)
        {
            return value switch
            {
                ChatMessagesVariant2Role.Developer => "developer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMessagesVariant2Role? ToEnum(string value)
        {
            return value switch
            {
                "developer" => ChatMessagesVariant2Role.Developer,
                _ => null,
            };
        }
    }
}