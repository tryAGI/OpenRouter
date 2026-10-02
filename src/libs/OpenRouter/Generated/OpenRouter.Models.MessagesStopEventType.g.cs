
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesStopEventType
    {
        /// <summary>
        ///
        /// </summary>
        MessageStop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesStopEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesStopEventType value)
        {
            return value switch
            {
                MessagesStopEventType.MessageStop => "message_stop",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesStopEventType? ToEnum(string value)
        {
            return value switch
            {
                "message_stop" => MessagesStopEventType.MessageStop,
                _ => null,
            };
        }
    }
}