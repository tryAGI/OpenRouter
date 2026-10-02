
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputItemAddedEventItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        ApplyPatchCall,
        /// <summary>
        ///
        /// </summary>
        CodeInterpreterCall,
        /// <summary>
        ///
        /// </summary>
        CustomToolCall,
        /// <summary>
        ///
        /// </summary>
        FileSearchCall,
        /// <summary>
        ///
        /// </summary>
        FunctionCall,
        /// <summary>
        ///
        /// </summary>
        ImageGenerationCall,
        /// <summary>
        ///
        /// </summary>
        Message,
        /// <summary>
        ///
        /// </summary>
        Reasoning,
        /// <summary>
        ///
        /// </summary>
        WebSearchCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemAddedEventItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemAddedEventItemDiscriminatorType value)
        {
            return value switch
            {
                OutputItemAddedEventItemDiscriminatorType.ApplyPatchCall => "apply_patch_call",
                OutputItemAddedEventItemDiscriminatorType.CodeInterpreterCall => "code_interpreter_call",
                OutputItemAddedEventItemDiscriminatorType.CustomToolCall => "custom_tool_call",
                OutputItemAddedEventItemDiscriminatorType.FileSearchCall => "file_search_call",
                OutputItemAddedEventItemDiscriminatorType.FunctionCall => "function_call",
                OutputItemAddedEventItemDiscriminatorType.ImageGenerationCall => "image_generation_call",
                OutputItemAddedEventItemDiscriminatorType.Message => "message",
                OutputItemAddedEventItemDiscriminatorType.Reasoning => "reasoning",
                OutputItemAddedEventItemDiscriminatorType.WebSearchCall => "web_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemAddedEventItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch_call" => OutputItemAddedEventItemDiscriminatorType.ApplyPatchCall,
                "code_interpreter_call" => OutputItemAddedEventItemDiscriminatorType.CodeInterpreterCall,
                "custom_tool_call" => OutputItemAddedEventItemDiscriminatorType.CustomToolCall,
                "file_search_call" => OutputItemAddedEventItemDiscriminatorType.FileSearchCall,
                "function_call" => OutputItemAddedEventItemDiscriminatorType.FunctionCall,
                "image_generation_call" => OutputItemAddedEventItemDiscriminatorType.ImageGenerationCall,
                "message" => OutputItemAddedEventItemDiscriminatorType.Message,
                "reasoning" => OutputItemAddedEventItemDiscriminatorType.Reasoning,
                "web_search_call" => OutputItemAddedEventItemDiscriminatorType.WebSearchCall,
                _ => null,
            };
        }
    }
}