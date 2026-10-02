
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Example: stop
    /// </summary>
    public readonly partial struct ChatFinishReasonEnum : global::System.IEquatable<ChatFinishReasonEnum>
    {
        /// <summary>
        ///
        /// </summary>
        public ChatFinishReasonEnum(string value)
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
        public static ChatFinishReasonEnum ContentFilter { get; } = new("content_filter");

        /// <summary>
        ///
        /// </summary>
        public static ChatFinishReasonEnum Error { get; } = new("error");

        /// <summary>
        ///
        /// </summary>
        public static ChatFinishReasonEnum Length { get; } = new("length");

        /// <summary>
        ///
        /// </summary>
        public static ChatFinishReasonEnum Stop { get; } = new("stop");

        /// <summary>
        ///
        /// </summary>
        public static ChatFinishReasonEnum ToolCalls { get; } = new("tool_calls");
        /// <summary>
        ///
        /// </summary>
        public static ChatFinishReasonEnum FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "content_filter" => ContentFilter,
                "error" => Error,
                "length" => Length,
                "stop" => Stop,
                "tool_calls" => ToolCalls,
                _ => new ChatFinishReasonEnum(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "content_filter" => true,
            "error" => true,
            "length" => true,
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
        public bool Equals(ChatFinishReasonEnum other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatFinishReasonEnum other && Equals(other);
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
        public static bool operator ==(ChatFinishReasonEnum left, ChatFinishReasonEnum right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ChatFinishReasonEnum left, ChatFinishReasonEnum right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatFinishReasonEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatFinishReasonEnum value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatFinishReasonEnum? ToEnum(string value)
        {
            return ChatFinishReasonEnum.FromValue(value);
        }
    }
}