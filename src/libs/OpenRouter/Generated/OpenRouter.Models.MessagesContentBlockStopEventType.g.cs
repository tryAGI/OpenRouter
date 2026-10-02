
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesContentBlockStopEventType
    {
        /// <summary>
        ///
        /// </summary>
        ContentBlockStop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesContentBlockStopEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesContentBlockStopEventType value)
        {
            return value switch
            {
                MessagesContentBlockStopEventType.ContentBlockStop => "content_block_stop",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesContentBlockStopEventType? ToEnum(string value)
        {
            return value switch
            {
                "content_block_stop" => MessagesContentBlockStopEventType.ContentBlockStop,
                _ => null,
            };
        }
    }
}