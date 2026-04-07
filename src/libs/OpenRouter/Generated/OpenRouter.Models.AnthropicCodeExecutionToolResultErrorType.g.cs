
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicCodeExecutionToolResultErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        CodeExecutionToolResultError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicCodeExecutionToolResultErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicCodeExecutionToolResultErrorType value)
        {
            return value switch
            {
                AnthropicCodeExecutionToolResultErrorType.CodeExecutionToolResultError => "code_execution_tool_result_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicCodeExecutionToolResultErrorType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_tool_result_error" => AnthropicCodeExecutionToolResultErrorType.CodeExecutionToolResultError,
                _ => null,
            };
        }
    }
}