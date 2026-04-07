
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicTextEditorCodeExecutionViewResultType
    {
        /// <summary>
        /// 
        /// </summary>
        TextEditorCodeExecutionViewResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicTextEditorCodeExecutionViewResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicTextEditorCodeExecutionViewResultType value)
        {
            return value switch
            {
                AnthropicTextEditorCodeExecutionViewResultType.TextEditorCodeExecutionViewResult => "text_editor_code_execution_view_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicTextEditorCodeExecutionViewResultType? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_code_execution_view_result" => AnthropicTextEditorCodeExecutionViewResultType.TextEditorCodeExecutionViewResult,
                _ => null,
            };
        }
    }
}