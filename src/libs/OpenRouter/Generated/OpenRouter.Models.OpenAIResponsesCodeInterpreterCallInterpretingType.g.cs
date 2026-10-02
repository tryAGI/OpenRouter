
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIResponsesCodeInterpreterCallInterpretingType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseCodeInterpreterCallInterpreting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIResponsesCodeInterpreterCallInterpretingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIResponsesCodeInterpreterCallInterpretingType value)
        {
            return value switch
            {
                OpenAIResponsesCodeInterpreterCallInterpretingType.ResponseCodeInterpreterCallInterpreting => "response.code_interpreter_call.interpreting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIResponsesCodeInterpreterCallInterpretingType? ToEnum(string value)
        {
            return value switch
            {
                "response.code_interpreter_call.interpreting" => OpenAIResponsesCodeInterpreterCallInterpretingType.ResponseCodeInterpreterCallInterpreting,
                _ => null,
            };
        }
    }
}