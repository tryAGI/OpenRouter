
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ExtractionForecastFieldType
    {
        /// <summary>
        ///
        /// </summary>
        Forecast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractionForecastFieldTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractionForecastFieldType value)
        {
            return value switch
            {
                ExtractionForecastFieldType.Forecast => "forecast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractionForecastFieldType? ToEnum(string value)
        {
            return value switch
            {
                "forecast" => ExtractionForecastFieldType.Forecast,
                _ => null,
            };
        }
    }
}