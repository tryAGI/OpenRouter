
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIResponseFunctionToolCallType
    {
        /// <summary>
        ///
        /// </summary>
        FunctionCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIResponseFunctionToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIResponseFunctionToolCallType value)
        {
            return value switch
            {
                OpenAIResponseFunctionToolCallType.FunctionCall => "function_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIResponseFunctionToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "function_call" => OpenAIResponseFunctionToolCallType.FunctionCall,
                _ => null,
            };
        }
    }
}