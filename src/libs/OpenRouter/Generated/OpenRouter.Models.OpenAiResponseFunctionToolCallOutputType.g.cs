
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenAiResponseFunctionToolCallOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        FunctionCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAiResponseFunctionToolCallOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiResponseFunctionToolCallOutputType value)
        {
            return value switch
            {
                OpenAiResponseFunctionToolCallOutputType.FunctionCallOutput => "function_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiResponseFunctionToolCallOutputType? ToEnum(string value)
        {
            return value switch
            {
                "function_call_output" => OpenAiResponseFunctionToolCallOutputType.FunctionCallOutput,
                _ => null,
            };
        }
    }
}