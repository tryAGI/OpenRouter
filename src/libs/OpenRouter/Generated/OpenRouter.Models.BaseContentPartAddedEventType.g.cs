
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BaseContentPartAddedEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseContentPartAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseContentPartAddedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseContentPartAddedEventType value)
        {
            return value switch
            {
                BaseContentPartAddedEventType.ResponseContentPartAdded => "response.content_part.added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseContentPartAddedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.content_part.added" => BaseContentPartAddedEventType.ResponseContentPartAdded,
                _ => null,
            };
        }
    }
}