
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicWebFetchToolResultType
    {
        /// <summary>
        /// 
        /// </summary>
        WebFetchToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicWebFetchToolResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicWebFetchToolResultType value)
        {
            return value switch
            {
                AnthropicWebFetchToolResultType.WebFetchToolResult => "web_fetch_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicWebFetchToolResultType? ToEnum(string value)
        {
            return value switch
            {
                "web_fetch_tool_result" => AnthropicWebFetchToolResultType.WebFetchToolResult,
                _ => null,
            };
        }
    }
}