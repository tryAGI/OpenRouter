
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicBashCodeExecutionContentDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        BashCodeExecutionResult,
        /// <summary>
        /// 
        /// </summary>
        BashCodeExecutionToolResultError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicBashCodeExecutionContentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicBashCodeExecutionContentDiscriminatorType value)
        {
            return value switch
            {
                AnthropicBashCodeExecutionContentDiscriminatorType.BashCodeExecutionResult => "bash_code_execution_result",
                AnthropicBashCodeExecutionContentDiscriminatorType.BashCodeExecutionToolResultError => "bash_code_execution_tool_result_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicBashCodeExecutionContentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "bash_code_execution_result" => AnthropicBashCodeExecutionContentDiscriminatorType.BashCodeExecutionResult,
                "bash_code_execution_tool_result_error" => AnthropicBashCodeExecutionContentDiscriminatorType.BashCodeExecutionToolResultError,
                _ => null,
            };
        }
    }
}