
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Reasoning effort level for the subagent call.
    /// </summary>
    public readonly partial struct SubagentReasoningEffort : global::System.IEquatable<SubagentReasoningEffort>
    {
        /// <summary>
        ///
        /// </summary>
        public SubagentReasoningEffort(string value)
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
        public static SubagentReasoningEffort High { get; } = new("high");

        /// <summary>
        ///
        /// </summary>
        public static SubagentReasoningEffort Low { get; } = new("low");

        /// <summary>
        ///
        /// </summary>
        public static SubagentReasoningEffort Max { get; } = new("max");

        /// <summary>
        ///
        /// </summary>
        public static SubagentReasoningEffort Medium { get; } = new("medium");

        /// <summary>
        ///
        /// </summary>
        public static SubagentReasoningEffort Minimal { get; } = new("minimal");

        /// <summary>
        ///
        /// </summary>
        public static SubagentReasoningEffort None { get; } = new("none");

        /// <summary>
        ///
        /// </summary>
        public static SubagentReasoningEffort Xhigh { get; } = new("xhigh");
        /// <summary>
        ///
        /// </summary>
        public static SubagentReasoningEffort FromValue(string value)
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
                _ => new SubagentReasoningEffort(value),
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
        public bool Equals(SubagentReasoningEffort other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SubagentReasoningEffort other && Equals(other);
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
        public static bool operator ==(SubagentReasoningEffort left, SubagentReasoningEffort right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SubagentReasoningEffort left, SubagentReasoningEffort right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubagentReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubagentReasoningEffort value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubagentReasoningEffort? ToEnum(string value)
        {
            return SubagentReasoningEffort.FromValue(value);
        }
    }
}