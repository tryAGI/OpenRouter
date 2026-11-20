
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum SpeechUnknownParameterType
    {
        /// <summary>
        ///
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechUnknownParameterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechUnknownParameterType value)
        {
            return value switch
            {
                SpeechUnknownParameterType.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechUnknownParameterType? ToEnum(string value)
        {
            return value switch
            {
                "unknown" => SpeechUnknownParameterType.Unknown,
                _ => null,
            };
        }
    }
}