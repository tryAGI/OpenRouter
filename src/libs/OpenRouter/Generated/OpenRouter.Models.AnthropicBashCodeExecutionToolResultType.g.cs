
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicBashCodeExecutionToolResultType
    {
        /// <summary>
        /// 
        /// </summary>
        BashCodeExecutionToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicBashCodeExecutionToolResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicBashCodeExecutionToolResultType value)
        {
            return value switch
            {
                AnthropicBashCodeExecutionToolResultType.BashCodeExecutionToolResult => "bash_code_execution_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicBashCodeExecutionToolResultType? ToEnum(string value)
        {
            return value switch
            {
                "bash_code_execution_tool_result" => AnthropicBashCodeExecutionToolResultType.BashCodeExecutionToolResult,
                _ => null,
            };
        }
    }
}