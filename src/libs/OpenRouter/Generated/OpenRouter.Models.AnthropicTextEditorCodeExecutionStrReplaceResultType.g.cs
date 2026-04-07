
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicTextEditorCodeExecutionStrReplaceResultType
    {
        /// <summary>
        /// 
        /// </summary>
        TextEditorCodeExecutionStrReplaceResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicTextEditorCodeExecutionStrReplaceResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicTextEditorCodeExecutionStrReplaceResultType value)
        {
            return value switch
            {
                AnthropicTextEditorCodeExecutionStrReplaceResultType.TextEditorCodeExecutionStrReplaceResult => "text_editor_code_execution_str_replace_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicTextEditorCodeExecutionStrReplaceResultType? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_code_execution_str_replace_result" => AnthropicTextEditorCodeExecutionStrReplaceResultType.TextEditorCodeExecutionStrReplaceResult,
                _ => null,
            };
        }
    }
}