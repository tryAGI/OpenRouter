
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContentPartInputVideoType
    {
        /// <summary>
        /// 
        /// </summary>
        InputVideo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentPartInputVideoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentPartInputVideoType value)
        {
            return value switch
            {
                ContentPartInputVideoType.InputVideo => "input_video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentPartInputVideoType? ToEnum(string value)
        {
            return value switch
            {
                "input_video" => ContentPartInputVideoType.InputVideo,
                _ => null,
            };
        }
    }
}