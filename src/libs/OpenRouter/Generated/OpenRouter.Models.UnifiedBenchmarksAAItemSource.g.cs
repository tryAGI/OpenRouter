
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Benchmark source discriminator.
    /// </summary>
    public enum UnifiedBenchmarksAAItemSource
    {
        /// <summary>
        ///
        /// </summary>
        ArtificialAnalysis,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedBenchmarksAAItemSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedBenchmarksAAItemSource value)
        {
            return value switch
            {
                UnifiedBenchmarksAAItemSource.ArtificialAnalysis => "artificial-analysis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedBenchmarksAAItemSource? ToEnum(string value)
        {
            return value switch
            {
                "artificial-analysis" => UnifiedBenchmarksAAItemSource.ArtificialAnalysis,
                _ => null,
            };
        }
    }
}