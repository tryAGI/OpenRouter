
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ExtractionEstimateFieldStepVariant2
    {
        /// <summary>
        ///
        /// </summary>
        Month,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractionEstimateFieldStepVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractionEstimateFieldStepVariant2 value)
        {
            return value switch
            {
                ExtractionEstimateFieldStepVariant2.Month => "month",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractionEstimateFieldStepVariant2? ToEnum(string value)
        {
            return value switch
            {
                "month" => ExtractionEstimateFieldStepVariant2.Month,
                _ => null,
            };
        }
    }
}