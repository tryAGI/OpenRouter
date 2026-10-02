
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct VideoModelSupportedResolution : global::System.IEquatable<VideoModelSupportedResolution>
    {
        /// <summary>
        ///
        /// </summary>
        public VideoModelSupportedResolution(string value)
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
        public static VideoModelSupportedResolution x1080p { get; } = new("1080p");

        /// <summary>
        ///
        /// </summary>
        public static VideoModelSupportedResolution x1k { get; } = new("1K");

        /// <summary>
        ///
        /// </summary>
        public static VideoModelSupportedResolution x2k { get; } = new("2K");

        /// <summary>
        ///
        /// </summary>
        public static VideoModelSupportedResolution x360p { get; } = new("360p");

        /// <summary>
        ///
        /// </summary>
        public static VideoModelSupportedResolution x480p { get; } = new("480p");

        /// <summary>
        ///
        /// </summary>
        public static VideoModelSupportedResolution x4k { get; } = new("4K");

        /// <summary>
        ///
        /// </summary>
        public static VideoModelSupportedResolution x720p { get; } = new("720p");

        /// <summary>
        ///
        /// </summary>
        public static VideoModelSupportedResolution x768p { get; } = new("768p");
        /// <summary>
        ///
        /// </summary>
        public static VideoModelSupportedResolution FromValue(string value)
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
                _ => new VideoModelSupportedResolution(value),
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
        public bool Equals(VideoModelSupportedResolution other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VideoModelSupportedResolution other && Equals(other);
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
        public static bool operator ==(VideoModelSupportedResolution left, VideoModelSupportedResolution right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(VideoModelSupportedResolution left, VideoModelSupportedResolution right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoModelSupportedResolutionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoModelSupportedResolution value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoModelSupportedResolution? ToEnum(string value)
        {
            return VideoModelSupportedResolution.FromValue(value);
        }
    }
}