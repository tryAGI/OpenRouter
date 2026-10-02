
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesContentBlockDeltaEventDeltaVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        TextDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesContentBlockDeltaEventDeltaVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesContentBlockDeltaEventDeltaVariant1Type value)
        {
            return value switch
            {
                MessagesContentBlockDeltaEventDeltaVariant1Type.TextDelta => "text_delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesContentBlockDeltaEventDeltaVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "text_delta" => MessagesContentBlockDeltaEventDeltaVariant1Type.TextDelta,
                _ => null,
            };
        }
    }
}