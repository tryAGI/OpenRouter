
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: redacted_thinking
    /// </summary>
    public enum ORAnthropicContentBlockVariant5Type
    {
        /// <summary>
        /// redacted_thinking
        /// </summary>
        RedactedThinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ORAnthropicContentBlockVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ORAnthropicContentBlockVariant5Type value)
        {
            return value switch
            {
                ORAnthropicContentBlockVariant5Type.RedactedThinking => "redacted_thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ORAnthropicContentBlockVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "redacted_thinking" => ORAnthropicContentBlockVariant5Type.RedactedThinking,
                _ => null,
            };
        }
    }
}