
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicToolSearchResultType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolSearchToolSearchResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicToolSearchResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicToolSearchResultType value)
        {
            return value switch
            {
                AnthropicToolSearchResultType.ToolSearchToolSearchResult => "tool_search_tool_search_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicToolSearchResultType? ToEnum(string value)
        {
            return value switch
            {
                "tool_search_tool_search_result" => AnthropicToolSearchResultType.ToolSearchToolSearchResult,
                _ => null,
            };
        }
    }
}