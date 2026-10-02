
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Aspect ratio of the generated video<br/>
    /// Example: 16:9
    /// </summary>
    public readonly partial struct VideoGenerationRequestAspectRatio : global::System.IEquatable<VideoGenerationRequestAspectRatio>
    {
        /// <summary>
        ///
        /// </summary>
        public VideoGenerationRequestAspectRatio(string value)
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
        public static VideoGenerationRequestAspectRatio x16_9 { get; } = new("16:9");

        /// <summary>
        ///
        /// </summary>
        public static VideoGenerationRequestAspectRatio x1_1 { get; } = new("1:1");

        /// <summary>
        ///
        /// </summary>
        public static VideoGenerationRequestAspectRatio x21_9 { get; } = new("21:9");

        /// <summary>
        ///
        /// </summary>
        public static VideoGenerationRequestAspectRatio x2_3 { get; } = new("2:3");

        /// <summary>
        ///
        /// </summary>
        public static VideoGenerationRequestAspectRatio x3_2 { get; } = new("3:2");

        /// <summary>
        ///
        /// </summary>
        public static VideoGenerationRequestAspectRatio x3_4 { get; } = new("3:4");

        /// <summary>
        ///
        /// </summary>
        public static VideoGenerationRequestAspectRatio x4_3 { get; } = new("4:3");

        /// <summary>
        ///
        /// </summary>
        public static VideoGenerationRequestAspectRatio x9_16 { get; } = new("9:16");

        /// <summary>
        ///
        /// </summary>
        public static VideoGenerationRequestAspectRatio x9_21 { get; } = new("9:21");
        /// <summary>
        ///
        /// </summary>
        public static VideoGenerationRequestAspectRatio FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "16:9" => x16_9,
                "1:1" => x1_1,
                "21:9" => x21_9,
                "2:3" => x2_3,
                "3:2" => x3_2,
                "3:4" => x3_4,
                "4:3" => x4_3,
                "9:16" => x9_16,
                "9:21" => x9_21,
                _ => new VideoGenerationRequestAspectRatio(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "16:9" => true,
            "1:1" => true,
            "21:9" => true,
            "2:3" => true,
            "3:2" => true,
            "3:4" => true,
            "4:3" => true,
            "9:16" => true,
            "9:21" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(VideoGenerationRequestAspectRatio other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VideoGenerationRequestAspectRatio other && Equals(other);
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
        public static bool operator ==(VideoGenerationRequestAspectRatio left, VideoGenerationRequestAspectRatio right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(VideoGenerationRequestAspectRatio left, VideoGenerationRequestAspectRatio right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoGenerationRequestAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoGenerationRequestAspectRatio value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoGenerationRequestAspectRatio? ToEnum(string value)
        {
            return VideoGenerationRequestAspectRatio.FromValue(value);
        }
    }
}