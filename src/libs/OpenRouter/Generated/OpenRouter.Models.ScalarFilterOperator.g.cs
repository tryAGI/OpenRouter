
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Comparison operator taking a scalar filter value.<br/>
    /// Example: eq
    /// </summary>
    public readonly partial struct ScalarFilterOperator : global::System.IEquatable<ScalarFilterOperator>
    {
        /// <summary>
        ///
        /// </summary>
        public ScalarFilterOperator(string value)
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
        public static ScalarFilterOperator Eq { get; } = new("eq");

        /// <summary>
        ///
        /// </summary>
        public static ScalarFilterOperator Gt { get; } = new("gt");

        /// <summary>
        ///
        /// </summary>
        public static ScalarFilterOperator Gte { get; } = new("gte");

        /// <summary>
        ///
        /// </summary>
        public static ScalarFilterOperator Lt { get; } = new("lt");

        /// <summary>
        ///
        /// </summary>
        public static ScalarFilterOperator Lte { get; } = new("lte");

        /// <summary>
        ///
        /// </summary>
        public static ScalarFilterOperator Neq { get; } = new("neq");
        /// <summary>
        ///
        /// </summary>
        public static ScalarFilterOperator FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "eq" => Eq,
                "gt" => Gt,
                "gte" => Gte,
                "lt" => Lt,
                "lte" => Lte,
                "neq" => Neq,
                _ => new ScalarFilterOperator(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "eq" => true,
            "gt" => true,
            "gte" => true,
            "lt" => true,
            "lte" => true,
            "neq" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ScalarFilterOperator other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ScalarFilterOperator other && Equals(other);
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
        public static bool operator ==(ScalarFilterOperator left, ScalarFilterOperator right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ScalarFilterOperator left, ScalarFilterOperator right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScalarFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScalarFilterOperator value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScalarFilterOperator? ToEnum(string value)
        {
            return ScalarFilterOperator.FromValue(value);
        }
    }
}