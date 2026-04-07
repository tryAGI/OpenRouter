
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicTextEditorCodeExecutionToolResultErrorErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        ExecutionTimeExceeded,
        /// <summary>
        /// 
        /// </summary>
        FileNotFound,
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
    public static class AnthropicTextEditorCodeExecutionToolResultErrorErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicTextEditorCodeExecutionToolResultErrorErrorCode value)
        {
            return value switch
            {
                AnthropicTextEditorCodeExecutionToolResultErrorErrorCode.ExecutionTimeExceeded => "execution_time_exceeded",
                AnthropicTextEditorCodeExecutionToolResultErrorErrorCode.FileNotFound => "file_not_found",
                AnthropicTextEditorCodeExecutionToolResultErrorErrorCode.InvalidToolInput => "invalid_tool_input",
                AnthropicTextEditorCodeExecutionToolResultErrorErrorCode.TooManyRequests => "too_many_requests",
                AnthropicTextEditorCodeExecutionToolResultErrorErrorCode.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicTextEditorCodeExecutionToolResultErrorErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "execution_time_exceeded" => AnthropicTextEditorCodeExecutionToolResultErrorErrorCode.ExecutionTimeExceeded,
                "file_not_found" => AnthropicTextEditorCodeExecutionToolResultErrorErrorCode.FileNotFound,
                "invalid_tool_input" => AnthropicTextEditorCodeExecutionToolResultErrorErrorCode.InvalidToolInput,
                "too_many_requests" => AnthropicTextEditorCodeExecutionToolResultErrorErrorCode.TooManyRequests,
                "unavailable" => AnthropicTextEditorCodeExecutionToolResultErrorErrorCode.Unavailable,
                _ => null,
            };
        }
    }
}