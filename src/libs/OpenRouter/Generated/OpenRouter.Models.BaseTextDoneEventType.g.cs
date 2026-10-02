
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BaseTextDoneEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseOutputTextDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseTextDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseTextDoneEventType value)
        {
            return value switch
            {
                BaseTextDoneEventType.ResponseOutputTextDone => "response.output_text.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseTextDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_text.done" => BaseTextDoneEventType.ResponseOutputTextDone,
                _ => null,
            };
        }
    }
}