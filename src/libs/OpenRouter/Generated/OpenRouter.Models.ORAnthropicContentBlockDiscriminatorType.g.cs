
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ORAnthropicContentBlockDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        BashCodeExecutionToolResult,
        /// <summary>
        /// 
        /// </summary>
        CodeExecutionToolResult,
        /// <summary>
        /// 
        /// </summary>
        Compaction,
        /// <summary>
        /// 
        /// </summary>
        ContainerUpload,
        /// <summary>
        /// 
        /// </summary>
        RedactedThinking,
        /// <summary>
        /// 
        /// </summary>
        ServerToolUse,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        TextEditorCodeExecutionToolResult,
        /// <summary>
        /// 
        /// </summary>
        Thinking,
        /// <summary>
        /// 
        /// </summary>
        ToolSearchToolResult,
        /// <summary>
        /// 
        /// </summary>
        ToolUse,
        /// <summary>
        /// 
        /// </summary>
        WebFetchToolResult,
        /// <summary>
        /// 
        /// </summary>
        WebSearchToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ORAnthropicContentBlockDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ORAnthropicContentBlockDiscriminatorType value)
        {
            return value switch
            {
                ORAnthropicContentBlockDiscriminatorType.BashCodeExecutionToolResult => "bash_code_execution_tool_result",
                ORAnthropicContentBlockDiscriminatorType.CodeExecutionToolResult => "code_execution_tool_result",
                ORAnthropicContentBlockDiscriminatorType.Compaction => "compaction",
                ORAnthropicContentBlockDiscriminatorType.ContainerUpload => "container_upload",
                ORAnthropicContentBlockDiscriminatorType.RedactedThinking => "redacted_thinking",
                ORAnthropicContentBlockDiscriminatorType.ServerToolUse => "server_tool_use",
                ORAnthropicContentBlockDiscriminatorType.Text => "text",
                ORAnthropicContentBlockDiscriminatorType.TextEditorCodeExecutionToolResult => "text_editor_code_execution_tool_result",
                ORAnthropicContentBlockDiscriminatorType.Thinking => "thinking",
                ORAnthropicContentBlockDiscriminatorType.ToolSearchToolResult => "tool_search_tool_result",
                ORAnthropicContentBlockDiscriminatorType.ToolUse => "tool_use",
                ORAnthropicContentBlockDiscriminatorType.WebFetchToolResult => "web_fetch_tool_result",
                ORAnthropicContentBlockDiscriminatorType.WebSearchToolResult => "web_search_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ORAnthropicContentBlockDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "bash_code_execution_tool_result" => ORAnthropicContentBlockDiscriminatorType.BashCodeExecutionToolResult,
                "code_execution_tool_result" => ORAnthropicContentBlockDiscriminatorType.CodeExecutionToolResult,
                "compaction" => ORAnthropicContentBlockDiscriminatorType.Compaction,
                "container_upload" => ORAnthropicContentBlockDiscriminatorType.ContainerUpload,
                "redacted_thinking" => ORAnthropicContentBlockDiscriminatorType.RedactedThinking,
                "server_tool_use" => ORAnthropicContentBlockDiscriminatorType.ServerToolUse,
                "text" => ORAnthropicContentBlockDiscriminatorType.Text,
                "text_editor_code_execution_tool_result" => ORAnthropicContentBlockDiscriminatorType.TextEditorCodeExecutionToolResult,
                "thinking" => ORAnthropicContentBlockDiscriminatorType.Thinking,
                "tool_search_tool_result" => ORAnthropicContentBlockDiscriminatorType.ToolSearchToolResult,
                "tool_use" => ORAnthropicContentBlockDiscriminatorType.ToolUse,
                "web_fetch_tool_result" => ORAnthropicContentBlockDiscriminatorType.WebFetchToolResult,
                "web_search_tool_result" => ORAnthropicContentBlockDiscriminatorType.WebSearchToolResult,
                _ => null,
            };
        }
    }
}