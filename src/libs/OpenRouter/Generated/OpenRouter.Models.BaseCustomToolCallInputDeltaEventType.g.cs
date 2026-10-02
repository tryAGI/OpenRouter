
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BaseCustomToolCallInputDeltaEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseCustomToolCallInputDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseCustomToolCallInputDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseCustomToolCallInputDeltaEventType value)
        {
            return value switch
            {
                BaseCustomToolCallInputDeltaEventType.ResponseCustomToolCallInputDelta => "response.custom_tool_call_input.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseCustomToolCallInputDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.custom_tool_call_input.delta" => BaseCustomToolCallInputDeltaEventType.ResponseCustomToolCallInputDelta,
                _ => null,
            };
        }
    }
}