
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicImageBlockParamSourceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Base64,
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicImageBlockParamSourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicImageBlockParamSourceDiscriminatorType value)
        {
            return value switch
            {
                AnthropicImageBlockParamSourceDiscriminatorType.Base64 => "base64",
                AnthropicImageBlockParamSourceDiscriminatorType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicImageBlockParamSourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => AnthropicImageBlockParamSourceDiscriminatorType.Base64,
                "url" => AnthropicImageBlockParamSourceDiscriminatorType.Url,
                _ => null,
            };
        }
    }
}