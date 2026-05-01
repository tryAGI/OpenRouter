
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: bash_code_execution_tool_result
    /// </summary>
    public enum ORAnthropicContentBlockVariant1Type
    {
        /// <summary>
        /// bash_code_execution_tool_result
        /// </summary>
        BashCodeExecutionToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ORAnthropicContentBlockVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ORAnthropicContentBlockVariant1Type value)
        {
            return value switch
            {
                ORAnthropicContentBlockVariant1Type.BashCodeExecutionToolResult => "bash_code_execution_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ORAnthropicContentBlockVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "bash_code_execution_tool_result" => ORAnthropicContentBlockVariant1Type.BashCodeExecutionToolResult,
                _ => null,
            };
        }
    }
}