
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum UnifiedBenchmarksResponseDataItemsDiscriminatorSource
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
    public static class UnifiedBenchmarksResponseDataItemsDiscriminatorSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedBenchmarksResponseDataItemsDiscriminatorSource value)
        {
            return value switch
            {
                UnifiedBenchmarksResponseDataItemsDiscriminatorSource.ArtificialAnalysis => "artificial-analysis",
                UnifiedBenchmarksResponseDataItemsDiscriminatorSource.DesignArena => "design-arena",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedBenchmarksResponseDataItemsDiscriminatorSource? ToEnum(string value)
        {
            return value switch
            {
                "artificial-analysis" => UnifiedBenchmarksResponseDataItemsDiscriminatorSource.ArtificialAnalysis,
                "design-arena" => UnifiedBenchmarksResponseDataItemsDiscriminatorSource.DesignArena,
                _ => null,
            };
        }
    }
}