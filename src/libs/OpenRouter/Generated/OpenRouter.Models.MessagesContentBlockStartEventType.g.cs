
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesContentBlockStartEventType
    {
        /// <summary>
        ///
        /// </summary>
        ContentBlockStart,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesContentBlockStartEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesContentBlockStartEventType value)
        {
            return value switch
            {
                MessagesContentBlockStartEventType.ContentBlockStart => "content_block_start",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesContentBlockStartEventType? ToEnum(string value)
        {
            return value switch
            {
                "content_block_start" => MessagesContentBlockStartEventType.ContentBlockStart,
                _ => null,
            };
        }
    }
}