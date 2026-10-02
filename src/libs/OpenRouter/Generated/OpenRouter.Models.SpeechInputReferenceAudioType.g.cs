
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum SpeechInputReferenceAudioType
    {
        /// <summary>
        ///
        /// </summary>
        InputAudio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechInputReferenceAudioTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechInputReferenceAudioType value)
        {
            return value switch
            {
                SpeechInputReferenceAudioType.InputAudio => "input_audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechInputReferenceAudioType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio" => SpeechInputReferenceAudioType.InputAudio,
                _ => null,
            };
        }
    }
}