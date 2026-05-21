
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: tool_use
    /// </summary>
    public enum ORAnthropicContentBlockVariant12Type
    {
        /// <summary>
        /// tool_use
        /// </summary>
        ToolUse,
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
                ORAnthropicContentBlockVariant12Type.ToolUse => "tool_use",
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
                "tool_use" => ORAnthropicContentBlockVariant12Type.ToolUse,
                _ => null,
            };
        }
    }
}