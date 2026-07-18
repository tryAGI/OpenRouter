
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContextCompactionItemType
    {
        /// <summary>
        /// 
        /// </summary>
        ContextCompaction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContextCompactionItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContextCompactionItemType value)
        {
            return value switch
            {
                ContextCompactionItemType.ContextCompaction => "context_compaction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContextCompactionItemType? ToEnum(string value)
        {
            return value switch
            {
                "context_compaction" => ContextCompactionItemType.ContextCompaction,
                _ => null,
            };
        }
    }
}