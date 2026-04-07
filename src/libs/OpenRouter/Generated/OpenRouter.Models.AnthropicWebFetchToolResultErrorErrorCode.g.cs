
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicWebFetchToolResultErrorErrorCode
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
        TooManyRequests,
        /// <summary>
        /// 
        /// </summary>
        Unavailable,
        /// <summary>
        /// 
        /// </summary>
        UnsupportedContentType,
        /// <summary>
        /// 
        /// </summary>
        UrlNotAccessible,
        /// <summary>
        /// 
        /// </summary>
        UrlNotAllowed,
        /// <summary>
        /// 
        /// </summary>
        UrlTooLong,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicWebFetchToolResultErrorErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicWebFetchToolResultErrorErrorCode value)
        {
            return value switch
            {
                AnthropicWebFetchToolResultErrorErrorCode.InvalidToolInput => "invalid_tool_input",
                AnthropicWebFetchToolResultErrorErrorCode.MaxUsesExceeded => "max_uses_exceeded",
                AnthropicWebFetchToolResultErrorErrorCode.TooManyRequests => "too_many_requests",
                AnthropicWebFetchToolResultErrorErrorCode.Unavailable => "unavailable",
                AnthropicWebFetchToolResultErrorErrorCode.UnsupportedContentType => "unsupported_content_type",
                AnthropicWebFetchToolResultErrorErrorCode.UrlNotAccessible => "url_not_accessible",
                AnthropicWebFetchToolResultErrorErrorCode.UrlNotAllowed => "url_not_allowed",
                AnthropicWebFetchToolResultErrorErrorCode.UrlTooLong => "url_too_long",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicWebFetchToolResultErrorErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "invalid_tool_input" => AnthropicWebFetchToolResultErrorErrorCode.InvalidToolInput,
                "max_uses_exceeded" => AnthropicWebFetchToolResultErrorErrorCode.MaxUsesExceeded,
                "too_many_requests" => AnthropicWebFetchToolResultErrorErrorCode.TooManyRequests,
                "unavailable" => AnthropicWebFetchToolResultErrorErrorCode.Unavailable,
                "unsupported_content_type" => AnthropicWebFetchToolResultErrorErrorCode.UnsupportedContentType,
                "url_not_accessible" => AnthropicWebFetchToolResultErrorErrorCode.UrlNotAccessible,
                "url_not_allowed" => AnthropicWebFetchToolResultErrorErrorCode.UrlNotAllowed,
                "url_too_long" => AnthropicWebFetchToolResultErrorErrorCode.UrlTooLong,
                _ => null,
            };
        }
    }
}