
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: bash_code_execution_tool_result
    /// </summary>
    public enum ORAnthropicContentBlockVariant2Type
    {
        /// <summary>
        /// bash_code_execution_tool_result
        /// </summary>
        BashCodeExecutionToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ORAnthropicContentBlockVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ORAnthropicContentBlockVariant2Type value)
        {
            return value switch
            {
                ORAnthropicContentBlockVariant2Type.BashCodeExecutionToolResult => "bash_code_execution_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ORAnthropicContentBlockVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "bash_code_execution_tool_result" => ORAnthropicContentBlockVariant2Type.BashCodeExecutionToolResult,
                _ => null,
            };
        }
    }
}