
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OutputItemCompactionType
    {
        /// <summary>
        ///
        /// </summary>
        Compaction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputItemCompactionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputItemCompactionType value)
        {
            return value switch
            {
                OutputItemCompactionType.Compaction => "compaction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputItemCompactionType? ToEnum(string value)
        {
            return value switch
            {
                "compaction" => OutputItemCompactionType.Compaction,
                _ => null,
            };
        }
    }
}