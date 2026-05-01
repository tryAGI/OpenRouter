
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: web_fetch_tool_result
    /// </summary>
    public enum ORAnthropicContentBlockVariant12Type
    {
        /// <summary>
        /// web_fetch_tool_result
        /// </summary>
        WebFetchToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ORAnthropicContentBlockVariant12TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ORAnthropicContentBlockVariant12Type value)
        {
            return value switch
            {
                ORAnthropicContentBlockVariant12Type.WebFetchToolResult => "web_fetch_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ORAnthropicContentBlockVariant12Type? ToEnum(string value)
        {
            return value switch
            {
                "web_fetch_tool_result" => ORAnthropicContentBlockVariant12Type.WebFetchToolResult,
                _ => null,
            };
        }
    }
}