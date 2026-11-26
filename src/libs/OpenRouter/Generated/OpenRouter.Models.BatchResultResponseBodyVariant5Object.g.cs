
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BatchResultResponseBodyVariant5Object
    {
        /// <summary>
        ///
        /// </summary>
        AudioSpeech,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchResultResponseBodyVariant5ObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchResultResponseBodyVariant5Object value)
        {
            return value switch
            {
                BatchResultResponseBodyVariant5Object.AudioSpeech => "audio.speech",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchResultResponseBodyVariant5Object? ToEnum(string value)
        {
            return value switch
            {
                "audio.speech" => BatchResultResponseBodyVariant5Object.AudioSpeech,
                _ => null,
            };
        }
    }
}