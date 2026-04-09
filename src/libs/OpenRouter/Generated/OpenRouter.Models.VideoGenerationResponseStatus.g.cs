
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoGenerationResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Pending,
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
            return value switch
            {
                VideoGenerationResponseStatus.Cancelled => "cancelled",
                VideoGenerationResponseStatus.Completed => "completed",
                VideoGenerationResponseStatus.Expired => "expired",
                VideoGenerationResponseStatus.Failed => "failed",
                VideoGenerationResponseStatus.InProgress => "in_progress",
                VideoGenerationResponseStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoGenerationResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => VideoGenerationResponseStatus.Cancelled,
                "completed" => VideoGenerationResponseStatus.Completed,
                "expired" => VideoGenerationResponseStatus.Expired,
                "failed" => VideoGenerationResponseStatus.Failed,
                "in_progress" => VideoGenerationResponseStatus.InProgress,
                "pending" => VideoGenerationResponseStatus.Pending,
                _ => null,
            };
        }
    }
}