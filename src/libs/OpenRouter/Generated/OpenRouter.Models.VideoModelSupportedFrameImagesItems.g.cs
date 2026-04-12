
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoModelSupportedFrameImagesItems
    {
        /// <summary>
        /// 
        /// </summary>
        FirstFrame,
        /// <summary>
        /// 
        /// </summary>
        LastFrame,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoModelSupportedFrameImagesItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoModelSupportedFrameImagesItems value)
        {
            return value switch
            {
                VideoModelSupportedFrameImagesItems.FirstFrame => "first_frame",
                VideoModelSupportedFrameImagesItems.LastFrame => "last_frame",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoModelSupportedFrameImagesItems? ToEnum(string value)
        {
            return value switch
            {
                "first_frame" => VideoModelSupportedFrameImagesItems.FirstFrame,
                "last_frame" => VideoModelSupportedFrameImagesItems.LastFrame,
                _ => null,
            };
        }
    }
}