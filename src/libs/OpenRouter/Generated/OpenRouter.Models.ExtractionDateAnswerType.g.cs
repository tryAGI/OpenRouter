
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ExtractionDateAnswerType
    {
        /// <summary>
        ///
        /// </summary>
        Date,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractionDateAnswerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractionDateAnswerType value)
        {
            return value switch
            {
                ExtractionDateAnswerType.Date => "date",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractionDateAnswerType? ToEnum(string value)
        {
            return value switch
            {
                "date" => ExtractionDateAnswerType.Date,
                _ => null,
            };
        }
    }
}