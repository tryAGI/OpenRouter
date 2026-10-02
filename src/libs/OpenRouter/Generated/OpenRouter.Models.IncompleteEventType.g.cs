
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum IncompleteEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseIncomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IncompleteEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IncompleteEventType value)
        {
            return value switch
            {
                IncompleteEventType.ResponseIncomplete => "response.incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IncompleteEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.incomplete" => IncompleteEventType.ResponseIncomplete,
                _ => null,
            };
        }
    }
}