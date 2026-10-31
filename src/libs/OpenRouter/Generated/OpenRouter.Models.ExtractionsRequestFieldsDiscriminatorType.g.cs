
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ExtractionsRequestFieldsDiscriminatorType
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
    public static class ExtractionsRequestFieldsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractionsRequestFieldsDiscriminatorType value)
        {
            return value switch
            {
                ExtractionsRequestFieldsDiscriminatorType.Date => "date",
                ExtractionsRequestFieldsDiscriminatorType.Datetime => "datetime",
                ExtractionsRequestFieldsDiscriminatorType.Duration => "duration",
                ExtractionsRequestFieldsDiscriminatorType.Estimate => "estimate",
                ExtractionsRequestFieldsDiscriminatorType.Forecast => "forecast",
                ExtractionsRequestFieldsDiscriminatorType.List => "list",
                ExtractionsRequestFieldsDiscriminatorType.Number => "number",
                ExtractionsRequestFieldsDiscriminatorType.Text => "text",
                ExtractionsRequestFieldsDiscriminatorType.Time => "time",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractionsRequestFieldsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "date" => ExtractionsRequestFieldsDiscriminatorType.Date,
                "datetime" => ExtractionsRequestFieldsDiscriminatorType.Datetime,
                "duration" => ExtractionsRequestFieldsDiscriminatorType.Duration,
                "estimate" => ExtractionsRequestFieldsDiscriminatorType.Estimate,
                "forecast" => ExtractionsRequestFieldsDiscriminatorType.Forecast,
                "list" => ExtractionsRequestFieldsDiscriminatorType.List,
                "number" => ExtractionsRequestFieldsDiscriminatorType.Number,
                "text" => ExtractionsRequestFieldsDiscriminatorType.Text,
                "time" => ExtractionsRequestFieldsDiscriminatorType.Time,
                _ => null,
            };
        }
    }
}