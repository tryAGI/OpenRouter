
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: tool_search_tool_result
    /// </summary>
    public enum ORAnthropicContentBlockVariant11Type
    {
        /// <summary>
        /// tool_search_tool_result
        /// </summary>
        ToolSearchToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ORAnthropicContentBlockVariant11TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ORAnthropicContentBlockVariant11Type value)
        {
            return value switch
            {
                ORAnthropicContentBlockVariant11Type.ToolSearchToolResult => "tool_search_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ORAnthropicContentBlockVariant11Type? ToEnum(string value)
        {
            return value switch
            {
                "tool_search_tool_result" => ORAnthropicContentBlockVariant11Type.ToolSearchToolResult,
                _ => null,
            };
        }
    }
}