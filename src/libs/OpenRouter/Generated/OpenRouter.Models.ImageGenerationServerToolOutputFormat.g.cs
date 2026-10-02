
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ImageGenerationServerToolOutputFormat : global::System.IEquatable<ImageGenerationServerToolOutputFormat>
    {
        /// <summary>
        ///
        /// </summary>
        public ImageGenerationServerToolOutputFormat(string value)
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
        public static ImageGenerationServerToolOutputFormat Jpeg { get; } = new("jpeg");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationServerToolOutputFormat Png { get; } = new("png");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationServerToolOutputFormat Webp { get; } = new("webp");
        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationServerToolOutputFormat FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "jpeg" => Jpeg,
                "png" => Png,
                "webp" => Webp,
                _ => new ImageGenerationServerToolOutputFormat(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "jpeg" => true,
            "png" => true,
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
        public bool Equals(ImageGenerationServerToolOutputFormat other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageGenerationServerToolOutputFormat other && Equals(other);
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
        public static bool operator ==(ImageGenerationServerToolOutputFormat left, ImageGenerationServerToolOutputFormat right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ImageGenerationServerToolOutputFormat left, ImageGenerationServerToolOutputFormat right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationServerToolOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationServerToolOutputFormat value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationServerToolOutputFormat? ToEnum(string value)
        {
            return ImageGenerationServerToolOutputFormat.FromValue(value);
        }
    }
}