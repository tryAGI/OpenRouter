
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BaseRefusalDoneEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseRefusalDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseRefusalDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseRefusalDoneEventType value)
        {
            return value switch
            {
                BaseRefusalDoneEventType.ResponseRefusalDone => "response.refusal.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseRefusalDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.refusal.done" => BaseRefusalDoneEventType.ResponseRefusalDone,
                _ => null,
            };
        }
    }
}