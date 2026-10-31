
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ExtractionAssetFormat : global::System.IEquatable<ExtractionAssetFormat>
    {
        /// <summary>
        ///
        /// </summary>
        public ExtractionAssetFormat(string value)
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
        public static ExtractionAssetFormat Jpeg { get; } = new("jpeg");

        /// <summary>
        ///
        /// </summary>
        public static ExtractionAssetFormat Jpg { get; } = new("jpg");

        /// <summary>
        ///
        /// </summary>
        public static ExtractionAssetFormat Pdf { get; } = new("pdf");

        /// <summary>
        ///
        /// </summary>
        public static ExtractionAssetFormat Png { get; } = new("png");
        /// <summary>
        ///
        /// </summary>
        public static ExtractionAssetFormat FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "jpeg" => Jpeg,
                "jpg" => Jpg,
                "pdf" => Pdf,
                "png" => Png,
                _ => new ExtractionAssetFormat(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "jpeg" => true,
            "jpg" => true,
            "pdf" => true,
            "png" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ExtractionAssetFormat other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ExtractionAssetFormat other && Equals(other);
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
        public static bool operator ==(ExtractionAssetFormat left, ExtractionAssetFormat right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ExtractionAssetFormat left, ExtractionAssetFormat right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractionAssetFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractionAssetFormat value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractionAssetFormat? ToEnum(string value)
        {
            return ExtractionAssetFormat.FromValue(value);
        }
    }
}