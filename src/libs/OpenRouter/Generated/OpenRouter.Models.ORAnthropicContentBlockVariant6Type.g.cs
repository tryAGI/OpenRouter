
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: redacted_thinking
    /// </summary>
    public enum ORAnthropicContentBlockVariant6Type
    {
        /// <summary>
        /// redacted_thinking
        /// </summary>
        RedactedThinking,
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
                ORAnthropicContentBlockVariant6Type.RedactedThinking => "redacted_thinking",
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
                "redacted_thinking" => ORAnthropicContentBlockVariant6Type.RedactedThinking,
                _ => null,
            };
        }
    }
}