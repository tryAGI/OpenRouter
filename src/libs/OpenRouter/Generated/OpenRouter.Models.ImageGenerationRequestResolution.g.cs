
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Normalized resolution tier of the generated image. Concrete pixel dimensions are derived per-provider.<br/>
    /// Example: 2K
    /// </summary>
    public readonly partial struct ImageGenerationRequestResolution : global::System.IEquatable<ImageGenerationRequestResolution>
    {
        /// <summary>
        ///
        /// </summary>
        public ImageGenerationRequestResolution(string value)
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
        public static ImageGenerationRequestResolution x15k { get; } = new("1.5K");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestResolution x1k { get; } = new("1K");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestResolution x2k { get; } = new("2K");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestResolution x4k { get; } = new("4K");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestResolution x512 { get; } = new("512");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestResolution x768 { get; } = new("768");
        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestResolution FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "1.5K" => x15k,
                "1K" => x1k,
                "2K" => x2k,
                "4K" => x4k,
                "512" => x512,
                "768" => x768,
                _ => new ImageGenerationRequestResolution(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "1.5K" => true,
            "1K" => true,
            "2K" => true,
            "4K" => true,
            "512" => true,
            "768" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ImageGenerationRequestResolution other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageGenerationRequestResolution other && Equals(other);
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
        public static bool operator ==(ImageGenerationRequestResolution left, ImageGenerationRequestResolution right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ImageGenerationRequestResolution left, ImageGenerationRequestResolution right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationRequestResolution value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationRequestResolution? ToEnum(string value)
        {
            return ImageGenerationRequestResolution.FromValue(value);
        }
    }
}