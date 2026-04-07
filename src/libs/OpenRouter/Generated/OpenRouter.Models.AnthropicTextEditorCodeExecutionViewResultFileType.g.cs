
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicTextEditorCodeExecutionViewResultFileType
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Pdf,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicTextEditorCodeExecutionViewResultFileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicTextEditorCodeExecutionViewResultFileType value)
        {
            return value switch
            {
                AnthropicTextEditorCodeExecutionViewResultFileType.Image => "image",
                AnthropicTextEditorCodeExecutionViewResultFileType.Pdf => "pdf",
                AnthropicTextEditorCodeExecutionViewResultFileType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicTextEditorCodeExecutionViewResultFileType? ToEnum(string value)
        {
            return value switch
            {
                "image" => AnthropicTextEditorCodeExecutionViewResultFileType.Image,
                "pdf" => AnthropicTextEditorCodeExecutionViewResultFileType.Pdf,
                "text" => AnthropicTextEditorCodeExecutionViewResultFileType.Text,
                _ => null,
            };
        }
    }
}