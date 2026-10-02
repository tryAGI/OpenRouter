
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ContentPartVideoType
    {
        /// <summary>
        ///
        /// </summary>
        VideoUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentPartVideoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentPartVideoType value)
        {
            return value switch
            {
                ContentPartVideoType.VideoUrl => "video_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentPartVideoType? ToEnum(string value)
        {
            return value switch
            {
                "video_url" => ContentPartVideoType.VideoUrl,
                _ => null,
            };
        }
    }
}