
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Example: image/jpeg
    /// </summary>
    public readonly partial struct AnthropicImageMimeType : global::System.IEquatable<AnthropicImageMimeType>
    {
        /// <summary>
        ///
        /// </summary>
        public AnthropicImageMimeType(string value)
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
        public static AnthropicImageMimeType ImageGif { get; } = new("image/gif");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicImageMimeType ImageJpeg { get; } = new("image/jpeg");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicImageMimeType ImagePng { get; } = new("image/png");

        /// <summary>
        ///
        /// </summary>
        public static AnthropicImageMimeType ImageWebp { get; } = new("image/webp");
        /// <summary>
        ///
        /// </summary>
        public static AnthropicImageMimeType FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "image/gif" => ImageGif,
                "image/jpeg" => ImageJpeg,
                "image/png" => ImagePng,
                "image/webp" => ImageWebp,
                _ => new AnthropicImageMimeType(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "image/gif" => true,
            "image/jpeg" => true,
            "image/png" => true,
            "image/webp" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AnthropicImageMimeType other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicImageMimeType other && Equals(other);
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
        public static bool operator ==(AnthropicImageMimeType left, AnthropicImageMimeType right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnthropicImageMimeType left, AnthropicImageMimeType right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicImageMimeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicImageMimeType value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicImageMimeType? ToEnum(string value)
        {
            return AnthropicImageMimeType.FromValue(value);
        }
    }
}