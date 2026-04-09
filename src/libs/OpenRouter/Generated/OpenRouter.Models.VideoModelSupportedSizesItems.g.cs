
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoModelSupportedSizesItems
    {
        /// <summary>
        /// 
        /// </summary>
        x1080x1080,
        /// <summary>
        /// 
        /// </summary>
        x1080x1440,
        /// <summary>
        /// 
        /// </summary>
        x1080x1920,
        /// <summary>
        /// 
        /// </summary>
        x1080x2520,
        /// <summary>
        /// 
        /// </summary>
        x1120x480,
        /// <summary>
        /// 
        /// </summary>
        x1280x720,
        /// <summary>
        /// 
        /// </summary>
        x1440x1080,
        /// <summary>
        /// 
        /// </summary>
        x1680x720,
        /// <summary>
        /// 
        /// </summary>
        x1920x1080,
        /// <summary>
        /// 
        /// </summary>
        x2160x2160,
        /// <summary>
        /// 
        /// </summary>
        x2160x2880,
        /// <summary>
        /// 
        /// </summary>
        x2160x3840,
        /// <summary>
        /// 
        /// </summary>
        x2160x5040,
        /// <summary>
        /// 
        /// </summary>
        x2520x1080,
        /// <summary>
        /// 
        /// </summary>
        x2880x2160,
        /// <summary>
        /// 
        /// </summary>
        x3840x2160,
        /// <summary>
        /// 
        /// </summary>
        x480x1120,
        /// <summary>
        /// 
        /// </summary>
        x480x480,
        /// <summary>
        /// 
        /// </summary>
        x480x640,
        /// <summary>
        /// 
        /// </summary>
        x480x854,
        /// <summary>
        /// 
        /// </summary>
        x5040x2160,
        /// <summary>
        /// 
        /// </summary>
        x640x480,
        /// <summary>
        /// 
        /// </summary>
        x720x1280,
        /// <summary>
        /// 
        /// </summary>
        x720x1680,
        /// <summary>
        /// 
        /// </summary>
        x720x720,
        /// <summary>
        /// 
        /// </summary>
        x720x960,
        /// <summary>
        /// 
        /// </summary>
        x854x480,
        /// <summary>
        /// 
        /// </summary>
        x960x720,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoModelSupportedSizesItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoModelSupportedSizesItems value)
        {
            return value switch
            {
                VideoModelSupportedSizesItems.x1080x1080 => "1080x1080",
                VideoModelSupportedSizesItems.x1080x1440 => "1080x1440",
                VideoModelSupportedSizesItems.x1080x1920 => "1080x1920",
                VideoModelSupportedSizesItems.x1080x2520 => "1080x2520",
                VideoModelSupportedSizesItems.x1120x480 => "1120x480",
                VideoModelSupportedSizesItems.x1280x720 => "1280x720",
                VideoModelSupportedSizesItems.x1440x1080 => "1440x1080",
                VideoModelSupportedSizesItems.x1680x720 => "1680x720",
                VideoModelSupportedSizesItems.x1920x1080 => "1920x1080",
                VideoModelSupportedSizesItems.x2160x2160 => "2160x2160",
                VideoModelSupportedSizesItems.x2160x2880 => "2160x2880",
                VideoModelSupportedSizesItems.x2160x3840 => "2160x3840",
                VideoModelSupportedSizesItems.x2160x5040 => "2160x5040",
                VideoModelSupportedSizesItems.x2520x1080 => "2520x1080",
                VideoModelSupportedSizesItems.x2880x2160 => "2880x2160",
                VideoModelSupportedSizesItems.x3840x2160 => "3840x2160",
                VideoModelSupportedSizesItems.x480x1120 => "480x1120",
                VideoModelSupportedSizesItems.x480x480 => "480x480",
                VideoModelSupportedSizesItems.x480x640 => "480x640",
                VideoModelSupportedSizesItems.x480x854 => "480x854",
                VideoModelSupportedSizesItems.x5040x2160 => "5040x2160",
                VideoModelSupportedSizesItems.x640x480 => "640x480",
                VideoModelSupportedSizesItems.x720x1280 => "720x1280",
                VideoModelSupportedSizesItems.x720x1680 => "720x1680",
                VideoModelSupportedSizesItems.x720x720 => "720x720",
                VideoModelSupportedSizesItems.x720x960 => "720x960",
                VideoModelSupportedSizesItems.x854x480 => "854x480",
                VideoModelSupportedSizesItems.x960x720 => "960x720",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoModelSupportedSizesItems? ToEnum(string value)
        {
            return value switch
            {
                "1080x1080" => VideoModelSupportedSizesItems.x1080x1080,
                "1080x1440" => VideoModelSupportedSizesItems.x1080x1440,
                "1080x1920" => VideoModelSupportedSizesItems.x1080x1920,
                "1080x2520" => VideoModelSupportedSizesItems.x1080x2520,
                "1120x480" => VideoModelSupportedSizesItems.x1120x480,
                "1280x720" => VideoModelSupportedSizesItems.x1280x720,
                "1440x1080" => VideoModelSupportedSizesItems.x1440x1080,
                "1680x720" => VideoModelSupportedSizesItems.x1680x720,
                "1920x1080" => VideoModelSupportedSizesItems.x1920x1080,
                "2160x2160" => VideoModelSupportedSizesItems.x2160x2160,
                "2160x2880" => VideoModelSupportedSizesItems.x2160x2880,
                "2160x3840" => VideoModelSupportedSizesItems.x2160x3840,
                "2160x5040" => VideoModelSupportedSizesItems.x2160x5040,
                "2520x1080" => VideoModelSupportedSizesItems.x2520x1080,
                "2880x2160" => VideoModelSupportedSizesItems.x2880x2160,
                "3840x2160" => VideoModelSupportedSizesItems.x3840x2160,
                "480x1120" => VideoModelSupportedSizesItems.x480x1120,
                "480x480" => VideoModelSupportedSizesItems.x480x480,
                "480x640" => VideoModelSupportedSizesItems.x480x640,
                "480x854" => VideoModelSupportedSizesItems.x480x854,
                "5040x2160" => VideoModelSupportedSizesItems.x5040x2160,
                "640x480" => VideoModelSupportedSizesItems.x640x480,
                "720x1280" => VideoModelSupportedSizesItems.x720x1280,
                "720x1680" => VideoModelSupportedSizesItems.x720x1680,
                "720x720" => VideoModelSupportedSizesItems.x720x720,
                "720x960" => VideoModelSupportedSizesItems.x720x960,
                "854x480" => VideoModelSupportedSizesItems.x854x480,
                "960x720" => VideoModelSupportedSizesItems.x960x720,
                _ => null,
            };
        }
    }
}