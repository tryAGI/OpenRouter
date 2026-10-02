
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BaseReasoningDoneEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseReasoningTextDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseReasoningDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseReasoningDoneEventType value)
        {
            return value switch
            {
                BaseReasoningDoneEventType.ResponseReasoningTextDone => "response.reasoning_text.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseReasoningDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.reasoning_text.done" => BaseReasoningDoneEventType.ResponseReasoningTextDone,
                _ => null,
            };
        }
    }
}