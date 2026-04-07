
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicToolSearchToolResultType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolSearchToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicToolSearchToolResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicToolSearchToolResultType value)
        {
            return value switch
            {
                AnthropicToolSearchToolResultType.ToolSearchToolResult => "tool_search_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicToolSearchToolResultType? ToEnum(string value)
        {
            return value switch
            {
                "tool_search_tool_result" => AnthropicToolSearchToolResultType.ToolSearchToolResult,
                _ => null,
            };
        }
    }
}