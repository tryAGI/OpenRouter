
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ExtractionEstimateFieldType
    {
        /// <summary>
        ///
        /// </summary>
        Estimate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractionEstimateFieldTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractionEstimateFieldType value)
        {
            return value switch
            {
                ExtractionEstimateFieldType.Estimate => "estimate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractionEstimateFieldType? ToEnum(string value)
        {
            return value switch
            {
                "estimate" => ExtractionEstimateFieldType.Estimate,
                _ => null,
            };
        }
    }
}