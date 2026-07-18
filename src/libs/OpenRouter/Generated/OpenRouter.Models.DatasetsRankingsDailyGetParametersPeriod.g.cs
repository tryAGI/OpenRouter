
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Time grain of each row. `day` (default) returns the per-UTC-day series; `week` buckets by ISO week start; `month` buckets by month start. With `category` or `language_type` only `week` (default) and `month` are available — `day` is rejected with a 400 because those datasets are aggregated weekly. For those sampled datasets `period=month` buckets each week by its week-start month, so totals are approximate at month boundaries.
    /// </summary>
    public enum DatasetsRankingsDailyGetParametersPeriod
    {
        /// <summary>
        /// 
        /// </summary>
        Day,
        /// <summary>
        /// 
        /// </summary>
        Month,
        /// <summary>
        /// 
        /// </summary>
        Week,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatasetsRankingsDailyGetParametersPeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetsRankingsDailyGetParametersPeriod value)
        {
            return value switch
            {
                DatasetsRankingsDailyGetParametersPeriod.Day => "day",
                DatasetsRankingsDailyGetParametersPeriod.Month => "month",
                DatasetsRankingsDailyGetParametersPeriod.Week => "week",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetsRankingsDailyGetParametersPeriod? ToEnum(string value)
        {
            return value switch
            {
                "day" => DatasetsRankingsDailyGetParametersPeriod.Day,
                "month" => DatasetsRankingsDailyGetParametersPeriod.Month,
                "week" => DatasetsRankingsDailyGetParametersPeriod.Week,
                _ => null,
            };
        }
    }
}