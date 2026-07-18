
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Restrict to a use-case category (e.g. `programming`, `roleplay`). Sourced from a sampled, upsampled dataset, so `total_tokens` is an estimate and is aggregated weekly (the trailing weekly bucket may include traffic past `end_date`). Cannot be combined with `modality`, `context_bucket`, or `language_type`.
    /// </summary>
    public enum DatasetsRankingsDailyGetParametersCategory
    {
        /// <summary>
        /// 
        /// </summary>
        Academia,
        /// <summary>
        /// 
        /// </summary>
        Finance,
        /// <summary>
        /// 
        /// </summary>
        Health,
        /// <summary>
        /// 
        /// </summary>
        Legal,
        /// <summary>
        /// 
        /// </summary>
        Marketing,
        /// <summary>
        /// 
        /// </summary>
        MarketingSeo,
        /// <summary>
        /// 
        /// </summary>
        Programming,
        /// <summary>
        /// 
        /// </summary>
        Roleplay,
        /// <summary>
        /// 
        /// </summary>
        Science,
        /// <summary>
        /// 
        /// </summary>
        Technology,
        /// <summary>
        /// 
        /// </summary>
        Translation,
        /// <summary>
        /// 
        /// </summary>
        Trivia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatasetsRankingsDailyGetParametersCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetsRankingsDailyGetParametersCategory value)
        {
            return value switch
            {
                DatasetsRankingsDailyGetParametersCategory.Academia => "academia",
                DatasetsRankingsDailyGetParametersCategory.Finance => "finance",
                DatasetsRankingsDailyGetParametersCategory.Health => "health",
                DatasetsRankingsDailyGetParametersCategory.Legal => "legal",
                DatasetsRankingsDailyGetParametersCategory.Marketing => "marketing",
                DatasetsRankingsDailyGetParametersCategory.MarketingSeo => "marketing/seo",
                DatasetsRankingsDailyGetParametersCategory.Programming => "programming",
                DatasetsRankingsDailyGetParametersCategory.Roleplay => "roleplay",
                DatasetsRankingsDailyGetParametersCategory.Science => "science",
                DatasetsRankingsDailyGetParametersCategory.Technology => "technology",
                DatasetsRankingsDailyGetParametersCategory.Translation => "translation",
                DatasetsRankingsDailyGetParametersCategory.Trivia => "trivia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetsRankingsDailyGetParametersCategory? ToEnum(string value)
        {
            return value switch
            {
                "academia" => DatasetsRankingsDailyGetParametersCategory.Academia,
                "finance" => DatasetsRankingsDailyGetParametersCategory.Finance,
                "health" => DatasetsRankingsDailyGetParametersCategory.Health,
                "legal" => DatasetsRankingsDailyGetParametersCategory.Legal,
                "marketing" => DatasetsRankingsDailyGetParametersCategory.Marketing,
                "marketing/seo" => DatasetsRankingsDailyGetParametersCategory.MarketingSeo,
                "programming" => DatasetsRankingsDailyGetParametersCategory.Programming,
                "roleplay" => DatasetsRankingsDailyGetParametersCategory.Roleplay,
                "science" => DatasetsRankingsDailyGetParametersCategory.Science,
                "technology" => DatasetsRankingsDailyGetParametersCategory.Technology,
                "translation" => DatasetsRankingsDailyGetParametersCategory.Translation,
                "trivia" => DatasetsRankingsDailyGetParametersCategory.Trivia,
                _ => null,
            };
        }
    }
}