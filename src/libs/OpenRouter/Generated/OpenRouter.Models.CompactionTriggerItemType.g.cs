
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum CompactionTriggerItemType
    {
        /// <summary>
        ///
        /// </summary>
        CompactionTrigger,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompactionTriggerItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompactionTriggerItemType value)
        {
            return value switch
            {
                CompactionTriggerItemType.CompactionTrigger => "compaction_trigger",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompactionTriggerItemType? ToEnum(string value)
        {
            return value switch
            {
                "compaction_trigger" => CompactionTriggerItemType.CompactionTrigger,
                _ => null,
            };
        }
    }
}