
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Operator identifier used in filter definitions<br/>
    /// Example: eq
    /// </summary>
    public readonly partial struct OperatorName : global::System.IEquatable<OperatorName>
    {
        /// <summary>
        ///
        /// </summary>
        public OperatorName(string value)
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
        public static OperatorName Eq { get; } = new("eq");

        /// <summary>
        ///
        /// </summary>
        public static OperatorName Gt { get; } = new("gt");

        /// <summary>
        ///
        /// </summary>
        public static OperatorName Gte { get; } = new("gte");

        /// <summary>
        ///
        /// </summary>
        public static OperatorName In { get; } = new("in");

        /// <summary>
        ///
        /// </summary>
        public static OperatorName Lt { get; } = new("lt");

        /// <summary>
        ///
        /// </summary>
        public static OperatorName Lte { get; } = new("lte");

        /// <summary>
        ///
        /// </summary>
        public static OperatorName Neq { get; } = new("neq");

        /// <summary>
        ///
        /// </summary>
        public static OperatorName NotIn { get; } = new("not_in");
        /// <summary>
        ///
        /// </summary>
        public static OperatorName FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "eq" => Eq,
                "gt" => Gt,
                "gte" => Gte,
                "in" => In,
                "lt" => Lt,
                "lte" => Lte,
                "neq" => Neq,
                "not_in" => NotIn,
                _ => new OperatorName(value),
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
            "in" => true,
            "lt" => true,
            "lte" => true,
            "neq" => true,
            "not_in" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(OperatorName other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OperatorName other && Equals(other);
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
        public static bool operator ==(OperatorName left, OperatorName right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OperatorName left, OperatorName right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OperatorNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OperatorName value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OperatorName? ToEnum(string value)
        {
            return OperatorName.FromValue(value);
        }
    }
}