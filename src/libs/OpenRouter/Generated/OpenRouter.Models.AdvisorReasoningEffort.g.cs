
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Reasoning effort level for the advisor call.
    /// </summary>
    public readonly partial struct AdvisorReasoningEffort : global::System.IEquatable<AdvisorReasoningEffort>
    {
        /// <summary>
        ///
        /// </summary>
        public AdvisorReasoningEffort(string value)
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
        public static AdvisorReasoningEffort High { get; } = new("high");

        /// <summary>
        ///
        /// </summary>
        public static AdvisorReasoningEffort Low { get; } = new("low");

        /// <summary>
        ///
        /// </summary>
        public static AdvisorReasoningEffort Max { get; } = new("max");

        /// <summary>
        ///
        /// </summary>
        public static AdvisorReasoningEffort Medium { get; } = new("medium");

        /// <summary>
        ///
        /// </summary>
        public static AdvisorReasoningEffort Minimal { get; } = new("minimal");

        /// <summary>
        ///
        /// </summary>
        public static AdvisorReasoningEffort None { get; } = new("none");

        /// <summary>
        ///
        /// </summary>
        public static AdvisorReasoningEffort Xhigh { get; } = new("xhigh");
        /// <summary>
        ///
        /// </summary>
        public static AdvisorReasoningEffort FromValue(string value)
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
                _ => new AdvisorReasoningEffort(value),
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
        public bool Equals(AdvisorReasoningEffort other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AdvisorReasoningEffort other && Equals(other);
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
        public static bool operator ==(AdvisorReasoningEffort left, AdvisorReasoningEffort right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AdvisorReasoningEffort left, AdvisorReasoningEffort right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AdvisorReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdvisorReasoningEffort value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdvisorReasoningEffort? ToEnum(string value)
        {
            return AdvisorReasoningEffort.FromValue(value);
        }
    }
}