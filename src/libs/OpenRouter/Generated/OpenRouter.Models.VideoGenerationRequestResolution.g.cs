
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Resolution of the generated video
    /// </summary>
    public enum VideoGenerationRequestResolution
    {
        /// <summary>
        /// 
        /// </summary>
        x1080p,
        /// <summary>
        /// 
        /// </summary>
        x1k,
        /// <summary>
        /// 
        /// </summary>
        x2k,
        /// <summary>
        /// 
        /// </summary>
        x480p,
        /// <summary>
        /// 
        /// </summary>
        x4k,
        /// <summary>
        /// 
        /// </summary>
        x720p,
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
            return value switch
            {
                VideoGenerationRequestResolution.x1080p => "1080p",
                VideoGenerationRequestResolution.x1k => "1K",
                VideoGenerationRequestResolution.x2k => "2K",
                VideoGenerationRequestResolution.x480p => "480p",
                VideoGenerationRequestResolution.x4k => "4K",
                VideoGenerationRequestResolution.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoGenerationRequestResolution? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => VideoGenerationRequestResolution.x1080p,
                "1K" => VideoGenerationRequestResolution.x1k,
                "2K" => VideoGenerationRequestResolution.x2k,
                "480p" => VideoGenerationRequestResolution.x480p,
                "4K" => VideoGenerationRequestResolution.x4k,
                "720p" => VideoGenerationRequestResolution.x720p,
                _ => null,
            };
        }
    }
}