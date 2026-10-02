
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BaseReasoningSummaryPartAddedEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseReasoningSummaryPartAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseReasoningSummaryPartAddedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseReasoningSummaryPartAddedEventType value)
        {
            return value switch
            {
                BaseReasoningSummaryPartAddedEventType.ResponseReasoningSummaryPartAdded => "response.reasoning_summary_part.added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseReasoningSummaryPartAddedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.reasoning_summary_part.added" => BaseReasoningSummaryPartAddedEventType.ResponseReasoningSummaryPartAdded,
                _ => null,
            };
        }
    }
}