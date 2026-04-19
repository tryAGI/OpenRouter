
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Audio output format<br/>
    /// Default Value: pcm
    /// </summary>
    public enum TtsPostRequestBodyContentApplicationJsonSchemaResponseFormat
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
    public static class TtsPostRequestBodyContentApplicationJsonSchemaResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TtsPostRequestBodyContentApplicationJsonSchemaResponseFormat value)
        {
            return value switch
            {
                TtsPostRequestBodyContentApplicationJsonSchemaResponseFormat.Mp3 => "mp3",
                TtsPostRequestBodyContentApplicationJsonSchemaResponseFormat.Pcm => "pcm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TtsPostRequestBodyContentApplicationJsonSchemaResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => TtsPostRequestBodyContentApplicationJsonSchemaResponseFormat.Mp3,
                "pcm" => TtsPostRequestBodyContentApplicationJsonSchemaResponseFormat.Pcm,
                _ => null,
            };
        }
    }
}