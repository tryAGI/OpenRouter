
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicBashCodeExecutionToolResultErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        BashCodeExecutionToolResultError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicBashCodeExecutionToolResultErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicBashCodeExecutionToolResultErrorType value)
        {
            return value switch
            {
                AnthropicBashCodeExecutionToolResultErrorType.BashCodeExecutionToolResultError => "bash_code_execution_tool_result_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicBashCodeExecutionToolResultErrorType? ToEnum(string value)
        {
            return value switch
            {
                "bash_code_execution_tool_result_error" => AnthropicBashCodeExecutionToolResultErrorType.BashCodeExecutionToolResultError,
                _ => null,
            };
        }
    }
}