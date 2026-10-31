
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ExtractionsResponseAnswersDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Date,
        /// <summary>
        ///
        /// </summary>
        Datetime,
        /// <summary>
        ///
        /// </summary>
        Duration,
        /// <summary>
        ///
        /// </summary>
        Estimate,
        /// <summary>
        ///
        /// </summary>
        Forecast,
        /// <summary>
        ///
        /// </summary>
        List,
        /// <summary>
        ///
        /// </summary>
        Number,
        /// <summary>
        ///
        /// </summary>
        Text,
        /// <summary>
        ///
        /// </summary>
        Time,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractionsResponseAnswersDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractionsResponseAnswersDiscriminatorType value)
        {
            return value switch
            {
                ExtractionsResponseAnswersDiscriminatorType.Date => "date",
                ExtractionsResponseAnswersDiscriminatorType.Datetime => "datetime",
                ExtractionsResponseAnswersDiscriminatorType.Duration => "duration",
                ExtractionsResponseAnswersDiscriminatorType.Estimate => "estimate",
                ExtractionsResponseAnswersDiscriminatorType.Forecast => "forecast",
                ExtractionsResponseAnswersDiscriminatorType.List => "list",
                ExtractionsResponseAnswersDiscriminatorType.Number => "number",
                ExtractionsResponseAnswersDiscriminatorType.Text => "text",
                ExtractionsResponseAnswersDiscriminatorType.Time => "time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractionsResponseAnswersDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "date" => ExtractionsResponseAnswersDiscriminatorType.Date,
                "datetime" => ExtractionsResponseAnswersDiscriminatorType.Datetime,
                "duration" => ExtractionsResponseAnswersDiscriminatorType.Duration,
                "estimate" => ExtractionsResponseAnswersDiscriminatorType.Estimate,
                "forecast" => ExtractionsResponseAnswersDiscriminatorType.Forecast,
                "list" => ExtractionsResponseAnswersDiscriminatorType.List,
                "number" => ExtractionsResponseAnswersDiscriminatorType.Number,
                "text" => ExtractionsResponseAnswersDiscriminatorType.Text,
                "time" => ExtractionsResponseAnswersDiscriminatorType.Time,
                _ => null,
            };
        }
    }
}