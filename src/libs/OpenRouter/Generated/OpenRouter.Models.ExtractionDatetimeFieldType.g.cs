
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ExtractionDatetimeFieldType
    {
        /// <summary>
        ///
        /// </summary>
        Datetime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractionDatetimeFieldTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractionDatetimeFieldType value)
        {
            return value switch
            {
                ExtractionDatetimeFieldType.Datetime => "datetime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractionDatetimeFieldType? ToEnum(string value)
        {
            return value switch
            {
                "datetime" => ExtractionDatetimeFieldType.Datetime,
                _ => null,
            };
        }
    }
}