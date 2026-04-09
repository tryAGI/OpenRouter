
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Aspect ratio of the generated video
    /// </summary>
    public enum VideoGenerationRequestAspectRatio
    {
        /// <summary>
        /// 
        /// </summary>
        x16_9,
        /// <summary>
        /// 
        /// </summary>
        x1_1,
        /// <summary>
        /// 
        /// </summary>
        x21_9,
        /// <summary>
        /// 
        /// </summary>
        x3_4,
        /// <summary>
        /// 
        /// </summary>
        x4_3,
        /// <summary>
        /// 
        /// </summary>
        x9_16,
        /// <summary>
        /// 
        /// </summary>
        x9_21,
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
            return value switch
            {
                VideoGenerationRequestAspectRatio.x16_9 => "16:9",
                VideoGenerationRequestAspectRatio.x1_1 => "1:1",
                VideoGenerationRequestAspectRatio.x21_9 => "21:9",
                VideoGenerationRequestAspectRatio.x3_4 => "3:4",
                VideoGenerationRequestAspectRatio.x4_3 => "4:3",
                VideoGenerationRequestAspectRatio.x9_16 => "9:16",
                VideoGenerationRequestAspectRatio.x9_21 => "9:21",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoGenerationRequestAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => VideoGenerationRequestAspectRatio.x16_9,
                "1:1" => VideoGenerationRequestAspectRatio.x1_1,
                "21:9" => VideoGenerationRequestAspectRatio.x21_9,
                "3:4" => VideoGenerationRequestAspectRatio.x3_4,
                "4:3" => VideoGenerationRequestAspectRatio.x4_3,
                "9:16" => VideoGenerationRequestAspectRatio.x9_16,
                "9:21" => VideoGenerationRequestAspectRatio.x9_21,
                _ => null,
            };
        }
    }
}