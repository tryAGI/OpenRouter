
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesResultUsageIterationsItemsOneOf0Type
    {
        /// <summary>
        /// 
        /// </summary>
        Compaction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesResultUsageIterationsItemsOneOf0TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesResultUsageIterationsItemsOneOf0Type value)
        {
            return value switch
            {
                MessagesResultUsageIterationsItemsOneOf0Type.Compaction => "compaction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesResultUsageIterationsItemsOneOf0Type? ToEnum(string value)
        {
            return value switch
            {
                "compaction" => MessagesResultUsageIterationsItemsOneOf0Type.Compaction,
                _ => null,
            };
        }
    }
}