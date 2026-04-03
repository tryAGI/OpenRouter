
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicBase64PdfSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Base64,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicBase64PdfSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicBase64PdfSourceType value)
        {
            return value switch
            {
                AnthropicBase64PdfSourceType.Base64 => "base64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicBase64PdfSourceType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => AnthropicBase64PdfSourceType.Base64,
                _ => null,
            };
        }
    }
}