
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum StopServerToolsWhenHasToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        HasToolCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StopServerToolsWhenHasToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StopServerToolsWhenHasToolCallType value)
        {
            return value switch
            {
                StopServerToolsWhenHasToolCallType.HasToolCall => "has_tool_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StopServerToolsWhenHasToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "has_tool_call" => StopServerToolsWhenHasToolCallType.HasToolCall,
                _ => null,
            };
        }
    }
}