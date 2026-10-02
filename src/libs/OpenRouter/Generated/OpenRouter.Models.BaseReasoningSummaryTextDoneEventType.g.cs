
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BaseReasoningSummaryTextDoneEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseReasoningSummaryTextDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseReasoningSummaryTextDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseReasoningSummaryTextDoneEventType value)
        {
            return value switch
            {
                BaseReasoningSummaryTextDoneEventType.ResponseReasoningSummaryTextDone => "response.reasoning_summary_text.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseReasoningSummaryTextDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.reasoning_summary_text.done" => BaseReasoningSummaryTextDoneEventType.ResponseReasoningSummaryTextDone,
                _ => null,
            };
        }
    }
}