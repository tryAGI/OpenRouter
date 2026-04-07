
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicServerToolName
    {
        /// <summary>
        /// 
        /// </summary>
        BashCodeExecution,
        /// <summary>
        /// 
        /// </summary>
        CodeExecution,
        /// <summary>
        /// 
        /// </summary>
        TextEditorCodeExecution,
        /// <summary>
        /// 
        /// </summary>
        ToolSearchToolBm25,
        /// <summary>
        /// 
        /// </summary>
        ToolSearchToolRegex,
        /// <summary>
        /// 
        /// </summary>
        WebFetch,
        /// <summary>
        /// 
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicServerToolNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicServerToolName value)
        {
            return value switch
            {
                AnthropicServerToolName.BashCodeExecution => "bash_code_execution",
                AnthropicServerToolName.CodeExecution => "code_execution",
                AnthropicServerToolName.TextEditorCodeExecution => "text_editor_code_execution",
                AnthropicServerToolName.ToolSearchToolBm25 => "tool_search_tool_bm25",
                AnthropicServerToolName.ToolSearchToolRegex => "tool_search_tool_regex",
                AnthropicServerToolName.WebFetch => "web_fetch",
                AnthropicServerToolName.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicServerToolName? ToEnum(string value)
        {
            return value switch
            {
                "bash_code_execution" => AnthropicServerToolName.BashCodeExecution,
                "code_execution" => AnthropicServerToolName.CodeExecution,
                "text_editor_code_execution" => AnthropicServerToolName.TextEditorCodeExecution,
                "tool_search_tool_bm25" => AnthropicServerToolName.ToolSearchToolBm25,
                "tool_search_tool_regex" => AnthropicServerToolName.ToolSearchToolRegex,
                "web_fetch" => AnthropicServerToolName.WebFetch,
                "web_search" => AnthropicServerToolName.WebSearch,
                _ => null,
            };
        }
    }
}