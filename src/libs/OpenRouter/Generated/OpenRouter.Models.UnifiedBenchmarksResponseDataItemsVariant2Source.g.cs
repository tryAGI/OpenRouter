
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: design-arena
    /// </summary>
    public enum UnifiedBenchmarksResponseDataItemsVariant2Source
    {
        /// <summary>
        /// design-arena
        /// </summary>
        DesignArena,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedBenchmarksResponseDataItemsVariant2SourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedBenchmarksResponseDataItemsVariant2Source value)
        {
            return value switch
            {
                UnifiedBenchmarksResponseDataItemsVariant2Source.DesignArena => "design-arena",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedBenchmarksResponseDataItemsVariant2Source? ToEnum(string value)
        {
            return value switch
            {
                "design-arena" => UnifiedBenchmarksResponseDataItemsVariant2Source.DesignArena,
                _ => null,
            };
        }
    }
}