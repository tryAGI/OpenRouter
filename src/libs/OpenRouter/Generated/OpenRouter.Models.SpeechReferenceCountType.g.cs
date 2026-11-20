
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum SpeechReferenceCountType
    {
        /// <summary>
        ///
        /// </summary>
        Integer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechReferenceCountTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechReferenceCountType value)
        {
            return value switch
            {
                SpeechReferenceCountType.Integer => "integer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechReferenceCountType? ToEnum(string value)
        {
            return value switch
            {
                "integer" => SpeechReferenceCountType.Integer,
                _ => null,
            };
        }
    }
}