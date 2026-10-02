
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIResponseFunctionToolCallOutputType
    {
        /// <summary>
        ///
        /// </summary>
        FunctionCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIResponseFunctionToolCallOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIResponseFunctionToolCallOutputType value)
        {
            return value switch
            {
                OpenAIResponseFunctionToolCallOutputType.FunctionCallOutput => "function_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIResponseFunctionToolCallOutputType? ToEnum(string value)
        {
            return value switch
            {
                "function_call_output" => OpenAIResponseFunctionToolCallOutputType.FunctionCallOutput,
                _ => null,
            };
        }
    }
}