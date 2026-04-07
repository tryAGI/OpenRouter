
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicServerToolErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        ExecutionTimeExceeded,
        /// <summary>
        /// 
        /// </summary>
        InvalidToolInput,
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
    public static class AnthropicServerToolErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicServerToolErrorCode value)
        {
            return value switch
            {
                AnthropicServerToolErrorCode.ExecutionTimeExceeded => "execution_time_exceeded",
                AnthropicServerToolErrorCode.InvalidToolInput => "invalid_tool_input",
                AnthropicServerToolErrorCode.TooManyRequests => "too_many_requests",
                AnthropicServerToolErrorCode.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicServerToolErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "execution_time_exceeded" => AnthropicServerToolErrorCode.ExecutionTimeExceeded,
                "invalid_tool_input" => AnthropicServerToolErrorCode.InvalidToolInput,
                "too_many_requests" => AnthropicServerToolErrorCode.TooManyRequests,
                "unavailable" => AnthropicServerToolErrorCode.Unavailable,
                _ => null,
            };
        }
    }
}