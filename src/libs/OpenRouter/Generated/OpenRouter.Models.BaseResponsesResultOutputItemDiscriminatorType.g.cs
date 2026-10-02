
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BaseResponsesResultOutputItemDiscriminatorType
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
    public static class BaseResponsesResultOutputItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseResponsesResultOutputItemDiscriminatorType value)
        {
            return value switch
            {
                BaseResponsesResultOutputItemDiscriminatorType.ApplyPatchCall => "apply_patch_call",
                BaseResponsesResultOutputItemDiscriminatorType.CodeInterpreterCall => "code_interpreter_call",
                BaseResponsesResultOutputItemDiscriminatorType.CustomToolCall => "custom_tool_call",
                BaseResponsesResultOutputItemDiscriminatorType.FileSearchCall => "file_search_call",
                BaseResponsesResultOutputItemDiscriminatorType.FunctionCall => "function_call",
                BaseResponsesResultOutputItemDiscriminatorType.ImageGenerationCall => "image_generation_call",
                BaseResponsesResultOutputItemDiscriminatorType.Message => "message",
                BaseResponsesResultOutputItemDiscriminatorType.Reasoning => "reasoning",
                BaseResponsesResultOutputItemDiscriminatorType.WebSearchCall => "web_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseResponsesResultOutputItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch_call" => BaseResponsesResultOutputItemDiscriminatorType.ApplyPatchCall,
                "code_interpreter_call" => BaseResponsesResultOutputItemDiscriminatorType.CodeInterpreterCall,
                "custom_tool_call" => BaseResponsesResultOutputItemDiscriminatorType.CustomToolCall,
                "file_search_call" => BaseResponsesResultOutputItemDiscriminatorType.FileSearchCall,
                "function_call" => BaseResponsesResultOutputItemDiscriminatorType.FunctionCall,
                "image_generation_call" => BaseResponsesResultOutputItemDiscriminatorType.ImageGenerationCall,
                "message" => BaseResponsesResultOutputItemDiscriminatorType.Message,
                "reasoning" => BaseResponsesResultOutputItemDiscriminatorType.Reasoning,
                "web_search_call" => BaseResponsesResultOutputItemDiscriminatorType.WebSearchCall,
                _ => null,
            };
        }
    }
}