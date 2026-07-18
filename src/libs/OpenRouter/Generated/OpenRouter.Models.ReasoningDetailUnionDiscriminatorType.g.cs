
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReasoningDetailUnionDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ReasoningEncrypted,
        /// <summary>
        /// 
        /// </summary>
        ReasoningServerToolCall,
        /// <summary>
        /// 
        /// </summary>
        ReasoningSummary,
        /// <summary>
        /// 
        /// </summary>
        ReasoningText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningDetailUnionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningDetailUnionDiscriminatorType value)
        {
            return value switch
            {
                ReasoningDetailUnionDiscriminatorType.ReasoningEncrypted => "reasoning.encrypted",
                ReasoningDetailUnionDiscriminatorType.ReasoningServerToolCall => "reasoning.server_tool_call",
                ReasoningDetailUnionDiscriminatorType.ReasoningSummary => "reasoning.summary",
                ReasoningDetailUnionDiscriminatorType.ReasoningText => "reasoning.text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningDetailUnionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "reasoning.encrypted" => ReasoningDetailUnionDiscriminatorType.ReasoningEncrypted,
                "reasoning.server_tool_call" => ReasoningDetailUnionDiscriminatorType.ReasoningServerToolCall,
                "reasoning.summary" => ReasoningDetailUnionDiscriminatorType.ReasoningSummary,
                "reasoning.text" => ReasoningDetailUnionDiscriminatorType.ReasoningText,
                _ => null,
            };
        }
    }
}