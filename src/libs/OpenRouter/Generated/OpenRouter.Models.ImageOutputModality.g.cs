
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Example: image
    /// </summary>
    public readonly partial struct ImageOutputModality : global::System.IEquatable<ImageOutputModality>
    {
        /// <summary>
        ///
        /// </summary>
        public ImageOutputModality(string value)
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
        public static ImageOutputModality Audio { get; } = new("audio");

        /// <summary>
        ///
        /// </summary>
        public static ImageOutputModality Decisions { get; } = new("decisions");

        /// <summary>
        ///
        /// </summary>
        public static ImageOutputModality Embeddings { get; } = new("embeddings");

        /// <summary>
        ///
        /// </summary>
        public static ImageOutputModality Image { get; } = new("image");

        /// <summary>
        ///
        /// </summary>
        public static ImageOutputModality Rerank { get; } = new("rerank");

        /// <summary>
        ///
        /// </summary>
        public static ImageOutputModality Speech { get; } = new("speech");

        /// <summary>
        ///
        /// </summary>
        public static ImageOutputModality Text { get; } = new("text");

        /// <summary>
        ///
        /// </summary>
        public static ImageOutputModality Transcription { get; } = new("transcription");

        /// <summary>
        ///
        /// </summary>
        public static ImageOutputModality Video { get; } = new("video");
        /// <summary>
        ///
        /// </summary>
        public static ImageOutputModality FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "audio" => Audio,
                "decisions" => Decisions,
                "embeddings" => Embeddings,
                "image" => Image,
                "rerank" => Rerank,
                "speech" => Speech,
                "text" => Text,
                "transcription" => Transcription,
                "video" => Video,
                _ => new ImageOutputModality(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "audio" => true,
            "decisions" => true,
            "embeddings" => true,
            "image" => true,
            "rerank" => true,
            "speech" => true,
            "text" => true,
            "transcription" => true,
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
        public bool Equals(ImageOutputModality other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImageOutputModality other && Equals(other);
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
        public static bool operator ==(ImageOutputModality left, ImageOutputModality right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ImageOutputModality left, ImageOutputModality right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageOutputModalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageOutputModality value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageOutputModality? ToEnum(string value)
        {
            return ImageOutputModality.FromValue(value);
        }
    }
}