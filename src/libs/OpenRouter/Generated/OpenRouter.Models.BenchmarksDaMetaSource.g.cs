
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Data source identifier.
    /// </summary>
    public enum BenchmarksDaMetaSource
    {
        /// <summary>
        /// 
        /// </summary>
        DesignArena,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BenchmarksDaMetaSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BenchmarksDaMetaSource value)
        {
            return value switch
            {
                BenchmarksDaMetaSource.DesignArena => "design-arena",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BenchmarksDaMetaSource? ToEnum(string value)
        {
            return value switch
            {
                "design-arena" => BenchmarksDaMetaSource.DesignArena,
                _ => null,
            };
        }
    }
}