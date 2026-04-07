
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicBashCodeExecutionResultType
    {
        /// <summary>
        /// 
        /// </summary>
        BashCodeExecutionResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicBashCodeExecutionResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicBashCodeExecutionResultType value)
        {
            return value switch
            {
                AnthropicBashCodeExecutionResultType.BashCodeExecutionResult => "bash_code_execution_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicBashCodeExecutionResultType? ToEnum(string value)
        {
            return value switch
            {
                "bash_code_execution_result" => AnthropicBashCodeExecutionResultType.BashCodeExecutionResult,
                _ => null,
            };
        }
    }
}