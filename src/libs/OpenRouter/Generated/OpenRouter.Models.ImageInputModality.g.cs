
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Example: text
    /// </summary>
    public readonly partial struct ImageInputModality : global::System.IEquatable<ImageInputModality>
    {
        /// <summary>
        ///
        /// </summary>
        public ImageInputModality(string value)
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
        public static ImageInputModality Audio { get; } = new("audio");

        /// <summary>
        ///
        /// </summary>
        public static ImageInputModality File { get; } = new("file");

        /// <summary>
        ///
        /// </summary>
        public static ImageInputModality Image { get; } = new("image");

        /// <summary>
        ///
        /// </summary>
        public static ImageInputModality Text { get; } = new("text");

        /// <summary>
        ///
        /// </summary>
        public static ImageInputModality Video { get; } = new("video");
        /// <summary>
        ///
        /// </summary>
        public static ImageInputModality FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "audio" => Audio,
                "file" => File,
                "image" => Image,
                "text" => Text,
                "video" => Video,
                _ => new ImageInputModality(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "audio" => true,
            "file" => true,
            "image" => true,
            "text" => true,
            "video" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ImageInputModality other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageInputModality other && Equals(other);
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
        public static bool operator ==(ImageInputModality left, ImageInputModality right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ImageInputModality left, ImageInputModality right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageInputModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageInputModality value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageInputModality? ToEnum(string value)
        {
            return ImageInputModality.FromValue(value);
        }
    }
}