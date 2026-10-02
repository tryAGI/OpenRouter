
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Rendering quality. Providers without a quality knob ignore this.<br/>
    /// Example: high
    /// </summary>
    public readonly partial struct ImageGenerationRequestQuality : global::System.IEquatable<ImageGenerationRequestQuality>
    {
        /// <summary>
        ///
        /// </summary>
        public ImageGenerationRequestQuality(string value)
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
        public static ImageGenerationRequestQuality Auto { get; } = new("auto");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestQuality High { get; } = new("high");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestQuality Low { get; } = new("low");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestQuality Max { get; } = new("max");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestQuality Medium { get; } = new("medium");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestQuality Xhigh { get; } = new("xhigh");
        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestQuality FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "auto" => Auto,
                "high" => High,
                "low" => Low,
                "max" => Max,
                "medium" => Medium,
                "xhigh" => Xhigh,
                _ => new ImageGenerationRequestQuality(value),
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
            "max" => true,
            "medium" => true,
            "xhigh" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ImageGenerationRequestQuality other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageGenerationRequestQuality other && Equals(other);
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
        public static bool operator ==(ImageGenerationRequestQuality left, ImageGenerationRequestQuality right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ImageGenerationRequestQuality left, ImageGenerationRequestQuality right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationRequestQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationRequestQuality value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationRequestQuality? ToEnum(string value)
        {
            return ImageGenerationRequestQuality.FromValue(value);
        }
    }
}