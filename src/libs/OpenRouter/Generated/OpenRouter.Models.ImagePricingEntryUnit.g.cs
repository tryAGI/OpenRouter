
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ImagePricingEntryUnit : global::System.IEquatable<ImagePricingEntryUnit>
    {
        /// <summary>
        ///
        /// </summary>
        public ImagePricingEntryUnit(string value)
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
        public static ImagePricingEntryUnit Image { get; } = new("image");

        /// <summary>
        ///
        /// </summary>
        public static ImagePricingEntryUnit Megapixel { get; } = new("megapixel");

        /// <summary>
        ///
        /// </summary>
        public static ImagePricingEntryUnit Request { get; } = new("request");

        /// <summary>
        ///
        /// </summary>
        public static ImagePricingEntryUnit Token { get; } = new("token");
        /// <summary>
        ///
        /// </summary>
        public static ImagePricingEntryUnit FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "image" => Image,
                "megapixel" => Megapixel,
                "request" => Request,
                "token" => Token,
                _ => new ImagePricingEntryUnit(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "image" => true,
            "megapixel" => true,
            "request" => true,
            "token" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ImagePricingEntryUnit other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImagePricingEntryUnit other && Equals(other);
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
        public static bool operator ==(ImagePricingEntryUnit left, ImagePricingEntryUnit right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ImagePricingEntryUnit left, ImagePricingEntryUnit right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImagePricingEntryUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImagePricingEntryUnit value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImagePricingEntryUnit? ToEnum(string value)
        {
            return ImagePricingEntryUnit.FromValue(value);
        }
    }
}