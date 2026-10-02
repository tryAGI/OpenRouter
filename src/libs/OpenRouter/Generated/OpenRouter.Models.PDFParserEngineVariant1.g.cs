
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct PDFParserEngineVariant1 : global::System.IEquatable<PDFParserEngineVariant1>
    {
        /// <summary>
        ///
        /// </summary>
        public PDFParserEngineVariant1(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        ///
        /// </summary>
        public static PDFParserEngineVariant1 CloudflareAi { get; } = new("cloudflare-ai");

        /// <summary>
        ///
        /// </summary>
        public static PDFParserEngineVariant1 MistralOcr { get; } = new("mistral-ocr");

        /// <summary>
        ///
        /// </summary>
        public static PDFParserEngineVariant1 Native { get; } = new("native");
        /// <summary>
        ///
        /// </summary>
        public static PDFParserEngineVariant1 FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "cloudflare-ai" => CloudflareAi,
                "mistral-ocr" => MistralOcr,
                "native" => Native,
                _ => new PDFParserEngineVariant1(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "cloudflare-ai" => true,
            "mistral-ocr" => true,
            "native" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(PDFParserEngineVariant1 other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PDFParserEngineVariant1 other && Equals(other);
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            return global::System.StringComparer.Ordinal.GetHashCode(Value ?? string.Empty);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PDFParserEngineVariant1 left, PDFParserEngineVariant1 right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PDFParserEngineVariant1 left, PDFParserEngineVariant1 right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PDFParserEngineVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PDFParserEngineVariant1 value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PDFParserEngineVariant1? ToEnum(string value)
        {
            return PDFParserEngineVariant1.FromValue(value);
        }
    }
}