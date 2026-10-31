
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ExtractionNumberFieldType
    {
        /// <summary>
        ///
        /// </summary>
        Number,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractionNumberFieldTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractionNumberFieldType value)
        {
            return value switch
            {
                ExtractionNumberFieldType.Number => "number",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractionNumberFieldType? ToEnum(string value)
        {
            return value switch
            {
                "number" => ExtractionNumberFieldType.Number,
                _ => null,
            };
        }
    }
}