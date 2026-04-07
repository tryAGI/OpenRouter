
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ORAnthropicStopReason
    {
        /// <summary>
        /// 
        /// </summary>
        Compaction,
        /// <summary>
        /// 
        /// </summary>
        EndTurn,
        /// <summary>
        /// 
        /// </summary>
        MaxTokens,
        /// <summary>
        /// 
        /// </summary>
        PauseTurn,
        /// <summary>
        /// 
        /// </summary>
        Refusal,
        /// <summary>
        /// 
        /// </summary>
        StopSequence,
        /// <summary>
        /// 
        /// </summary>
        ToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ORAnthropicStopReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ORAnthropicStopReason value)
        {
            return value switch
            {
                ORAnthropicStopReason.Compaction => "compaction",
                ORAnthropicStopReason.EndTurn => "end_turn",
                ORAnthropicStopReason.MaxTokens => "max_tokens",
                ORAnthropicStopReason.PauseTurn => "pause_turn",
                ORAnthropicStopReason.Refusal => "refusal",
                ORAnthropicStopReason.StopSequence => "stop_sequence",
                ORAnthropicStopReason.ToolUse => "tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ORAnthropicStopReason? ToEnum(string value)
        {
            return value switch
            {
                "compaction" => ORAnthropicStopReason.Compaction,
                "end_turn" => ORAnthropicStopReason.EndTurn,
                "max_tokens" => ORAnthropicStopReason.MaxTokens,
                "pause_turn" => ORAnthropicStopReason.PauseTurn,
                "refusal" => ORAnthropicStopReason.Refusal,
                "stop_sequence" => ORAnthropicStopReason.StopSequence,
                "tool_use" => ORAnthropicStopReason.ToolUse,
                _ => null,
            };
        }
    }
}