
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicCodeExecutionResultType
    {
        /// <summary>
        /// 
        /// </summary>
        CodeExecutionResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicCodeExecutionResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicCodeExecutionResultType value)
        {
            return value switch
            {
                AnthropicCodeExecutionResultType.CodeExecutionResult => "code_execution_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicCodeExecutionResultType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_result" => AnthropicCodeExecutionResultType.CodeExecutionResult,
                _ => null,
            };
        }
    }
}