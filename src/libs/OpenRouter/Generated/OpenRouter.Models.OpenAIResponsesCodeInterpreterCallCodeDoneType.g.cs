
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIResponsesCodeInterpreterCallCodeDoneType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseCodeInterpreterCallCodeDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIResponsesCodeInterpreterCallCodeDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIResponsesCodeInterpreterCallCodeDoneType value)
        {
            return value switch
            {
                OpenAIResponsesCodeInterpreterCallCodeDoneType.ResponseCodeInterpreterCallCodeDone => "response.code_interpreter_call_code.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIResponsesCodeInterpreterCallCodeDoneType? ToEnum(string value)
        {
            return value switch
            {
                "response.code_interpreter_call_code.done" => OpenAIResponsesCodeInterpreterCallCodeDoneType.ResponseCodeInterpreterCallCodeDone,
                _ => null,
            };
        }
    }
}