
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: server_tool_use
    /// </summary>
    public enum ORAnthropicContentBlockVariant6Type
    {
        /// <summary>
        /// server_tool_use
        /// </summary>
        ServerToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ORAnthropicContentBlockVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ORAnthropicContentBlockVariant6Type value)
        {
            return value switch
            {
                ORAnthropicContentBlockVariant6Type.ServerToolUse => "server_tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ORAnthropicContentBlockVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "server_tool_use" => ORAnthropicContentBlockVariant6Type.ServerToolUse,
                _ => null,
            };
        }
    }
}