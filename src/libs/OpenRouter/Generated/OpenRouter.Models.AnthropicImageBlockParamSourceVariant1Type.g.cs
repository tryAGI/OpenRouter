
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: base64
    /// </summary>
    public enum AnthropicImageBlockParamSourceVariant1Type
    {
        /// <summary>
        /// base64
        /// </summary>
        Base64,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicImageBlockParamSourceVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicImageBlockParamSourceVariant1Type value)
        {
            return value switch
            {
                AnthropicImageBlockParamSourceVariant1Type.Base64 => "base64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicImageBlockParamSourceVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "base64" => AnthropicImageBlockParamSourceVariant1Type.Base64,
                _ => null,
            };
        }
    }
}