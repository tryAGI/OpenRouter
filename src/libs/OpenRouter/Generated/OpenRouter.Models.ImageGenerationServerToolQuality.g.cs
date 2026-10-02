
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ImageGenerationServerToolQuality : global::System.IEquatable<ImageGenerationServerToolQuality>
    {
        /// <summary>
        ///
        /// </summary>
        public ImageGenerationServerToolQuality(string value)
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
        public static ImageGenerationServerToolQuality Auto { get; } = new("auto");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationServerToolQuality High { get; } = new("high");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationServerToolQuality Low { get; } = new("low");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationServerToolQuality Medium { get; } = new("medium");
        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationServerToolQuality FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "auto" => Auto,
                "high" => High,
                "low" => Low,
                "medium" => Medium,
                _ => new ImageGenerationServerToolQuality(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "auto" => true,
            "high" => true,
            "low" => true,
            "medium" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ImageGenerationServerToolQuality other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageGenerationServerToolQuality other && Equals(other);
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
        public static bool operator ==(ImageGenerationServerToolQuality left, ImageGenerationServerToolQuality right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ImageGenerationServerToolQuality left, ImageGenerationServerToolQuality right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationServerToolQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationServerToolQuality value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationServerToolQuality? ToEnum(string value)
        {
            return ImageGenerationServerToolQuality.FromValue(value);
        }
    }
}