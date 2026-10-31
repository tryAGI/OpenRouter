
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ExtractionEstimateAnswerType
    {
        /// <summary>
        ///
        /// </summary>
        Estimate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractionEstimateAnswerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractionEstimateAnswerType value)
        {
            return value switch
            {
                ExtractionEstimateAnswerType.Estimate => "estimate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractionEstimateAnswerType? ToEnum(string value)
        {
            return value switch
            {
                "estimate" => ExtractionEstimateAnswerType.Estimate,
                _ => null,
            };
        }
    }
}