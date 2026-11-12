
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BatchObjectResultResponseBodyVariant5Object
    {
        /// <summary>
        ///
        /// </summary>
        AudioSpeech,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchObjectResultResponseBodyVariant5ObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchObjectResultResponseBodyVariant5Object value)
        {
            return value switch
            {
                BatchObjectResultResponseBodyVariant5Object.AudioSpeech => "audio.speech",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchObjectResultResponseBodyVariant5Object? ToEnum(string value)
        {
            return value switch
            {
                "audio.speech" => BatchObjectResultResponseBodyVariant5Object.AudioSpeech,
                _ => null,
            };
        }
    }
}