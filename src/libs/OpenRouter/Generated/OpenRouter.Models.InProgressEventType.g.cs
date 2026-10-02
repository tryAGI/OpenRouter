
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum InProgressEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InProgressEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InProgressEventType value)
        {
            return value switch
            {
                InProgressEventType.ResponseInProgress => "response.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InProgressEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.in_progress" => InProgressEventType.ResponseInProgress,
                _ => null,
            };
        }
    }
}