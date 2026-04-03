
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicBase64ImageSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Base64,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicBase64ImageSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicBase64ImageSourceType value)
        {
            return value switch
            {
                AnthropicBase64ImageSourceType.Base64 => "base64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicBase64ImageSourceType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => AnthropicBase64ImageSourceType.Base64,
                _ => null,
            };
        }
    }
}