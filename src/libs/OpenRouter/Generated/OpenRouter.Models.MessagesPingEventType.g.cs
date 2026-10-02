
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesPingEventType
    {
        /// <summary>
        ///
        /// </summary>
        Ping,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesPingEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesPingEventType value)
        {
            return value switch
            {
                MessagesPingEventType.Ping => "ping",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesPingEventType? ToEnum(string value)
        {
            return value switch
            {
                "ping" => MessagesPingEventType.Ping,
                _ => null,
            };
        }
    }
}