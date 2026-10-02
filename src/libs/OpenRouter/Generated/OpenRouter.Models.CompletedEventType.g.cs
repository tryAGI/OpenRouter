
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum CompletedEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletedEventType value)
        {
            return value switch
            {
                CompletedEventType.ResponseCompleted => "response.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.completed" => CompletedEventType.ResponseCompleted,
                _ => null,
            };
        }
    }
}