
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicBase64PdfSourceMediaType
    {
        /// <summary>
        /// 
        /// </summary>
        ApplicationPdf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicBase64PdfSourceMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicBase64PdfSourceMediaType value)
        {
            return value switch
            {
                AnthropicBase64PdfSourceMediaType.ApplicationPdf => "application/pdf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicBase64PdfSourceMediaType? ToEnum(string value)
        {
            return value switch
            {
                "application/pdf" => AnthropicBase64PdfSourceMediaType.ApplicationPdf,
                _ => null,
            };
        }
    }
}