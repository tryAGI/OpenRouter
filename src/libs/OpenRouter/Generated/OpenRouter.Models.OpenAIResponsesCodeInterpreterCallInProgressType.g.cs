
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIResponsesCodeInterpreterCallInProgressType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseCodeInterpreterCallInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIResponsesCodeInterpreterCallInProgressTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIResponsesCodeInterpreterCallInProgressType value)
        {
            return value switch
            {
                OpenAIResponsesCodeInterpreterCallInProgressType.ResponseCodeInterpreterCallInProgress => "response.code_interpreter_call.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIResponsesCodeInterpreterCallInProgressType? ToEnum(string value)
        {
            return value switch
            {
                "response.code_interpreter_call.in_progress" => OpenAIResponsesCodeInterpreterCallInProgressType.ResponseCodeInterpreterCallInProgress,
                _ => null,
            };
        }
    }
}