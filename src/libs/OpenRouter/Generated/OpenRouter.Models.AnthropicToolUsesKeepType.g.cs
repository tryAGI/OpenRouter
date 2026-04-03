
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicToolUsesKeepType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolUses,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicToolUsesKeepTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicToolUsesKeepType value)
        {
            return value switch
            {
                AnthropicToolUsesKeepType.ToolUses => "tool_uses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicToolUsesKeepType? ToEnum(string value)
        {
            return value switch
            {
                "tool_uses" => AnthropicToolUsesKeepType.ToolUses,
                _ => null,
            };
        }
    }
}