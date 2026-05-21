
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OrAnthropicServerToolUseBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        ServerToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrAnthropicServerToolUseBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrAnthropicServerToolUseBlockType value)
        {
            return value switch
            {
                OrAnthropicServerToolUseBlockType.ServerToolUse => "server_tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrAnthropicServerToolUseBlockType? ToEnum(string value)
        {
            return value switch
            {
                "server_tool_use" => OrAnthropicServerToolUseBlockType.ServerToolUse,
                _ => null,
            };
        }
    }
}