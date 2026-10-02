
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesContentBlockDeltaEventDeltaVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        InputJsonDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesContentBlockDeltaEventDeltaVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesContentBlockDeltaEventDeltaVariant2Type value)
        {
            return value switch
            {
                MessagesContentBlockDeltaEventDeltaVariant2Type.InputJsonDelta => "input_json_delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesContentBlockDeltaEventDeltaVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "input_json_delta" => MessagesContentBlockDeltaEventDeltaVariant2Type.InputJsonDelta,
                _ => null,
            };
        }
    }
}