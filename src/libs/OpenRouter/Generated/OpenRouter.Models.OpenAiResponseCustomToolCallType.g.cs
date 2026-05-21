
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenAiResponseCustomToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        CustomToolCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAiResponseCustomToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAiResponseCustomToolCallType value)
        {
            return value switch
            {
                OpenAiResponseCustomToolCallType.CustomToolCall => "custom_tool_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAiResponseCustomToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "custom_tool_call" => OpenAiResponseCustomToolCallType.CustomToolCall,
                _ => null,
            };
        }
    }
}