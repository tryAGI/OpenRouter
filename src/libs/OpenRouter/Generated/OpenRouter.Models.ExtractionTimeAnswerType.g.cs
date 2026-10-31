
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ExtractionTimeAnswerType
    {
        /// <summary>
        ///
        /// </summary>
        Time,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractionTimeAnswerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractionTimeAnswerType value)
        {
            return value switch
            {
                ExtractionTimeAnswerType.Time => "time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractionTimeAnswerType? ToEnum(string value)
        {
            return value switch
            {
                "time" => ExtractionTimeAnswerType.Time,
                _ => null,
            };
        }
    }
}