
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ObservabilityFilterRuleGroupRuleOperator : global::System.IEquatable<ObservabilityFilterRuleGroupRuleOperator>
    {
        /// <summary>
        ///
        /// </summary>
        public ObservabilityFilterRuleGroupRuleOperator(string value)
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
        public static ObservabilityFilterRuleGroupRuleOperator Contains { get; } = new("contains");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityFilterRuleGroupRuleOperator EndsWith { get; } = new("ends_with");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityFilterRuleGroupRuleOperator EqualsValue { get; } = new("equals");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityFilterRuleGroupRuleOperator Exists { get; } = new("exists");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityFilterRuleGroupRuleOperator Gt { get; } = new("gt");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityFilterRuleGroupRuleOperator Gte { get; } = new("gte");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityFilterRuleGroupRuleOperator Lt { get; } = new("lt");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityFilterRuleGroupRuleOperator Lte { get; } = new("lte");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityFilterRuleGroupRuleOperator NotContains { get; } = new("not_contains");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityFilterRuleGroupRuleOperator NotEquals { get; } = new("not_equals");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityFilterRuleGroupRuleOperator NotExists { get; } = new("not_exists");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityFilterRuleGroupRuleOperator Regex { get; } = new("regex");

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityFilterRuleGroupRuleOperator StartsWith { get; } = new("starts_with");
        /// <summary>
        ///
        /// </summary>
        public static ObservabilityFilterRuleGroupRuleOperator FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "contains" => Contains,
                "ends_with" => EndsWith,
                "equals" => EqualsValue,
                "exists" => Exists,
                "gt" => Gt,
                "gte" => Gte,
                "lt" => Lt,
                "lte" => Lte,
                "not_contains" => NotContains,
                "not_equals" => NotEquals,
                "not_exists" => NotExists,
                "regex" => Regex,
                "starts_with" => StartsWith,
                _ => new ObservabilityFilterRuleGroupRuleOperator(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "contains" => true,
            "ends_with" => true,
            "equals" => true,
            "exists" => true,
            "gt" => true,
            "gte" => true,
            "lt" => true,
            "lte" => true,
            "not_contains" => true,
            "not_equals" => true,
            "not_exists" => true,
            "regex" => true,
            "starts_with" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ObservabilityFilterRuleGroupRuleOperator other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ObservabilityFilterRuleGroupRuleOperator other && Equals(other);
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
        public static bool operator ==(ObservabilityFilterRuleGroupRuleOperator left, ObservabilityFilterRuleGroupRuleOperator right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ObservabilityFilterRuleGroupRuleOperator left, ObservabilityFilterRuleGroupRuleOperator right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityFilterRuleGroupRuleOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityFilterRuleGroupRuleOperator value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityFilterRuleGroupRuleOperator? ToEnum(string value)
        {
            return ObservabilityFilterRuleGroupRuleOperator.FromValue(value);
        }
    }
}