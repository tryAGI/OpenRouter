
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicCodeExecutionOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        CodeExecutionOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicCodeExecutionOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicCodeExecutionOutputType value)
        {
            return value switch
            {
                AnthropicCodeExecutionOutputType.CodeExecutionOutput => "code_execution_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicCodeExecutionOutputType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_output" => AnthropicCodeExecutionOutputType.CodeExecutionOutput,
                _ => null,
            };
        }
    }
}