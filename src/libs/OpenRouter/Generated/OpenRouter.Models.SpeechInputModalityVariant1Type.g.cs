
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum SpeechInputModalityVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechInputModalityVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechInputModalityVariant1Type value)
        {
            return value switch
            {
                SpeechInputModalityVariant1Type.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechInputModalityVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "text" => SpeechInputModalityVariant1Type.Text,
                _ => null,
            };
        }
    }
}