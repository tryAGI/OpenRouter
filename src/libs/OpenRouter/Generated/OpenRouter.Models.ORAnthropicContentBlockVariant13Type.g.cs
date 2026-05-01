
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: web_search_tool_result
    /// </summary>
    public enum ORAnthropicContentBlockVariant13Type
    {
        /// <summary>
        /// web_search_tool_result
        /// </summary>
        WebSearchToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ORAnthropicContentBlockVariant13TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ORAnthropicContentBlockVariant13Type value)
        {
            return value switch
            {
                ORAnthropicContentBlockVariant13Type.WebSearchToolResult => "web_search_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ORAnthropicContentBlockVariant13Type? ToEnum(string value)
        {
            return value switch
            {
                "web_search_tool_result" => ORAnthropicContentBlockVariant13Type.WebSearchToolResult,
                _ => null,
            };
        }
    }
}