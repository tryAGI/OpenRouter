
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Benchmark source discriminator.
    /// </summary>
    public enum UnifiedBenchmarksSearchItemSource
    {
        /// <summary>
        ///
        /// </summary>
        Openrouter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedBenchmarksSearchItemSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedBenchmarksSearchItemSource value)
        {
            return value switch
            {
                UnifiedBenchmarksSearchItemSource.Openrouter => "openrouter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedBenchmarksSearchItemSource? ToEnum(string value)
        {
            return value switch
            {
                "openrouter" => UnifiedBenchmarksSearchItemSource.Openrouter,
                _ => null,
            };
        }
    }
}