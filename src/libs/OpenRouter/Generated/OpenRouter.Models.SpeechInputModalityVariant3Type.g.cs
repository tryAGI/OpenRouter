
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum SpeechInputModalityVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechInputModalityVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechInputModalityVariant3Type value)
        {
            return value switch
            {
                SpeechInputModalityVariant3Type.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechInputModalityVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "image" => SpeechInputModalityVariant3Type.Image,
                _ => null,
            };
        }
    }
}