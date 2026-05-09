
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenAiResponseCustomToolCallOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        CustomToolCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAiResponseCustomToolCallOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiResponseCustomToolCallOutputType value)
        {
            return value switch
            {
                OpenAiResponseCustomToolCallOutputType.CustomToolCallOutput => "custom_tool_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiResponseCustomToolCallOutputType? ToEnum(string value)
        {
            return value switch
            {
                "custom_tool_call_output" => OpenAiResponseCustomToolCallOutputType.CustomToolCallOutput,
                _ => null,
            };
        }
    }
}