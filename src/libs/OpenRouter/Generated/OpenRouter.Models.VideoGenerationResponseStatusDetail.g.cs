
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// The step within `status` for a job that is not finished: `submitting` and `queued_at_provider` under `pending`, `generating` and `finalizing` under `in_progress`. When present, it only moves forward, and steps may be skipped between polls. It is absent once the job is finished and can also be absent mid-job when the step is unknown, so use `status` to tell whether the job is finished.
    /// </summary>
    public readonly partial struct VideoGenerationResponseStatusDetail : global::System.IEquatable<VideoGenerationResponseStatusDetail>
    {
        /// <summary>
        ///
        /// </summary>
        public VideoGenerationResponseStatusDetail(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// `submitting` and `queued_at_provider` under `pending`, `generating` and `finalizing` under `in_progress`. When present, it only moves forward, and steps may be skipped between polls. It is absent once the job is finished and can also be absent mid-job when the step is unknown, so use `status` to tell whether the job is finished.
        /// </summary>
        public static VideoGenerationResponseStatusDetail Finalizing { get; } = new("finalizing");

        /// <summary>
        /// `submitting` and `queued_at_provider` under `pending`, `generating` and `finalizing` under `in_progress`. When present, it only moves forward, and steps may be skipped between polls. It is absent once the job is finished and can also be absent mid-job when the step is unknown, so use `status` to tell whether the job is finished.
        /// </summary>
        public static VideoGenerationResponseStatusDetail Generating { get; } = new("generating");

        /// <summary>
        /// `submitting` and `queued_at_provider` under `pending`, `generating` and `finalizing` under `in_progress`. When present, it only moves forward, and steps may be skipped between polls. It is absent once the job is finished and can also be absent mid-job when the step is unknown, so use `status` to tell whether the job is finished.
        /// </summary>
        public static VideoGenerationResponseStatusDetail QueuedAtProvider { get; } = new("queued_at_provider");

        /// <summary>
        /// `submitting` and `queued_at_provider` under `pending`, `generating` and `finalizing` under `in_progress`. When present, it only moves forward, and steps may be skipped between polls. It is absent once the job is finished and can also be absent mid-job when the step is unknown, so use `status` to tell whether the job is finished.
        /// </summary>
        public static VideoGenerationResponseStatusDetail Submitting { get; } = new("submitting");
        /// <summary>
        ///
        /// </summary>
        public static VideoGenerationResponseStatusDetail FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "finalizing" => Finalizing,
                "generating" => Generating,
                "queued_at_provider" => QueuedAtProvider,
                "submitting" => Submitting,
                _ => new VideoGenerationResponseStatusDetail(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "finalizing" => true,
            "generating" => true,
            "queued_at_provider" => true,
            "submitting" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(VideoGenerationResponseStatusDetail other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VideoGenerationResponseStatusDetail other && Equals(other);
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
        public static bool operator ==(VideoGenerationResponseStatusDetail left, VideoGenerationResponseStatusDetail right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(VideoGenerationResponseStatusDetail left, VideoGenerationResponseStatusDetail right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoGenerationResponseStatusDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoGenerationResponseStatusDetail value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoGenerationResponseStatusDetail? ToEnum(string value)
        {
            return VideoGenerationResponseStatusDetail.FromValue(value);
        }
    }
}