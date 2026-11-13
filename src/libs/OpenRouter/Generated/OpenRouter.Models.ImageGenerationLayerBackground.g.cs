
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Whether the layer image has a transparent background
    /// </summary>
    public readonly partial struct ImageGenerationLayerBackground : global::System.IEquatable<ImageGenerationLayerBackground>
    {
        /// <summary>
        ///
        /// </summary>
        public ImageGenerationLayerBackground(string value)
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
        public static ImageGenerationLayerBackground Opaque { get; } = new("opaque");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationLayerBackground Transparent { get; } = new("transparent");
        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationLayerBackground FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "opaque" => Opaque,
                "transparent" => Transparent,
                _ => new ImageGenerationLayerBackground(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "opaque" => true,
            "transparent" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ImageGenerationLayerBackground other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageGenerationLayerBackground other && Equals(other);
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
        public static bool operator ==(ImageGenerationLayerBackground left, ImageGenerationLayerBackground right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ImageGenerationLayerBackground left, ImageGenerationLayerBackground right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationLayerBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationLayerBackground value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationLayerBackground? ToEnum(string value)
        {
            return ImageGenerationLayerBackground.FromValue(value);
        }
    }
}