
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum MessagesContentBlockDeltaEventDeltaVariant5Type
    {
        /// <summary>
        ///
        /// </summary>
        CitationsDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesContentBlockDeltaEventDeltaVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesContentBlockDeltaEventDeltaVariant5Type value)
        {
            return value switch
            {
                MessagesContentBlockDeltaEventDeltaVariant5Type.CitationsDelta => "citations_delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesContentBlockDeltaEventDeltaVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "citations_delta" => MessagesContentBlockDeltaEventDeltaVariant5Type.CitationsDelta,
                _ => null,
            };
        }
    }
}