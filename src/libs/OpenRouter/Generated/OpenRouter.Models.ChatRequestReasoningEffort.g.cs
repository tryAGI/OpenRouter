
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Constrains effort on reasoning for reasoning models<br/>
    /// Example: medium
    /// </summary>
    public readonly partial struct ChatRequestReasoningEffort : global::System.IEquatable<ChatRequestReasoningEffort>
    {
        /// <summary>
        ///
        /// </summary>
        public ChatRequestReasoningEffort(string value)
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
        public static ChatRequestReasoningEffort High { get; } = new("high");

        /// <summary>
        ///
        /// </summary>
        public static ChatRequestReasoningEffort Low { get; } = new("low");

        /// <summary>
        ///
        /// </summary>
        public static ChatRequestReasoningEffort Max { get; } = new("max");

        /// <summary>
        ///
        /// </summary>
        public static ChatRequestReasoningEffort Medium { get; } = new("medium");

        /// <summary>
        ///
        /// </summary>
        public static ChatRequestReasoningEffort Minimal { get; } = new("minimal");

        /// <summary>
        ///
        /// </summary>
        public static ChatRequestReasoningEffort None { get; } = new("none");

        /// <summary>
        ///
        /// </summary>
        public static ChatRequestReasoningEffort Xhigh { get; } = new("xhigh");
        /// <summary>
        ///
        /// </summary>
        public static ChatRequestReasoningEffort FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "high" => High,
                "low" => Low,
                "max" => Max,
                "medium" => Medium,
                "minimal" => Minimal,
                "none" => None,
                "xhigh" => Xhigh,
                _ => new ChatRequestReasoningEffort(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "high" => true,
            "low" => true,
            "max" => true,
            "medium" => true,
            "minimal" => true,
            "none" => true,
            "xhigh" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ChatRequestReasoningEffort other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatRequestReasoningEffort other && Equals(other);
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
        public static bool operator ==(ChatRequestReasoningEffort left, ChatRequestReasoningEffort right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ChatRequestReasoningEffort left, ChatRequestReasoningEffort right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestReasoningEffort value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestReasoningEffort? ToEnum(string value)
        {
            return ChatRequestReasoningEffort.FromValue(value);
        }
    }
}