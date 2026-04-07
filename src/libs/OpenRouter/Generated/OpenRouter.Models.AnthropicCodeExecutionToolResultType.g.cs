
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicCodeExecutionToolResultType
    {
        /// <summary>
        /// 
        /// </summary>
        CodeExecutionToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicCodeExecutionToolResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicCodeExecutionToolResultType value)
        {
            return value switch
            {
                AnthropicCodeExecutionToolResultType.CodeExecutionToolResult => "code_execution_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicCodeExecutionToolResultType? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_tool_result" => AnthropicCodeExecutionToolResultType.CodeExecutionToolResult,
                _ => null,
            };
        }
    }
}