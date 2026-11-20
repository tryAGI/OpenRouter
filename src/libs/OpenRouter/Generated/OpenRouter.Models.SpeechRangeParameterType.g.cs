
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum SpeechRangeParameterType
    {
        /// <summary>
        ///
        /// </summary>
        Range,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechRangeParameterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechRangeParameterType value)
        {
            return value switch
            {
                SpeechRangeParameterType.Range => "range",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechRangeParameterType? ToEnum(string value)
        {
            return value switch
            {
                "range" => SpeechRangeParameterType.Range,
                _ => null,
            };
        }
    }
}