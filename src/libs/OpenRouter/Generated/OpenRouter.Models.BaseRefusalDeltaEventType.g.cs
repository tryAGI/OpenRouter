
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BaseRefusalDeltaEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseRefusalDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseRefusalDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseRefusalDeltaEventType value)
        {
            return value switch
            {
                BaseRefusalDeltaEventType.ResponseRefusalDelta => "response.refusal.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseRefusalDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.refusal.delta" => BaseRefusalDeltaEventType.ResponseRefusalDelta,
                _ => null,
            };
        }
    }
}