
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIResponseCustomToolCallOutputType
    {
        /// <summary>
        ///
        /// </summary>
        CustomToolCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIResponseCustomToolCallOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIResponseCustomToolCallOutputType value)
        {
            return value switch
            {
                OpenAIResponseCustomToolCallOutputType.CustomToolCallOutput => "custom_tool_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIResponseCustomToolCallOutputType? ToEnum(string value)
        {
            return value switch
            {
                "custom_tool_call_output" => OpenAIResponseCustomToolCallOutputType.CustomToolCallOutput,
                _ => null,
            };
        }
    }
}