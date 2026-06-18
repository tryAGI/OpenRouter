
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The source filter applied.
    /// </summary>
    public enum UnifiedBenchmarksMetaSource
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
    public static class UnifiedBenchmarksMetaSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedBenchmarksMetaSource value)
        {
            return value switch
            {
                UnifiedBenchmarksMetaSource.ArtificialAnalysis => "artificial-analysis",
                UnifiedBenchmarksMetaSource.DesignArena => "design-arena",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedBenchmarksMetaSource? ToEnum(string value)
        {
            return value switch
            {
                "artificial-analysis" => UnifiedBenchmarksMetaSource.ArtificialAnalysis,
                "design-arena" => UnifiedBenchmarksMetaSource.DesignArena,
                _ => null,
            };
        }
    }
}