
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum OpenAIResponseCustomToolCallType
    {
        /// <summary>
        ///
        /// </summary>
        CustomToolCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIResponseCustomToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIResponseCustomToolCallType value)
        {
            return value switch
            {
                OpenAIResponseCustomToolCallType.CustomToolCall => "custom_tool_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIResponseCustomToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "custom_tool_call" => OpenAIResponseCustomToolCallType.CustomToolCall,
                _ => null,
            };
        }
    }
}