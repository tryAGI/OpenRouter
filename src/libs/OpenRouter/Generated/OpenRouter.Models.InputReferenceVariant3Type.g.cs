
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: video_url
    /// </summary>
    public enum InputReferenceVariant3Type
    {
        /// <summary>
        /// video_url
        /// </summary>
        VideoUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputReferenceVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputReferenceVariant3Type value)
        {
            return value switch
            {
                InputReferenceVariant3Type.VideoUrl => "video_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputReferenceVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "video_url" => InputReferenceVariant3Type.VideoUrl,
                _ => null,
            };
        }
    }
}