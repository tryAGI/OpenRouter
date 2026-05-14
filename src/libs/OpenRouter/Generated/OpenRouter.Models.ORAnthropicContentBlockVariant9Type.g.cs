
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: text_editor_code_execution_tool_result
    /// </summary>
    public enum ORAnthropicContentBlockVariant9Type
    {
        /// <summary>
        /// text_editor_code_execution_tool_result
        /// </summary>
        TextEditorCodeExecutionToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ORAnthropicContentBlockVariant9TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ORAnthropicContentBlockVariant9Type value)
        {
            return value switch
            {
                ORAnthropicContentBlockVariant9Type.TextEditorCodeExecutionToolResult => "text_editor_code_execution_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ORAnthropicContentBlockVariant9Type? ToEnum(string value)
        {
            return value switch
            {
                "text_editor_code_execution_tool_result" => ORAnthropicContentBlockVariant9Type.TextEditorCodeExecutionToolResult,
                _ => null,
            };
        }
    }
}