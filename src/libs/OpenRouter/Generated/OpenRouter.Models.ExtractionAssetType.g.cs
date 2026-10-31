
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ExtractionAssetType : global::System.IEquatable<ExtractionAssetType>
    {
        /// <summary>
        ///
        /// </summary>
        public ExtractionAssetType(string value)
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
        public static ExtractionAssetType Document { get; } = new("document");

        /// <summary>
        ///
        /// </summary>
        public static ExtractionAssetType Image { get; } = new("image");
        /// <summary>
        ///
        /// </summary>
        public static ExtractionAssetType FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "document" => Document,
                "image" => Image,
                _ => new ExtractionAssetType(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "document" => true,
            "image" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ExtractionAssetType other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ExtractionAssetType other && Equals(other);
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
        public static bool operator ==(ExtractionAssetType left, ExtractionAssetType right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ExtractionAssetType left, ExtractionAssetType right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractionAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractionAssetType value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractionAssetType? ToEnum(string value)
        {
            return ExtractionAssetType.FromValue(value);
        }
    }
}