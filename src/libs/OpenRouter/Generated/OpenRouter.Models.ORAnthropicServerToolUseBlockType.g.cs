
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ORAnthropicServerToolUseBlockType
    {
        /// <summary>
        ///
        /// </summary>
        ServerToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ORAnthropicServerToolUseBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ORAnthropicServerToolUseBlockType value)
        {
            return value switch
            {
                ORAnthropicServerToolUseBlockType.ServerToolUse => "server_tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ORAnthropicServerToolUseBlockType? ToEnum(string value)
        {
            return value switch
            {
                "server_tool_use" => ORAnthropicServerToolUseBlockType.ServerToolUse,
                _ => null,
            };
        }
    }
}