
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ExtractionEstimateFieldStepVariant3
    {
        /// <summary>
        ///
        /// </summary>
        Year,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractionEstimateFieldStepVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractionEstimateFieldStepVariant3 value)
        {
            return value switch
            {
                ExtractionEstimateFieldStepVariant3.Year => "year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractionEstimateFieldStepVariant3? ToEnum(string value)
        {
            return value switch
            {
                "year" => ExtractionEstimateFieldStepVariant3.Year,
                _ => null,
            };
        }
    }
}