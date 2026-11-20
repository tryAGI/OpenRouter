
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum SpeechEnumParameterType
    {
        /// <summary>
        ///
        /// </summary>
        Enum,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpeechEnumParameterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpeechEnumParameterType value)
        {
            return value switch
            {
                SpeechEnumParameterType.Enum => "enum",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpeechEnumParameterType? ToEnum(string value)
        {
            return value switch
            {
                "enum" => SpeechEnumParameterType.Enum,
                _ => null,
            };
        }
    }
}