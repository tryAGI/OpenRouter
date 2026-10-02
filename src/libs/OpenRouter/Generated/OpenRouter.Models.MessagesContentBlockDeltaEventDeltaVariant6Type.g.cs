
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesContentBlockDeltaEventDeltaVariant6Type
    {
        /// <summary>
        ///
        /// </summary>
        CompactionDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesContentBlockDeltaEventDeltaVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesContentBlockDeltaEventDeltaVariant6Type value)
        {
            return value switch
            {
                MessagesContentBlockDeltaEventDeltaVariant6Type.CompactionDelta => "compaction_delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesContentBlockDeltaEventDeltaVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "compaction_delta" => MessagesContentBlockDeltaEventDeltaVariant6Type.CompactionDelta,
                _ => null,
            };
        }
    }
}