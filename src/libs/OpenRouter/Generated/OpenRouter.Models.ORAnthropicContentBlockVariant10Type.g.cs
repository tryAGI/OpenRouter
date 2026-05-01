
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: tool_search_tool_result
    /// </summary>
    public enum ORAnthropicContentBlockVariant10Type
    {
        /// <summary>
        /// tool_search_tool_result
        /// </summary>
        ToolSearchToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ORAnthropicContentBlockVariant10TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ORAnthropicContentBlockVariant10Type value)
        {
            return value switch
            {
                ORAnthropicContentBlockVariant10Type.ToolSearchToolResult => "tool_search_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ORAnthropicContentBlockVariant10Type? ToEnum(string value)
        {
            return value switch
            {
                "tool_search_tool_result" => ORAnthropicContentBlockVariant10Type.ToolSearchToolResult,
                _ => null,
            };
        }
    }
}