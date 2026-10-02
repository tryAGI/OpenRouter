
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BaseTextDeltaEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseOutputTextDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseTextDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseTextDeltaEventType value)
        {
            return value switch
            {
                BaseTextDeltaEventType.ResponseOutputTextDelta => "response.output_text.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseTextDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_text.delta" => BaseTextDeltaEventType.ResponseOutputTextDelta,
                _ => null,
            };
        }
    }
}