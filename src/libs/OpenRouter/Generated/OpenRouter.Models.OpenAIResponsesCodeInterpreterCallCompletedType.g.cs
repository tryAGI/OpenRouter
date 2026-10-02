
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIResponsesCodeInterpreterCallCompletedType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseCodeInterpreterCallCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIResponsesCodeInterpreterCallCompletedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIResponsesCodeInterpreterCallCompletedType value)
        {
            return value switch
            {
                OpenAIResponsesCodeInterpreterCallCompletedType.ResponseCodeInterpreterCallCompleted => "response.code_interpreter_call.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIResponsesCodeInterpreterCallCompletedType? ToEnum(string value)
        {
            return value switch
            {
                "response.code_interpreter_call.completed" => OpenAIResponsesCodeInterpreterCallCompletedType.ResponseCodeInterpreterCallCompleted,
                _ => null,
            };
        }
    }
}