
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum CompactionItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Compaction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompactionItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompactionItemType value)
        {
            return value switch
            {
                CompactionItemType.Compaction => "compaction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompactionItemType? ToEnum(string value)
        {
            return value switch
            {
                "compaction" => CompactionItemType.Compaction,
                _ => null,
            };
        }
    }
}