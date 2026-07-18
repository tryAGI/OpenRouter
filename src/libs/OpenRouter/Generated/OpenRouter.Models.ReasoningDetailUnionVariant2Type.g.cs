
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Discriminator value: reasoning.server_tool_call
    /// </summary>
    public enum ReasoningDetailUnionVariant2Type
    {
        /// <summary>
        /// reasoning.server_tool_call
        /// </summary>
        ReasoningServerToolCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningDetailUnionVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningDetailUnionVariant2Type value)
        {
            return value switch
            {
                ReasoningDetailUnionVariant2Type.ReasoningServerToolCall => "reasoning.server_tool_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningDetailUnionVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "reasoning.server_tool_call" => ReasoningDetailUnionVariant2Type.ReasoningServerToolCall,
                _ => null,
            };
        }
    }
}