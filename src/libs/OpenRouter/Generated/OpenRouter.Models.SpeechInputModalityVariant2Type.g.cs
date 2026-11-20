
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum SpeechInputModalityVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Audio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechInputModalityVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechInputModalityVariant2Type value)
        {
            return value switch
            {
                SpeechInputModalityVariant2Type.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechInputModalityVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "audio" => SpeechInputModalityVariant2Type.Audio,
                _ => null,
            };
        }
    }
}