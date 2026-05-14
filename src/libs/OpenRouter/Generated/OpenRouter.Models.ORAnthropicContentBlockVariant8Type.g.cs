
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: text
    /// </summary>
    public enum ORAnthropicContentBlockVariant8Type
    {
        /// <summary>
        /// text
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ORAnthropicContentBlockVariant8TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ORAnthropicContentBlockVariant8Type value)
        {
            return value switch
            {
                ORAnthropicContentBlockVariant8Type.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ORAnthropicContentBlockVariant8Type? ToEnum(string value)
        {
            return value switch
            {
                "text" => ORAnthropicContentBlockVariant8Type.Text,
                _ => null,
            };
        }
    }
}