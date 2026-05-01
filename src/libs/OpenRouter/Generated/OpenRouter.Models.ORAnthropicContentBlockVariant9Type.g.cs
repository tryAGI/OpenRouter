
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: thinking
    /// </summary>
    public enum ORAnthropicContentBlockVariant9Type
    {
        /// <summary>
        /// thinking
        /// </summary>
        Thinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ORAnthropicContentBlockVariant9TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ORAnthropicContentBlockVariant9Type value)
        {
            return value switch
            {
                ORAnthropicContentBlockVariant9Type.Thinking => "thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ORAnthropicContentBlockVariant9Type? ToEnum(string value)
        {
            return value switch
            {
                "thinking" => ORAnthropicContentBlockVariant9Type.Thinking,
                _ => null,
            };
        }
    }
}