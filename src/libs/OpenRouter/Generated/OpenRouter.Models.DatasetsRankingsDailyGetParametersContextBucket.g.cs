
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Restrict to requests whose context length falls in this bucket (`1K`, `10K`, `100K`, `1M`, or `10M`). Exact dataset — cannot be combined with `category` or `language_type`.
    /// </summary>
    public enum DatasetsRankingsDailyGetParametersContextBucket
    {
        /// <summary>
        /// 
        /// </summary>
        x100k,
        /// <summary>
        /// 
        /// </summary>
        x10k,
        /// <summary>
        /// 
        /// </summary>
        x10m,
        /// <summary>
        /// 
        /// </summary>
        x1k,
        /// <summary>
        /// 
        /// </summary>
        x1m,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatasetsRankingsDailyGetParametersContextBucketExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetsRankingsDailyGetParametersContextBucket value)
        {
            return value switch
            {
                DatasetsRankingsDailyGetParametersContextBucket.x100k => "100K",
                DatasetsRankingsDailyGetParametersContextBucket.x10k => "10K",
                DatasetsRankingsDailyGetParametersContextBucket.x10m => "10M",
                DatasetsRankingsDailyGetParametersContextBucket.x1k => "1K",
                DatasetsRankingsDailyGetParametersContextBucket.x1m => "1M",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetsRankingsDailyGetParametersContextBucket? ToEnum(string value)
        {
            return value switch
            {
                "100K" => DatasetsRankingsDailyGetParametersContextBucket.x100k,
                "10K" => DatasetsRankingsDailyGetParametersContextBucket.x10k,
                "10M" => DatasetsRankingsDailyGetParametersContextBucket.x10m,
                "1K" => DatasetsRankingsDailyGetParametersContextBucket.x1k,
                "1M" => DatasetsRankingsDailyGetParametersContextBucket.x1m,
                _ => null,
            };
        }
    }
}