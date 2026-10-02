
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Resolution of the generated video<br/>
    /// Example: 720p
    /// </summary>
    public readonly partial struct VideoGenerationRequestResolution : global::System.IEquatable<VideoGenerationRequestResolution>
    {
        /// <summary>
        ///
        /// </summary>
        public VideoGenerationRequestResolution(string value)
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
        public static VideoGenerationRequestResolution x1080p { get; } = new("1080p");

        /// <summary>
        ///
        /// </summary>
        public static VideoGenerationRequestResolution x1k { get; } = new("1K");

        /// <summary>
        ///
        /// </summary>
        public static VideoGenerationRequestResolution x2k { get; } = new("2K");

        /// <summary>
        ///
        /// </summary>
        public static VideoGenerationRequestResolution x360p { get; } = new("360p");

        /// <summary>
        ///
        /// </summary>
        public static VideoGenerationRequestResolution x480p { get; } = new("480p");

        /// <summary>
        ///
        /// </summary>
        public static VideoGenerationRequestResolution x4k { get; } = new("4K");

        /// <summary>
        ///
        /// </summary>
        public static VideoGenerationRequestResolution x720p { get; } = new("720p");

        /// <summary>
        ///
        /// </summary>
        public static VideoGenerationRequestResolution x768p { get; } = new("768p");
        /// <summary>
        ///
        /// </summary>
        public static VideoGenerationRequestResolution FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "1080p" => x1080p,
                "1K" => x1k,
                "2K" => x2k,
                "360p" => x360p,
                "480p" => x480p,
                "4K" => x4k,
                "720p" => x720p,
                "768p" => x768p,
                _ => new VideoGenerationRequestResolution(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "1080p" => true,
            "1K" => true,
            "2K" => true,
            "360p" => true,
            "480p" => true,
            "4K" => true,
            "720p" => true,
            "768p" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(VideoGenerationRequestResolution other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VideoGenerationRequestResolution other && Equals(other);
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
        public static bool operator ==(VideoGenerationRequestResolution left, VideoGenerationRequestResolution right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(VideoGenerationRequestResolution left, VideoGenerationRequestResolution right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoGenerationRequestResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoGenerationRequestResolution value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoGenerationRequestResolution? ToEnum(string value)
        {
            return VideoGenerationRequestResolution.FromValue(value);
        }
    }
}