
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BaseCustomToolCallInputDoneEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseCustomToolCallInputDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseCustomToolCallInputDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseCustomToolCallInputDoneEventType value)
        {
            return value switch
            {
                BaseCustomToolCallInputDoneEventType.ResponseCustomToolCallInputDone => "response.custom_tool_call_input.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseCustomToolCallInputDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.custom_tool_call_input.done" => BaseCustomToolCallInputDoneEventType.ResponseCustomToolCallInputDone,
                _ => null,
            };
        }
    }
}