
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicWebSearchToolResultErrorErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        InvalidToolInput,
        /// <summary>
        /// 
        /// </summary>
        MaxUsesExceeded,
        /// <summary>
        /// 
        /// </summary>
        QueryTooLong,
        /// <summary>
        /// 
        /// </summary>
        RequestTooLarge,
        /// <summary>
        /// 
        /// </summary>
        TooManyRequests,
        /// <summary>
        /// 
        /// </summary>
        Unavailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicWebSearchToolResultErrorErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicWebSearchToolResultErrorErrorCode value)
        {
            return value switch
            {
                AnthropicWebSearchToolResultErrorErrorCode.InvalidToolInput => "invalid_tool_input",
                AnthropicWebSearchToolResultErrorErrorCode.MaxUsesExceeded => "max_uses_exceeded",
                AnthropicWebSearchToolResultErrorErrorCode.QueryTooLong => "query_too_long",
                AnthropicWebSearchToolResultErrorErrorCode.RequestTooLarge => "request_too_large",
                AnthropicWebSearchToolResultErrorErrorCode.TooManyRequests => "too_many_requests",
                AnthropicWebSearchToolResultErrorErrorCode.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicWebSearchToolResultErrorErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "invalid_tool_input" => AnthropicWebSearchToolResultErrorErrorCode.InvalidToolInput,
                "max_uses_exceeded" => AnthropicWebSearchToolResultErrorErrorCode.MaxUsesExceeded,
                "query_too_long" => AnthropicWebSearchToolResultErrorErrorCode.QueryTooLong,
                "request_too_large" => AnthropicWebSearchToolResultErrorErrorCode.RequestTooLarge,
                "too_many_requests" => AnthropicWebSearchToolResultErrorErrorCode.TooManyRequests,
                "unavailable" => AnthropicWebSearchToolResultErrorErrorCode.Unavailable,
                _ => null,
            };
        }
    }
}