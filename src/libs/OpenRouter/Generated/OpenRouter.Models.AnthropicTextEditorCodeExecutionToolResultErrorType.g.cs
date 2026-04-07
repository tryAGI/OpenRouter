
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicTextEditorCodeExecutionToolResultErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        TextEditorCodeExecutionToolResultError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicTextEditorCodeExecutionToolResultErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicTextEditorCodeExecutionToolResultErrorType value)
        {
            return value switch
            {
                AnthropicTextEditorCodeExecutionToolResultErrorType.TextEditorCodeExecutionToolResultError => "text_editor_code_execution_tool_result_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicTextEditorCodeExecutionToolResultErrorType? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_code_execution_tool_result_error" => AnthropicTextEditorCodeExecutionToolResultErrorType.TextEditorCodeExecutionToolResultError,
                _ => null,
            };
        }
    }
}