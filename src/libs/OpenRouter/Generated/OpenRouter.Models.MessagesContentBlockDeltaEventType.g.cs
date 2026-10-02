
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesContentBlockDeltaEventType
    {
        /// <summary>
        ///
        /// </summary>
        ContentBlockDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesContentBlockDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesContentBlockDeltaEventType value)
        {
            return value switch
            {
                MessagesContentBlockDeltaEventType.ContentBlockDelta => "content_block_delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesContentBlockDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "content_block_delta" => MessagesContentBlockDeltaEventType.ContentBlockDelta,
                _ => null,
            };
        }
    }
}