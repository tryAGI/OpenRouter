
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Restrict to natural-language or programming-language tagged activity. Sourced from a sampled, upsampled dataset, so `total_tokens` is an estimate and is aggregated weekly (the trailing weekly bucket may include traffic past `end_date`). Cannot be combined with `modality`, `context_bucket`, or `category`.
    /// </summary>
    public enum DatasetsRankingsDailyGetParametersLanguageType
    {
        /// <summary>
        /// 
        /// </summary>
        Natural,
        /// <summary>
        /// 
        /// </summary>
        Programming,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatasetsRankingsDailyGetParametersLanguageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetsRankingsDailyGetParametersLanguageType value)
        {
            return value switch
            {
                DatasetsRankingsDailyGetParametersLanguageType.Natural => "natural",
                DatasetsRankingsDailyGetParametersLanguageType.Programming => "programming",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetsRankingsDailyGetParametersLanguageType? ToEnum(string value)
        {
            return value switch
            {
                "natural" => DatasetsRankingsDailyGetParametersLanguageType.Natural,
                "programming" => DatasetsRankingsDailyGetParametersLanguageType.Programming,
                _ => null,
            };
        }
    }
}