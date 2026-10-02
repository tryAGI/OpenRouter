
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ReasoningDetailServerToolCallType
    {
        /// <summary>
        ///
        /// </summary>
        ReasoningServerToolCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningDetailServerToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningDetailServerToolCallType value)
        {
            return value switch
            {
                ReasoningDetailServerToolCallType.ReasoningServerToolCall => "reasoning.server_tool_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningDetailServerToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "reasoning.server_tool_call" => ReasoningDetailServerToolCallType.ReasoningServerToolCall,
                _ => null,
            };
        }
    }
}