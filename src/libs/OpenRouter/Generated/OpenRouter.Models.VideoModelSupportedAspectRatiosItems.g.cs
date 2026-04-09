
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoModelSupportedAspectRatiosItems
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
    public static class VideoModelSupportedAspectRatiosItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoModelSupportedAspectRatiosItems value)
        {
            return value switch
            {
                VideoModelSupportedAspectRatiosItems.x16_9 => "16:9",
                VideoModelSupportedAspectRatiosItems.x1_1 => "1:1",
                VideoModelSupportedAspectRatiosItems.x21_9 => "21:9",
                VideoModelSupportedAspectRatiosItems.x3_4 => "3:4",
                VideoModelSupportedAspectRatiosItems.x4_3 => "4:3",
                VideoModelSupportedAspectRatiosItems.x9_16 => "9:16",
                VideoModelSupportedAspectRatiosItems.x9_21 => "9:21",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoModelSupportedAspectRatiosItems? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => VideoModelSupportedAspectRatiosItems.x16_9,
                "1:1" => VideoModelSupportedAspectRatiosItems.x1_1,
                "21:9" => VideoModelSupportedAspectRatiosItems.x21_9,
                "3:4" => VideoModelSupportedAspectRatiosItems.x3_4,
                "4:3" => VideoModelSupportedAspectRatiosItems.x4_3,
                "9:16" => VideoModelSupportedAspectRatiosItems.x9_16,
                "9:21" => VideoModelSupportedAspectRatiosItems.x9_21,
                _ => null,
            };
        }
    }
}