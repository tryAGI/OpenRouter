
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: text
    /// </summary>
    public enum ORAnthropicContentBlockVariant7Type
    {
        /// <summary>
        /// text
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ORAnthropicContentBlockVariant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ORAnthropicContentBlockVariant7Type value)
        {
            return value switch
            {
                ORAnthropicContentBlockVariant7Type.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ORAnthropicContentBlockVariant7Type? ToEnum(string value)
        {
            return value switch
            {
                "text" => ORAnthropicContentBlockVariant7Type.Text,
                _ => null,
            };
        }
    }
}