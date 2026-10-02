
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ContentPartAudioType
    {
        /// <summary>
        ///
        /// </summary>
        AudioUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentPartAudioTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentPartAudioType value)
        {
            return value switch
            {
                ContentPartAudioType.AudioUrl => "audio_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentPartAudioType? ToEnum(string value)
        {
            return value switch
            {
                "audio_url" => ContentPartAudioType.AudioUrl,
                _ => null,
            };
        }
    }
}