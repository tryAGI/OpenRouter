
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Shorthand for setting reasoning effort. Equivalent to setting reasoning.effort. Cannot be used simultaneously with reasoning.effort if they differ.<br/>
    /// Example: medium
    /// </summary>
    public readonly partial struct ChatRequestReasoningEffort2 : global::System.IEquatable<ChatRequestReasoningEffort2>
    {
        /// <summary>
        ///
        /// </summary>
        public ChatRequestReasoningEffort2(string value)
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
        public static ChatRequestReasoningEffort2 High { get; } = new("high");

        /// <summary>
        ///
        /// </summary>
        public static ChatRequestReasoningEffort2 Low { get; } = new("low");

        /// <summary>
        ///
        /// </summary>
        public static ChatRequestReasoningEffort2 Max { get; } = new("max");

        /// <summary>
        ///
        /// </summary>
        public static ChatRequestReasoningEffort2 Medium { get; } = new("medium");

        /// <summary>
        ///
        /// </summary>
        public static ChatRequestReasoningEffort2 Minimal { get; } = new("minimal");

        /// <summary>
        ///
        /// </summary>
        public static ChatRequestReasoningEffort2 None { get; } = new("none");

        /// <summary>
        ///
        /// </summary>
        public static ChatRequestReasoningEffort2 Xhigh { get; } = new("xhigh");
        /// <summary>
        ///
        /// </summary>
        public static ChatRequestReasoningEffort2 FromValue(string value)
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
                _ => new ChatRequestReasoningEffort2(value),
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
        public bool Equals(ChatRequestReasoningEffort2 other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatRequestReasoningEffort2 other && Equals(other);
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
        public static bool operator ==(ChatRequestReasoningEffort2 left, ChatRequestReasoningEffort2 right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ChatRequestReasoningEffort2 left, ChatRequestReasoningEffort2 right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestReasoningEffort2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestReasoningEffort2 value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestReasoningEffort2? ToEnum(string value)
        {
            return ChatRequestReasoningEffort2.FromValue(value);
        }
    }
}