
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Example: end_turn
    /// </summary>
    public readonly partial struct ORAnthropicStopReason : global::System.IEquatable<ORAnthropicStopReason>
    {
        /// <summary>
        ///
        /// </summary>
        public ORAnthropicStopReason(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        ///
        /// </summary>
        public static ORAnthropicStopReason Compaction { get; } = new("compaction");

        /// <summary>
        ///
        /// </summary>
        public static ORAnthropicStopReason EndTurn { get; } = new("end_turn");

        /// <summary>
        ///
        /// </summary>
        public static ORAnthropicStopReason MaxTokens { get; } = new("max_tokens");

        /// <summary>
        ///
        /// </summary>
        public static ORAnthropicStopReason ModelContextWindowExceeded { get; } = new("model_context_window_exceeded");

        /// <summary>
        ///
        /// </summary>
        public static ORAnthropicStopReason PauseTurn { get; } = new("pause_turn");

        /// <summary>
        ///
        /// </summary>
        public static ORAnthropicStopReason Refusal { get; } = new("refusal");

        /// <summary>
        ///
        /// </summary>
        public static ORAnthropicStopReason StopSequence { get; } = new("stop_sequence");

        /// <summary>
        ///
        /// </summary>
        public static ORAnthropicStopReason ToolUse { get; } = new("tool_use");
        /// <summary>
        ///
        /// </summary>
        public static ORAnthropicStopReason FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "compaction" => Compaction,
                "end_turn" => EndTurn,
                "max_tokens" => MaxTokens,
                "model_context_window_exceeded" => ModelContextWindowExceeded,
                "pause_turn" => PauseTurn,
                "refusal" => Refusal,
                "stop_sequence" => StopSequence,
                "tool_use" => ToolUse,
                _ => new ORAnthropicStopReason(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "compaction" => true,
            "end_turn" => true,
            "max_tokens" => true,
            "model_context_window_exceeded" => true,
            "pause_turn" => true,
            "refusal" => true,
            "stop_sequence" => true,
            "tool_use" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ORAnthropicStopReason other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ORAnthropicStopReason other && Equals(other);
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            return global::System.StringComparer.Ordinal.GetHashCode(Value ?? string.Empty);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ORAnthropicStopReason left, ORAnthropicStopReason right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ORAnthropicStopReason left, ORAnthropicStopReason right) => !left.Equals(right);
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
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ORAnthropicStopReason? ToEnum(string value)
        {
            return ORAnthropicStopReason.FromValue(value);
        }
    }
}