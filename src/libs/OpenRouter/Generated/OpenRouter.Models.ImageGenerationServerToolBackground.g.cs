
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ImageGenerationServerToolBackground : global::System.IEquatable<ImageGenerationServerToolBackground>
    {
        /// <summary>
        ///
        /// </summary>
        public ImageGenerationServerToolBackground(string value)
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
        public static ImageGenerationServerToolBackground Auto { get; } = new("auto");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationServerToolBackground Opaque { get; } = new("opaque");

        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationServerToolBackground Transparent { get; } = new("transparent");
        /// <summary>
        ///
        /// </summary>
        public static ImageGenerationServerToolBackground FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "auto" => Auto,
                "opaque" => Opaque,
                "transparent" => Transparent,
                _ => new ImageGenerationServerToolBackground(value),
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
        public bool Equals(ImageGenerationServerToolBackground other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageGenerationServerToolBackground other && Equals(other);
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
        public static bool operator ==(ImageGenerationServerToolBackground left, ImageGenerationServerToolBackground right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ImageGenerationServerToolBackground left, ImageGenerationServerToolBackground right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationServerToolBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationServerToolBackground value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationServerToolBackground? ToEnum(string value)
        {
            return ImageGenerationServerToolBackground.FromValue(value);
        }
    }
}