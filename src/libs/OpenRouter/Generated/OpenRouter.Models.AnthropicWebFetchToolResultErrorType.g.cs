
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicWebFetchToolResultErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        WebFetchToolResultError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicWebFetchToolResultErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicWebFetchToolResultErrorType value)
        {
            return value switch
            {
                AnthropicWebFetchToolResultErrorType.WebFetchToolResultError => "web_fetch_tool_result_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicWebFetchToolResultErrorType? ToEnum(string value)
        {
            return value switch
            {
                "web_fetch_tool_result_error" => AnthropicWebFetchToolResultErrorType.WebFetchToolResultError,
                _ => null,
            };
        }
    }
}