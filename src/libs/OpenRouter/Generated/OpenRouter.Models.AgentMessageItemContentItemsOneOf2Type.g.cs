
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentMessageItemContentItemsOneOf2Type
    {
        /// <summary>
        /// 
        /// </summary>
        EncryptedContent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentMessageItemContentItemsOneOf2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentMessageItemContentItemsOneOf2Type value)
        {
            return value switch
            {
                AgentMessageItemContentItemsOneOf2Type.EncryptedContent => "encrypted_content",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentMessageItemContentItemsOneOf2Type? ToEnum(string value)
        {
            return value switch
            {
                "encrypted_content" => AgentMessageItemContentItemsOneOf2Type.EncryptedContent,
                _ => null,
            };
        }
    }
}