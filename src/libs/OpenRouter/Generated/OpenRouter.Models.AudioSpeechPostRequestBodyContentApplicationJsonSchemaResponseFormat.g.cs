
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Audio output format<br/>
    /// Default Value: pcm
    /// </summary>
    public enum AudioSpeechPostRequestBodyContentApplicationJsonSchemaResponseFormat
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
    public static class AudioSpeechPostRequestBodyContentApplicationJsonSchemaResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioSpeechPostRequestBodyContentApplicationJsonSchemaResponseFormat value)
        {
            return value switch
            {
                AudioSpeechPostRequestBodyContentApplicationJsonSchemaResponseFormat.Mp3 => "mp3",
                AudioSpeechPostRequestBodyContentApplicationJsonSchemaResponseFormat.Pcm => "pcm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioSpeechPostRequestBodyContentApplicationJsonSchemaResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => AudioSpeechPostRequestBodyContentApplicationJsonSchemaResponseFormat.Mp3,
                "pcm" => AudioSpeechPostRequestBodyContentApplicationJsonSchemaResponseFormat.Pcm,
                _ => null,
            };
        }
    }
}