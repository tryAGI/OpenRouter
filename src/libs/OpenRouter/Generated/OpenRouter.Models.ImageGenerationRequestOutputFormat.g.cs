
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Encoding of the returned image bytes. Most models produce raster formats (png, jpeg, webp). SVG is supported by vectorization models (e.g. Quiver) — the SVG markup is UTF-8 base64-encoded in `b64_json`.<br/>
    /// Example: png
    /// </summary>
    public readonly partial struct ImageGenerationRequestOutputFormat : global::System.IEquatable<ImageGenerationRequestOutputFormat>
    {
        /// <summary>
        ///
        /// </summary>
        public ImageGenerationRequestOutputFormat(string value)
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
        public static ImageGenerationRequestOutputFormat Jpeg { get; } = new("jpeg");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestOutputFormat Png { get; } = new("png");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestOutputFormat Svg { get; } = new("svg");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestOutputFormat Webp { get; } = new("webp");
        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestOutputFormat FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "jpeg" => Jpeg,
                "png" => Png,
                "svg" => Svg,
                "webp" => Webp,
                _ => new ImageGenerationRequestOutputFormat(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "jpeg" => true,
            "png" => true,
            "svg" => true,
            "webp" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ImageGenerationRequestOutputFormat other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageGenerationRequestOutputFormat other && Equals(other);
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
        public static bool operator ==(ImageGenerationRequestOutputFormat left, ImageGenerationRequestOutputFormat right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ImageGenerationRequestOutputFormat left, ImageGenerationRequestOutputFormat right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationRequestOutputFormat value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationRequestOutputFormat? ToEnum(string value)
        {
            return ImageGenerationRequestOutputFormat.FromValue(value);
        }
    }
}