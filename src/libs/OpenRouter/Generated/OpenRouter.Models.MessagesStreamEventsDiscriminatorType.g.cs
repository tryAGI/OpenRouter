
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesStreamEventsDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        ContentBlockDelta,
        /// <summary>
        ///
        /// </summary>
        ContentBlockStart,
        /// <summary>
        ///
        /// </summary>
        ContentBlockStop,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        MessageDelta,
        /// <summary>
        ///
        /// </summary>
        MessageStart,
        /// <summary>
        ///
        /// </summary>
        MessageStop,
        /// <summary>
        ///
        /// </summary>
        Ping,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesStreamEventsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesStreamEventsDiscriminatorType value)
        {
            return value switch
            {
                MessagesStreamEventsDiscriminatorType.ContentBlockDelta => "content_block_delta",
                MessagesStreamEventsDiscriminatorType.ContentBlockStart => "content_block_start",
                MessagesStreamEventsDiscriminatorType.ContentBlockStop => "content_block_stop",
                MessagesStreamEventsDiscriminatorType.Error => "error",
                MessagesStreamEventsDiscriminatorType.MessageDelta => "message_delta",
                MessagesStreamEventsDiscriminatorType.MessageStart => "message_start",
                MessagesStreamEventsDiscriminatorType.MessageStop => "message_stop",
                MessagesStreamEventsDiscriminatorType.Ping => "ping",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesStreamEventsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "content_block_delta" => MessagesStreamEventsDiscriminatorType.ContentBlockDelta,
                "content_block_start" => MessagesStreamEventsDiscriminatorType.ContentBlockStart,
                "content_block_stop" => MessagesStreamEventsDiscriminatorType.ContentBlockStop,
                "error" => MessagesStreamEventsDiscriminatorType.Error,
                "message_delta" => MessagesStreamEventsDiscriminatorType.MessageDelta,
                "message_start" => MessagesStreamEventsDiscriminatorType.MessageStart,
                "message_stop" => MessagesStreamEventsDiscriminatorType.MessageStop,
                "ping" => MessagesStreamEventsDiscriminatorType.Ping,
                _ => null,
            };
        }
    }
}