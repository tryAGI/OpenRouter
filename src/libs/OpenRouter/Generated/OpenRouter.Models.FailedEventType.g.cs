
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum FailedEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FailedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FailedEventType value)
        {
            return value switch
            {
                FailedEventType.ResponseFailed => "response.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FailedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.failed" => FailedEventType.ResponseFailed,
                _ => null,
            };
        }
    }
}