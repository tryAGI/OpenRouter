
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Benchmark source discriminator.
    /// </summary>
    public enum UnifiedBenchmarksDAItemSource
    {
        /// <summary>
        ///
        /// </summary>
        DesignArena,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedBenchmarksDAItemSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedBenchmarksDAItemSource value)
        {
            return value switch
            {
                UnifiedBenchmarksDAItemSource.DesignArena => "design-arena",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedBenchmarksDAItemSource? ToEnum(string value)
        {
            return value switch
            {
                "design-arena" => UnifiedBenchmarksDAItemSource.DesignArena,
                _ => null,
            };
        }
    }
}