
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum BaseMessagesResultUsageIterationsItemsOneOf0Type
    {
        /// <summary>
        /// 
        /// </summary>
        Compaction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultUsageIterationsItemsOneOf0TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultUsageIterationsItemsOneOf0Type value)
        {
            return value switch
            {
                BaseMessagesResultUsageIterationsItemsOneOf0Type.Compaction => "compaction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultUsageIterationsItemsOneOf0Type? ToEnum(string value)
        {
            return value switch
            {
                "compaction" => BaseMessagesResultUsageIterationsItemsOneOf0Type.Compaction,
                _ => null,
            };
        }
    }
}