
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ImagePricingEntryBillable : global::System.IEquatable<ImagePricingEntryBillable>
    {
        /// <summary>
        ///
        /// </summary>
        public ImagePricingEntryBillable(string value)
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
        public static ImagePricingEntryBillable InputFont { get; } = new("input_font");

        /// <summary>
        ///
        /// </summary>
        public static ImagePricingEntryBillable InputImage { get; } = new("input_image");

        /// <summary>
        ///
        /// </summary>
        public static ImagePricingEntryBillable InputReference { get; } = new("input_reference");

        /// <summary>
        ///
        /// </summary>
        public static ImagePricingEntryBillable InputText { get; } = new("input_text");

        /// <summary>
        ///
        /// </summary>
        public static ImagePricingEntryBillable OutputImage { get; } = new("output_image");
        /// <summary>
        ///
        /// </summary>
        public static ImagePricingEntryBillable FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "input_font" => InputFont,
                "input_image" => InputImage,
                "input_reference" => InputReference,
                "input_text" => InputText,
                "output_image" => OutputImage,
                _ => new ImagePricingEntryBillable(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "input_font" => true,
            "input_image" => true,
            "input_reference" => true,
            "input_text" => true,
            "output_image" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ImagePricingEntryBillable other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImagePricingEntryBillable other && Equals(other);
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
        public static bool operator ==(ImagePricingEntryBillable left, ImagePricingEntryBillable right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ImagePricingEntryBillable left, ImagePricingEntryBillable right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImagePricingEntryBillableExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImagePricingEntryBillable value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImagePricingEntryBillable? ToEnum(string value)
        {
            return ImagePricingEntryBillable.FromValue(value);
        }
    }
}