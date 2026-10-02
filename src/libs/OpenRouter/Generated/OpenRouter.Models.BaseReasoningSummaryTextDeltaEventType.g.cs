
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BaseReasoningSummaryTextDeltaEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseReasoningSummaryTextDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseReasoningSummaryTextDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseReasoningSummaryTextDeltaEventType value)
        {
            return value switch
            {
                BaseReasoningSummaryTextDeltaEventType.ResponseReasoningSummaryTextDelta => "response.reasoning_summary_text.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseReasoningSummaryTextDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.reasoning_summary_text.delta" => BaseReasoningSummaryTextDeltaEventType.ResponseReasoningSummaryTextDelta,
                _ => null,
            };
        }
    }
}