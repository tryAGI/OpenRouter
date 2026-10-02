
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct VideoGenerationResponseStatus : global::System.IEquatable<VideoGenerationResponseStatus>
    {
        /// <summary>
        ///
        /// </summary>
        public VideoGenerationResponseStatus(string value)
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
        public static VideoGenerationResponseStatus Cancelled { get; } = new("cancelled");

        /// <summary>
        ///
        /// </summary>
        public static VideoGenerationResponseStatus Completed { get; } = new("completed");

        /// <summary>
        ///
        /// </summary>
        public static VideoGenerationResponseStatus Expired { get; } = new("expired");

        /// <summary>
        ///
        /// </summary>
        public static VideoGenerationResponseStatus Failed { get; } = new("failed");

        /// <summary>
        ///
        /// </summary>
        public static VideoGenerationResponseStatus InProgress { get; } = new("in_progress");

        /// <summary>
        ///
        /// </summary>
        public static VideoGenerationResponseStatus Pending { get; } = new("pending");
        /// <summary>
        ///
        /// </summary>
        public static VideoGenerationResponseStatus FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "cancelled" => Cancelled,
                "completed" => Completed,
                "expired" => Expired,
                "failed" => Failed,
                "in_progress" => InProgress,
                "pending" => Pending,
                _ => new VideoGenerationResponseStatus(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "cancelled" => true,
            "completed" => true,
            "expired" => true,
            "failed" => true,
            "in_progress" => true,
            "pending" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(VideoGenerationResponseStatus other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VideoGenerationResponseStatus other && Equals(other);
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
        public static bool operator ==(VideoGenerationResponseStatus left, VideoGenerationResponseStatus right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(VideoGenerationResponseStatus left, VideoGenerationResponseStatus right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoGenerationResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoGenerationResponseStatus value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoGenerationResponseStatus? ToEnum(string value)
        {
            return VideoGenerationResponseStatus.FromValue(value);
        }
    }
}