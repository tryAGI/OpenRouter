
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum AlignmentResponsesRejectedItemDiscriminatorType
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
    public static class AlignmentResponsesRejectedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlignmentResponsesRejectedItemDiscriminatorType value)
        {
            return value switch
            {
                AlignmentResponsesRejectedItemDiscriminatorType.ApplyPatchCall => "apply_patch_call",
                AlignmentResponsesRejectedItemDiscriminatorType.CodeInterpreterCall => "code_interpreter_call",
                AlignmentResponsesRejectedItemDiscriminatorType.CustomToolCall => "custom_tool_call",
                AlignmentResponsesRejectedItemDiscriminatorType.FileSearchCall => "file_search_call",
                AlignmentResponsesRejectedItemDiscriminatorType.FunctionCall => "function_call",
                AlignmentResponsesRejectedItemDiscriminatorType.ImageGenerationCall => "image_generation_call",
                AlignmentResponsesRejectedItemDiscriminatorType.Message => "message",
                AlignmentResponsesRejectedItemDiscriminatorType.Reasoning => "reasoning",
                AlignmentResponsesRejectedItemDiscriminatorType.WebSearchCall => "web_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlignmentResponsesRejectedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch_call" => AlignmentResponsesRejectedItemDiscriminatorType.ApplyPatchCall,
                "code_interpreter_call" => AlignmentResponsesRejectedItemDiscriminatorType.CodeInterpreterCall,
                "custom_tool_call" => AlignmentResponsesRejectedItemDiscriminatorType.CustomToolCall,
                "file_search_call" => AlignmentResponsesRejectedItemDiscriminatorType.FileSearchCall,
                "function_call" => AlignmentResponsesRejectedItemDiscriminatorType.FunctionCall,
                "image_generation_call" => AlignmentResponsesRejectedItemDiscriminatorType.ImageGenerationCall,
                "message" => AlignmentResponsesRejectedItemDiscriminatorType.Message,
                "reasoning" => AlignmentResponsesRejectedItemDiscriminatorType.Reasoning,
                "web_search_call" => AlignmentResponsesRejectedItemDiscriminatorType.WebSearchCall,
                _ => null,
            };
        }
    }
}