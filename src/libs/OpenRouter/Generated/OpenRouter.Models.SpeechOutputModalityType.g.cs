
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum SpeechOutputModalityType
    {
        /// <summary>
        ///
        /// </summary>
        Speech,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechOutputModalityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechOutputModalityType value)
        {
            return value switch
            {
                SpeechOutputModalityType.Speech => "speech",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechOutputModalityType? ToEnum(string value)
        {
            return value switch
            {
                "speech" => SpeechOutputModalityType.Speech,
                _ => null,
            };
        }
    }
}