
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Default Value: and
    /// </summary>
    public readonly partial struct ObservabilityFilterRuleGroupLogic : global::System.IEquatable<ObservabilityFilterRuleGroupLogic>
    {
        /// <summary>
        ///
        /// </summary>
        public ObservabilityFilterRuleGroupLogic(string value)
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
        public static ObservabilityFilterRuleGroupLogic And { get; } = new("and");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityFilterRuleGroupLogic Or { get; } = new("or");
        /// <summary>
        ///
        /// </summary>
        public static ObservabilityFilterRuleGroupLogic FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "and" => And,
                "or" => Or,
                _ => new ObservabilityFilterRuleGroupLogic(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "and" => true,
            "or" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ObservabilityFilterRuleGroupLogic other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ObservabilityFilterRuleGroupLogic other && Equals(other);
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
        public static bool operator ==(ObservabilityFilterRuleGroupLogic left, ObservabilityFilterRuleGroupLogic right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ObservabilityFilterRuleGroupLogic left, ObservabilityFilterRuleGroupLogic right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityFilterRuleGroupLogicExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityFilterRuleGroupLogic value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityFilterRuleGroupLogic? ToEnum(string value)
        {
            return ObservabilityFilterRuleGroupLogic.FromValue(value);
        }
    }
}