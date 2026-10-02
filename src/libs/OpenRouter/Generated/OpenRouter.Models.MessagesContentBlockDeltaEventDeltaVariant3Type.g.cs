
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesContentBlockDeltaEventDeltaVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        ThinkingDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesContentBlockDeltaEventDeltaVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesContentBlockDeltaEventDeltaVariant3Type value)
        {
            return value switch
            {
                MessagesContentBlockDeltaEventDeltaVariant3Type.ThinkingDelta => "thinking_delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesContentBlockDeltaEventDeltaVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "thinking_delta" => MessagesContentBlockDeltaEventDeltaVariant3Type.ThinkingDelta,
                _ => null,
            };
        }
    }
}