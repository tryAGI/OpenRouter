
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputItemDoneEventItemDiscriminatorType
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
    public static class OutputItemDoneEventItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemDoneEventItemDiscriminatorType value)
        {
            return value switch
            {
                OutputItemDoneEventItemDiscriminatorType.ApplyPatchCall => "apply_patch_call",
                OutputItemDoneEventItemDiscriminatorType.CodeInterpreterCall => "code_interpreter_call",
                OutputItemDoneEventItemDiscriminatorType.CustomToolCall => "custom_tool_call",
                OutputItemDoneEventItemDiscriminatorType.FileSearchCall => "file_search_call",
                OutputItemDoneEventItemDiscriminatorType.FunctionCall => "function_call",
                OutputItemDoneEventItemDiscriminatorType.ImageGenerationCall => "image_generation_call",
                OutputItemDoneEventItemDiscriminatorType.Message => "message",
                OutputItemDoneEventItemDiscriminatorType.Reasoning => "reasoning",
                OutputItemDoneEventItemDiscriminatorType.WebSearchCall => "web_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemDoneEventItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch_call" => OutputItemDoneEventItemDiscriminatorType.ApplyPatchCall,
                "code_interpreter_call" => OutputItemDoneEventItemDiscriminatorType.CodeInterpreterCall,
                "custom_tool_call" => OutputItemDoneEventItemDiscriminatorType.CustomToolCall,
                "file_search_call" => OutputItemDoneEventItemDiscriminatorType.FileSearchCall,
                "function_call" => OutputItemDoneEventItemDiscriminatorType.FunctionCall,
                "image_generation_call" => OutputItemDoneEventItemDiscriminatorType.ImageGenerationCall,
                "message" => OutputItemDoneEventItemDiscriminatorType.Message,
                "reasoning" => OutputItemDoneEventItemDiscriminatorType.Reasoning,
                "web_search_call" => OutputItemDoneEventItemDiscriminatorType.WebSearchCall,
                _ => null,
            };
        }
    }
}