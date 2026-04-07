
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicTextEditorCodeExecutionCreateResultType
    {
        /// <summary>
        /// 
        /// </summary>
        TextEditorCodeExecutionCreateResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicTextEditorCodeExecutionCreateResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicTextEditorCodeExecutionCreateResultType value)
        {
            return value switch
            {
                AnthropicTextEditorCodeExecutionCreateResultType.TextEditorCodeExecutionCreateResult => "text_editor_code_execution_create_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicTextEditorCodeExecutionCreateResultType? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_code_execution_create_result" => AnthropicTextEditorCodeExecutionCreateResultType.TextEditorCodeExecutionCreateResult,
                _ => null,
            };
        }
    }
}