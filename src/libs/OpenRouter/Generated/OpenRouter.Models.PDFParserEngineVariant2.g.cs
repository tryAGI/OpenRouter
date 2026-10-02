
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum PDFParserEngineVariant2
    {
        /// <summary>
        ///
        /// </summary>
        PdfText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PDFParserEngineVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PDFParserEngineVariant2 value)
        {
            return value switch
            {
                PDFParserEngineVariant2.PdfText => "pdf-text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PDFParserEngineVariant2? ToEnum(string value)
        {
            return value switch
            {
                "pdf-text" => PDFParserEngineVariant2.PdfText,
                _ => null,
            };
        }
    }
}