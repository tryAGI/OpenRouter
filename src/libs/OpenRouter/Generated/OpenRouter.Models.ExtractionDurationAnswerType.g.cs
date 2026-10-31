
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ExtractionDurationAnswerType
    {
        /// <summary>
        ///
        /// </summary>
        Duration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractionDurationAnswerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractionDurationAnswerType value)
        {
            return value switch
            {
                ExtractionDurationAnswerType.Duration => "duration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractionDurationAnswerType? ToEnum(string value)
        {
            return value switch
            {
                "duration" => ExtractionDurationAnswerType.Duration,
                _ => null,
            };
        }
    }
}