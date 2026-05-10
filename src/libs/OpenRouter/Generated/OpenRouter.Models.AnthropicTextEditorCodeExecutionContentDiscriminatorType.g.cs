
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicTextEditorCodeExecutionContentDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        TextEditorCodeExecutionCreateResult,
        /// <summary>
        /// 
        /// </summary>
        TextEditorCodeExecutionStrReplaceResult,
        /// <summary>
        /// 
        /// </summary>
        TextEditorCodeExecutionToolResultError,
        /// <summary>
        /// 
        /// </summary>
        TextEditorCodeExecutionViewResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicTextEditorCodeExecutionContentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicTextEditorCodeExecutionContentDiscriminatorType value)
        {
            return value switch
            {
                AnthropicTextEditorCodeExecutionContentDiscriminatorType.TextEditorCodeExecutionCreateResult => "text_editor_code_execution_create_result",
                AnthropicTextEditorCodeExecutionContentDiscriminatorType.TextEditorCodeExecutionStrReplaceResult => "text_editor_code_execution_str_replace_result",
                AnthropicTextEditorCodeExecutionContentDiscriminatorType.TextEditorCodeExecutionToolResultError => "text_editor_code_execution_tool_result_error",
                AnthropicTextEditorCodeExecutionContentDiscriminatorType.TextEditorCodeExecutionViewResult => "text_editor_code_execution_view_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicTextEditorCodeExecutionContentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_code_execution_create_result" => AnthropicTextEditorCodeExecutionContentDiscriminatorType.TextEditorCodeExecutionCreateResult,
                "text_editor_code_execution_str_replace_result" => AnthropicTextEditorCodeExecutionContentDiscriminatorType.TextEditorCodeExecutionStrReplaceResult,
                "text_editor_code_execution_tool_result_error" => AnthropicTextEditorCodeExecutionContentDiscriminatorType.TextEditorCodeExecutionToolResultError,
                "text_editor_code_execution_view_result" => AnthropicTextEditorCodeExecutionContentDiscriminatorType.TextEditorCodeExecutionViewResult,
                _ => null,
            };
        }
    }
}