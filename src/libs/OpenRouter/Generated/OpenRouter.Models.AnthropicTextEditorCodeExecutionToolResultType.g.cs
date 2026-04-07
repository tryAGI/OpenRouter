
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicTextEditorCodeExecutionToolResultType
    {
        /// <summary>
        /// 
        /// </summary>
        TextEditorCodeExecutionToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicTextEditorCodeExecutionToolResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicTextEditorCodeExecutionToolResultType value)
        {
            return value switch
            {
                AnthropicTextEditorCodeExecutionToolResultType.TextEditorCodeExecutionToolResult => "text_editor_code_execution_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicTextEditorCodeExecutionToolResultType? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_code_execution_tool_result" => AnthropicTextEditorCodeExecutionToolResultType.TextEditorCodeExecutionToolResult,
                _ => null,
            };
        }
    }
}