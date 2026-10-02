
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Example: medium
    /// </summary>
    public readonly partial struct ReasoningEffort : global::System.IEquatable<ReasoningEffort>
    {
        /// <summary>
        ///
        /// </summary>
        public ReasoningEffort(string value)
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
        public static ReasoningEffort High { get; } = new("high");

        /// <summary>
        ///
        /// </summary>
        public static ReasoningEffort Low { get; } = new("low");

        /// <summary>
        ///
        /// </summary>
        public static ReasoningEffort Max { get; } = new("max");

        /// <summary>
        ///
        /// </summary>
        public static ReasoningEffort Medium { get; } = new("medium");

        /// <summary>
        ///
        /// </summary>
        public static ReasoningEffort Minimal { get; } = new("minimal");

        /// <summary>
        ///
        /// </summary>
        public static ReasoningEffort None { get; } = new("none");

        /// <summary>
        ///
        /// </summary>
        public static ReasoningEffort Xhigh { get; } = new("xhigh");
        /// <summary>
        ///
        /// </summary>
        public static ReasoningEffort FromValue(string value)
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
                _ => new ReasoningEffort(value),
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
        public bool Equals(ReasoningEffort other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ReasoningEffort other && Equals(other);
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
        public static bool operator ==(ReasoningEffort left, ReasoningEffort right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ReasoningEffort left, ReasoningEffort right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningEffort value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningEffort? ToEnum(string value)
        {
            return ReasoningEffort.FromValue(value);
        }
    }
}