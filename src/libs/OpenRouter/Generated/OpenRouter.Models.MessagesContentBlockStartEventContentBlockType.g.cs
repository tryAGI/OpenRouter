
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesContentBlockStartEventContentBlockType
    {
        /// <summary>
        ///
        /// </summary>
        Compaction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesContentBlockStartEventContentBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesContentBlockStartEventContentBlockType value)
        {
            return value switch
            {
                MessagesContentBlockStartEventContentBlockType.Compaction => "compaction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesContentBlockStartEventContentBlockType? ToEnum(string value)
        {
            return value switch
            {
                "compaction" => MessagesContentBlockStartEventContentBlockType.Compaction,
                _ => null,
            };
        }
    }
}