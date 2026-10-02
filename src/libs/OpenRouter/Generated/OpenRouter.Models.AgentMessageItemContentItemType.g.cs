
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentMessageItemContentItemType
    {
        /// <summary>
        ///
        /// </summary>
        EncryptedContent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentMessageItemContentItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentMessageItemContentItemType value)
        {
            return value switch
            {
                AgentMessageItemContentItemType.EncryptedContent => "encrypted_content",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentMessageItemContentItemType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted_content" => AgentMessageItemContentItemType.EncryptedContent,
                _ => null,
            };
        }
    }
}