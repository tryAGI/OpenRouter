
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BaseReasoningSummaryPartDoneEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseReasoningSummaryPartDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseReasoningSummaryPartDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseReasoningSummaryPartDoneEventType value)
        {
            return value switch
            {
                BaseReasoningSummaryPartDoneEventType.ResponseReasoningSummaryPartDone => "response.reasoning_summary_part.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseReasoningSummaryPartDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.reasoning_summary_part.done" => BaseReasoningSummaryPartDoneEventType.ResponseReasoningSummaryPartDone,
                _ => null,
            };
        }
    }
}