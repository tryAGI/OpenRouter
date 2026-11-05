
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputCompactionItemType
    {
        /// <summary>
        ///
        /// </summary>
        Compaction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputCompactionItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputCompactionItemType value)
        {
            return value switch
            {
                OutputCompactionItemType.Compaction => "compaction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputCompactionItemType? ToEnum(string value)
        {
            return value switch
            {
                "compaction" => OutputCompactionItemType.Compaction,
                _ => null,
            };
        }
    }
}