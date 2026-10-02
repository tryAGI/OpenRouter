
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// `null` while streaming. `stop` when the run completed, `tool_calls` when the run is waiting for the caller to answer the streamed tool call, `error` on the terminal error chunk.
    /// </summary>
    public readonly partial struct InternChatChoiceFinishReason : global::System.IEquatable<InternChatChoiceFinishReason>
    {
        /// <summary>
        ///
        /// </summary>
        public InternChatChoiceFinishReason(string value)
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
        public static InternChatChoiceFinishReason Error { get; } = new("error");

        /// <summary>
        ///
        /// </summary>
        public static InternChatChoiceFinishReason Stop { get; } = new("stop");

        /// <summary>
        ///
        /// </summary>
        public static InternChatChoiceFinishReason ToolCalls { get; } = new("tool_calls");
        /// <summary>
        ///
        /// </summary>
        public static InternChatChoiceFinishReason FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "error" => Error,
                "stop" => Stop,
                "tool_calls" => ToolCalls,
                _ => new InternChatChoiceFinishReason(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "error" => true,
            "stop" => true,
            "tool_calls" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(InternChatChoiceFinishReason other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InternChatChoiceFinishReason other && Equals(other);
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
        public static bool operator ==(InternChatChoiceFinishReason left, InternChatChoiceFinishReason right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(InternChatChoiceFinishReason left, InternChatChoiceFinishReason right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InternChatChoiceFinishReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InternChatChoiceFinishReason value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InternChatChoiceFinishReason? ToEnum(string value)
        {
            return InternChatChoiceFinishReason.FromValue(value);
        }
    }
}