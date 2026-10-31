
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ExtractionForecastFieldStepVariant2
    {
        /// <summary>
        ///
        /// </summary>
        Month,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractionForecastFieldStepVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractionForecastFieldStepVariant2 value)
        {
            return value switch
            {
                ExtractionForecastFieldStepVariant2.Month => "month",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractionForecastFieldStepVariant2? ToEnum(string value)
        {
            return value switch
            {
                "month" => ExtractionForecastFieldStepVariant2.Month,
                _ => null,
            };
        }
    }
}