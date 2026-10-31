
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ExtractionDateFieldType
    {
        /// <summary>
        ///
        /// </summary>
        Date,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractionDateFieldTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractionDateFieldType value)
        {
            return value switch
            {
                ExtractionDateFieldType.Date => "date",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractionDateFieldType? ToEnum(string value)
        {
            return value switch
            {
                "date" => ExtractionDateFieldType.Date,
                _ => null,
            };
        }
    }
}