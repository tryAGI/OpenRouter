
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ExtractionForecastFieldStepVariant3
    {
        /// <summary>
        ///
        /// </summary>
        Year,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractionForecastFieldStepVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractionForecastFieldStepVariant3 value)
        {
            return value switch
            {
                ExtractionForecastFieldStepVariant3.Year => "year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractionForecastFieldStepVariant3? ToEnum(string value)
        {
            return value switch
            {
                "year" => ExtractionForecastFieldStepVariant3.Year,
                _ => null,
            };
        }
    }
}