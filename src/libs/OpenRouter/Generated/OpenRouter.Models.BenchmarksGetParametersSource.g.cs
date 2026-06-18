
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Benchmark source to query. Determines the shape of the returned items.
    /// </summary>
    public enum BenchmarksGetParametersSource
    {
        /// <summary>
        /// 
        /// </summary>
        ArtificialAnalysis,
        /// <summary>
        /// 
        /// </summary>
        DesignArena,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BenchmarksGetParametersSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BenchmarksGetParametersSource value)
        {
            return value switch
            {
                BenchmarksGetParametersSource.ArtificialAnalysis => "artificial-analysis",
                BenchmarksGetParametersSource.DesignArena => "design-arena",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BenchmarksGetParametersSource? ToEnum(string value)
        {
            return value switch
            {
                "artificial-analysis" => BenchmarksGetParametersSource.ArtificialAnalysis,
                "design-arena" => BenchmarksGetParametersSource.DesignArena,
                _ => null,
            };
        }
    }
}