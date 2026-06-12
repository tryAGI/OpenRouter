
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Data source identifier.
    /// </summary>
    public enum BenchmarksAaMetaSource
    {
        /// <summary>
        /// 
        /// </summary>
        ArtificialAnalysis,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BenchmarksAaMetaSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BenchmarksAaMetaSource value)
        {
            return value switch
            {
                BenchmarksAaMetaSource.ArtificialAnalysis => "artificial-analysis",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BenchmarksAaMetaSource? ToEnum(string value)
        {
            return value switch
            {
                "artificial-analysis" => BenchmarksAaMetaSource.ArtificialAnalysis,
                _ => null,
            };
        }
    }
}