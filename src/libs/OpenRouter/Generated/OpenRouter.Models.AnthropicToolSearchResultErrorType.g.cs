
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicToolSearchResultErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolSearchToolResultError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicToolSearchResultErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicToolSearchResultErrorType value)
        {
            return value switch
            {
                AnthropicToolSearchResultErrorType.ToolSearchToolResultError => "tool_search_tool_result_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicToolSearchResultErrorType? ToEnum(string value)
        {
            return value switch
            {
                "tool_search_tool_result_error" => AnthropicToolSearchResultErrorType.ToolSearchToolResultError,
                _ => null,
            };
        }
    }
}