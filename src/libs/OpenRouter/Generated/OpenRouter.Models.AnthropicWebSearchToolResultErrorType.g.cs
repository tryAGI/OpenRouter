
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicWebSearchToolResultErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearchToolResultError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicWebSearchToolResultErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicWebSearchToolResultErrorType value)
        {
            return value switch
            {
                AnthropicWebSearchToolResultErrorType.WebSearchToolResultError => "web_search_tool_result_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicWebSearchToolResultErrorType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_tool_result_error" => AnthropicWebSearchToolResultErrorType.WebSearchToolResultError,
                _ => null,
            };
        }
    }
}