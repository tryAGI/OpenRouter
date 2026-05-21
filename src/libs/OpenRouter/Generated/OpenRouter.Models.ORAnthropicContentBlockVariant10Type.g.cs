
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: thinking
    /// </summary>
    public enum ORAnthropicContentBlockVariant10Type
    {
        /// <summary>
        /// thinking
        /// </summary>
        Thinking,
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
                ORAnthropicContentBlockVariant10Type.Thinking => "thinking",
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
                "thinking" => ORAnthropicContentBlockVariant10Type.Thinking,
                _ => null,
            };
        }
    }
}