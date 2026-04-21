
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Audio output format<br/>
    /// Default Value: pcm
    /// </summary>
    public enum SpeechRequestResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        Pcm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechRequestResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechRequestResponseFormat value)
        {
            return value switch
            {
                SpeechRequestResponseFormat.Mp3 => "mp3",
                SpeechRequestResponseFormat.Pcm => "pcm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechRequestResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => SpeechRequestResponseFormat.Mp3,
                "pcm" => SpeechRequestResponseFormat.Pcm,
                _ => null,
            };
        }
    }
}