
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoModelSupportedResolutionsItems
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
    public static class VideoModelSupportedResolutionsItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoModelSupportedResolutionsItems value)
        {
            return value switch
            {
                VideoModelSupportedResolutionsItems.x1080p => "1080p",
                VideoModelSupportedResolutionsItems.x1k => "1K",
                VideoModelSupportedResolutionsItems.x2k => "2K",
                VideoModelSupportedResolutionsItems.x480p => "480p",
                VideoModelSupportedResolutionsItems.x4k => "4K",
                VideoModelSupportedResolutionsItems.x720p => "720p",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoModelSupportedResolutionsItems? ToEnum(string value)
        {
            return value switch
            {
                "1080p" => VideoModelSupportedResolutionsItems.x1080p,
                "1K" => VideoModelSupportedResolutionsItems.x1k,
                "2K" => VideoModelSupportedResolutionsItems.x2k,
                "480p" => VideoModelSupportedResolutionsItems.x480p,
                "4K" => VideoModelSupportedResolutionsItems.x4k,
                "720p" => VideoModelSupportedResolutionsItems.x720p,
                _ => null,
            };
        }
    }
}