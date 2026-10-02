
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesStartEventType
    {
        /// <summary>
        ///
        /// </summary>
        MessageStart,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesStartEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesStartEventType value)
        {
            return value switch
            {
                MessagesStartEventType.MessageStart => "message_start",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesStartEventType? ToEnum(string value)
        {
            return value switch
            {
                "message_start" => MessagesStartEventType.MessageStart,
                _ => null,
            };
        }
    }
}