
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: artificial-analysis
    /// </summary>
    public enum UnifiedBenchmarksResponseDataItemsVariant1Source
    {
        /// <summary>
        /// artificial-analysis
        /// </summary>
        ArtificialAnalysis,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedBenchmarksResponseDataItemsVariant1SourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedBenchmarksResponseDataItemsVariant1Source value)
        {
            return value switch
            {
                UnifiedBenchmarksResponseDataItemsVariant1Source.ArtificialAnalysis => "artificial-analysis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedBenchmarksResponseDataItemsVariant1Source? ToEnum(string value)
        {
            return value switch
            {
                "artificial-analysis" => UnifiedBenchmarksResponseDataItemsVariant1Source.ArtificialAnalysis,
                _ => null,
            };
        }
    }
}