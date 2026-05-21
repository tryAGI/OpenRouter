
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputItemsDiscriminatorType
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
        ComputerCall,
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
        Openrouter_applyPatch,
        /// <summary>
        /// 
        /// </summary>
        Openrouter_bash,
        /// <summary>
        /// 
        /// </summary>
        Openrouter_browserUse,
        /// <summary>
        /// 
        /// </summary>
        Openrouter_codeInterpreter,
        /// <summary>
        /// 
        /// </summary>
        Openrouter_datetime,
        /// <summary>
        /// 
        /// </summary>
        Openrouter_experimentalSearchModels,
        /// <summary>
        /// 
        /// </summary>
        Openrouter_fileSearch,
        /// <summary>
        /// 
        /// </summary>
        Openrouter_fusion,
        /// <summary>
        /// 
        /// </summary>
        Openrouter_imageGeneration,
        /// <summary>
        /// 
        /// </summary>
        Openrouter_mcp,
        /// <summary>
        /// 
        /// </summary>
        Openrouter_memory,
        /// <summary>
        /// 
        /// </summary>
        Openrouter_textEditor,
        /// <summary>
        /// 
        /// </summary>
        Openrouter_toolSearch,
        /// <summary>
        /// 
        /// </summary>
        Openrouter_webFetch,
        /// <summary>
        /// 
        /// </summary>
        Openrouter_webSearch,
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
    public static class OutputItemsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemsDiscriminatorType value)
        {
            return value switch
            {
                OutputItemsDiscriminatorType.ApplyPatchCall => "apply_patch_call",
                OutputItemsDiscriminatorType.CodeInterpreterCall => "code_interpreter_call",
                OutputItemsDiscriminatorType.ComputerCall => "computer_call",
                OutputItemsDiscriminatorType.CustomToolCall => "custom_tool_call",
                OutputItemsDiscriminatorType.FileSearchCall => "file_search_call",
                OutputItemsDiscriminatorType.FunctionCall => "function_call",
                OutputItemsDiscriminatorType.ImageGenerationCall => "image_generation_call",
                OutputItemsDiscriminatorType.Message => "message",
                OutputItemsDiscriminatorType.Openrouter_applyPatch => "openrouter:apply_patch",
                OutputItemsDiscriminatorType.Openrouter_bash => "openrouter:bash",
                OutputItemsDiscriminatorType.Openrouter_browserUse => "openrouter:browser_use",
                OutputItemsDiscriminatorType.Openrouter_codeInterpreter => "openrouter:code_interpreter",
                OutputItemsDiscriminatorType.Openrouter_datetime => "openrouter:datetime",
                OutputItemsDiscriminatorType.Openrouter_experimentalSearchModels => "openrouter:experimental__search_models",
                OutputItemsDiscriminatorType.Openrouter_fileSearch => "openrouter:file_search",
                OutputItemsDiscriminatorType.Openrouter_fusion => "openrouter:fusion",
                OutputItemsDiscriminatorType.Openrouter_imageGeneration => "openrouter:image_generation",
                OutputItemsDiscriminatorType.Openrouter_mcp => "openrouter:mcp",
                OutputItemsDiscriminatorType.Openrouter_memory => "openrouter:memory",
                OutputItemsDiscriminatorType.Openrouter_textEditor => "openrouter:text_editor",
                OutputItemsDiscriminatorType.Openrouter_toolSearch => "openrouter:tool_search",
                OutputItemsDiscriminatorType.Openrouter_webFetch => "openrouter:web_fetch",
                OutputItemsDiscriminatorType.Openrouter_webSearch => "openrouter:web_search",
                OutputItemsDiscriminatorType.Reasoning => "reasoning",
                OutputItemsDiscriminatorType.WebSearchCall => "web_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apply_patch_call" => OutputItemsDiscriminatorType.ApplyPatchCall,
                "code_interpreter_call" => OutputItemsDiscriminatorType.CodeInterpreterCall,
                "computer_call" => OutputItemsDiscriminatorType.ComputerCall,
                "custom_tool_call" => OutputItemsDiscriminatorType.CustomToolCall,
                "file_search_call" => OutputItemsDiscriminatorType.FileSearchCall,
                "function_call" => OutputItemsDiscriminatorType.FunctionCall,
                "image_generation_call" => OutputItemsDiscriminatorType.ImageGenerationCall,
                "message" => OutputItemsDiscriminatorType.Message,
                "openrouter:apply_patch" => OutputItemsDiscriminatorType.Openrouter_applyPatch,
                "openrouter:bash" => OutputItemsDiscriminatorType.Openrouter_bash,
                "openrouter:browser_use" => OutputItemsDiscriminatorType.Openrouter_browserUse,
                "openrouter:code_interpreter" => OutputItemsDiscriminatorType.Openrouter_codeInterpreter,
                "openrouter:datetime" => OutputItemsDiscriminatorType.Openrouter_datetime,
                "openrouter:experimental__search_models" => OutputItemsDiscriminatorType.Openrouter_experimentalSearchModels,
                "openrouter:file_search" => OutputItemsDiscriminatorType.Openrouter_fileSearch,
                "openrouter:fusion" => OutputItemsDiscriminatorType.Openrouter_fusion,
                "openrouter:image_generation" => OutputItemsDiscriminatorType.Openrouter_imageGeneration,
                "openrouter:mcp" => OutputItemsDiscriminatorType.Openrouter_mcp,
                "openrouter:memory" => OutputItemsDiscriminatorType.Openrouter_memory,
                "openrouter:text_editor" => OutputItemsDiscriminatorType.Openrouter_textEditor,
                "openrouter:tool_search" => OutputItemsDiscriminatorType.Openrouter_toolSearch,
                "openrouter:web_fetch" => OutputItemsDiscriminatorType.Openrouter_webFetch,
                "openrouter:web_search" => OutputItemsDiscriminatorType.Openrouter_webSearch,
                "reasoning" => OutputItemsDiscriminatorType.Reasoning,
                "web_search_call" => OutputItemsDiscriminatorType.WebSearchCall,
                _ => null,
            };
        }
    }
}