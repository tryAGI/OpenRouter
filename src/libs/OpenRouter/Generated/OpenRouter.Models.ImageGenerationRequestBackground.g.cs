
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Background treatment. `transparent` requires an output_format that supports alpha (png or webp).<br/>
    /// Example: auto
    /// </summary>
    public readonly partial struct ImageGenerationRequestBackground : global::System.IEquatable<ImageGenerationRequestBackground>
    {
        /// <summary>
        ///
        /// </summary>
        public ImageGenerationRequestBackground(string value)
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
        public static ImageGenerationRequestBackground Auto { get; } = new("auto");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestBackground Opaque { get; } = new("opaque");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestBackground Transparent { get; } = new("transparent");
        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationRequestBackground FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "auto" => Auto,
                "opaque" => Opaque,
                "transparent" => Transparent,
                _ => new ImageGenerationRequestBackground(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "auto" => true,
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
        public bool Equals(ImageGenerationRequestBackground other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageGenerationRequestBackground other && Equals(other);
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
        public static bool operator ==(ImageGenerationRequestBackground left, ImageGenerationRequestBackground right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ImageGenerationRequestBackground left, ImageGenerationRequestBackground right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationRequestBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationRequestBackground value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationRequestBackground? ToEnum(string value)
        {
            return ImageGenerationRequestBackground.FromValue(value);
        }
    }
}