
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: code_execution_tool_result
    /// </summary>
    public enum ORAnthropicContentBlockVariant3Type
    {
        /// <summary>
        /// code_execution_tool_result
        /// </summary>
        CodeExecutionToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ORAnthropicContentBlockVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ORAnthropicContentBlockVariant3Type value)
        {
            return value switch
            {
                ORAnthropicContentBlockVariant3Type.CodeExecutionToolResult => "code_execution_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ORAnthropicContentBlockVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "code_execution_tool_result" => ORAnthropicContentBlockVariant3Type.CodeExecutionToolResult,
                _ => null,
            };
        }
    }
}