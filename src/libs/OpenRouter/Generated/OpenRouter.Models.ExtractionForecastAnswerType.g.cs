
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ExtractionForecastAnswerType
    {
        /// <summary>
        ///
        /// </summary>
        Forecast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractionForecastAnswerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractionForecastAnswerType value)
        {
            return value switch
            {
                ExtractionForecastAnswerType.Forecast => "forecast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractionForecastAnswerType? ToEnum(string value)
        {
            return value switch
            {
                "forecast" => ExtractionForecastAnswerType.Forecast,
                _ => null,
            };
        }
    }
}