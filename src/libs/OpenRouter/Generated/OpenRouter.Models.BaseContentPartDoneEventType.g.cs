
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BaseContentPartDoneEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseContentPartDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseContentPartDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseContentPartDoneEventType value)
        {
            return value switch
            {
                BaseContentPartDoneEventType.ResponseContentPartDone => "response.content_part.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseContentPartDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.content_part.done" => BaseContentPartDoneEventType.ResponseContentPartDone,
                _ => null,
            };
        }
    }
}