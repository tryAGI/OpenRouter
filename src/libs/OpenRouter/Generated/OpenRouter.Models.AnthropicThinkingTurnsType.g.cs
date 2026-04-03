
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicThinkingTurnsType
    {
        /// <summary>
        /// 
        /// </summary>
        ThinkingTurns,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicThinkingTurnsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicThinkingTurnsType value)
        {
            return value switch
            {
                AnthropicThinkingTurnsType.ThinkingTurns => "thinking_turns",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicThinkingTurnsType? ToEnum(string value)
        {
            return value switch
            {
                "thinking_turns" => AnthropicThinkingTurnsType.ThinkingTurns,
                _ => null,
            };
        }
    }
}