
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicToolUsesTriggerType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolUses,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicToolUsesTriggerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicToolUsesTriggerType value)
        {
            return value switch
            {
                AnthropicToolUsesTriggerType.ToolUses => "tool_uses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicToolUsesTriggerType? ToEnum(string value)
        {
            return value switch
            {
                "tool_uses" => AnthropicToolUsesTriggerType.ToolUses,
                _ => null,
            };
        }
    }
}