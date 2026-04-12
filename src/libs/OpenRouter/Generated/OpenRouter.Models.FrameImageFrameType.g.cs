
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Whether this image represents the first or last frame of the video
    /// </summary>
    public enum FrameImageFrameType
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
    public static class FrameImageFrameTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FrameImageFrameType value)
        {
            return value switch
            {
                FrameImageFrameType.FirstFrame => "first_frame",
                FrameImageFrameType.LastFrame => "last_frame",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FrameImageFrameType? ToEnum(string value)
        {
            return value switch
            {
                "first_frame" => FrameImageFrameType.FirstFrame,
                "last_frame" => FrameImageFrameType.LastFrame,
                _ => null,
            };
        }
    }
}