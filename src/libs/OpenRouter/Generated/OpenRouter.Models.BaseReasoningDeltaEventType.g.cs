
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BaseReasoningDeltaEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseReasoningTextDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseReasoningDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseReasoningDeltaEventType value)
        {
            return value switch
            {
                BaseReasoningDeltaEventType.ResponseReasoningTextDelta => "response.reasoning_text.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseReasoningDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.reasoning_text.delta" => BaseReasoningDeltaEventType.ResponseReasoningTextDelta,
                _ => null,
            };
        }
    }
}