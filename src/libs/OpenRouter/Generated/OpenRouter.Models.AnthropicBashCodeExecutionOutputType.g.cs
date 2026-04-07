
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicBashCodeExecutionOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        BashCodeExecutionOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicBashCodeExecutionOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicBashCodeExecutionOutputType value)
        {
            return value switch
            {
                AnthropicBashCodeExecutionOutputType.BashCodeExecutionOutput => "bash_code_execution_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicBashCodeExecutionOutputType? ToEnum(string value)
        {
            return value switch
            {
                "bash_code_execution_output" => AnthropicBashCodeExecutionOutputType.BashCodeExecutionOutput,
                _ => null,
            };
        }
    }
}