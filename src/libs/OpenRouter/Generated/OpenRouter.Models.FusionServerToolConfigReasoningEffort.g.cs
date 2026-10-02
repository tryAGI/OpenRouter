
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Reasoning effort level for panelist and analyst inner calls.
    /// </summary>
    public readonly partial struct FusionServerToolConfigReasoningEffort : global::System.IEquatable<FusionServerToolConfigReasoningEffort>
    {
        /// <summary>
        ///
        /// </summary>
        public FusionServerToolConfigReasoningEffort(string value)
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
        public static FusionServerToolConfigReasoningEffort High { get; } = new("high");

        /// <summary>
        ///
        /// </summary>
        public static FusionServerToolConfigReasoningEffort Low { get; } = new("low");

        /// <summary>
        ///
        /// </summary>
        public static FusionServerToolConfigReasoningEffort Max { get; } = new("max");

        /// <summary>
        ///
        /// </summary>
        public static FusionServerToolConfigReasoningEffort Medium { get; } = new("medium");

        /// <summary>
        ///
        /// </summary>
        public static FusionServerToolConfigReasoningEffort Minimal { get; } = new("minimal");

        /// <summary>
        ///
        /// </summary>
        public static FusionServerToolConfigReasoningEffort None { get; } = new("none");

        /// <summary>
        ///
        /// </summary>
        public static FusionServerToolConfigReasoningEffort Xhigh { get; } = new("xhigh");
        /// <summary>
        ///
        /// </summary>
        public static FusionServerToolConfigReasoningEffort FromValue(string value)
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
                _ => new FusionServerToolConfigReasoningEffort(value),
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
        public bool Equals(FusionServerToolConfigReasoningEffort other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FusionServerToolConfigReasoningEffort other && Equals(other);
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
        public static bool operator ==(FusionServerToolConfigReasoningEffort left, FusionServerToolConfigReasoningEffort right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(FusionServerToolConfigReasoningEffort left, FusionServerToolConfigReasoningEffort right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FusionServerToolConfigReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FusionServerToolConfigReasoningEffort value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FusionServerToolConfigReasoningEffort? ToEnum(string value)
        {
            return FusionServerToolConfigReasoningEffort.FromValue(value);
        }
    }
}