
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesDeltaEventType
    {
        /// <summary>
        ///
        /// </summary>
        MessageDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesDeltaEventType value)
        {
            return value switch
            {
                MessagesDeltaEventType.MessageDelta => "message_delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "message_delta" => MessagesDeltaEventType.MessageDelta,
                _ => null,
            };
        }
    }
}