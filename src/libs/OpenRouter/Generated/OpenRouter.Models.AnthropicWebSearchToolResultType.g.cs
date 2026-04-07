
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicWebSearchToolResultType
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearchToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicWebSearchToolResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicWebSearchToolResultType value)
        {
            return value switch
            {
                AnthropicWebSearchToolResultType.WebSearchToolResult => "web_search_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicWebSearchToolResultType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_tool_result" => AnthropicWebSearchToolResultType.WebSearchToolResult,
                _ => null,
            };
        }
    }
}