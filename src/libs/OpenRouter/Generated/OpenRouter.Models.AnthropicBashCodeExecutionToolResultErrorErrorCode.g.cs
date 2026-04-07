
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicBashCodeExecutionToolResultErrorErrorCode
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
        OutputFileTooLarge,
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
    public static class AnthropicBashCodeExecutionToolResultErrorErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicBashCodeExecutionToolResultErrorErrorCode value)
        {
            return value switch
            {
                AnthropicBashCodeExecutionToolResultErrorErrorCode.ExecutionTimeExceeded => "execution_time_exceeded",
                AnthropicBashCodeExecutionToolResultErrorErrorCode.InvalidToolInput => "invalid_tool_input",
                AnthropicBashCodeExecutionToolResultErrorErrorCode.OutputFileTooLarge => "output_file_too_large",
                AnthropicBashCodeExecutionToolResultErrorErrorCode.TooManyRequests => "too_many_requests",
                AnthropicBashCodeExecutionToolResultErrorErrorCode.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicBashCodeExecutionToolResultErrorErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "execution_time_exceeded" => AnthropicBashCodeExecutionToolResultErrorErrorCode.ExecutionTimeExceeded,
                "invalid_tool_input" => AnthropicBashCodeExecutionToolResultErrorErrorCode.InvalidToolInput,
                "output_file_too_large" => AnthropicBashCodeExecutionToolResultErrorErrorCode.OutputFileTooLarge,
                "too_many_requests" => AnthropicBashCodeExecutionToolResultErrorErrorCode.TooManyRequests,
                "unavailable" => AnthropicBashCodeExecutionToolResultErrorErrorCode.Unavailable,
                _ => null,
            };
        }
    }
}