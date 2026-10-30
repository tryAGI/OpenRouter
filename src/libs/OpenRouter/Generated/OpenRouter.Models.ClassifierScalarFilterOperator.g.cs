
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Equality operator taking a scalar filter value. Ordered comparisons are not available because classification values are strings.<br/>
    /// Example: eq
    /// </summary>
    public readonly partial struct ClassifierScalarFilterOperator : global::System.IEquatable<ClassifierScalarFilterOperator>
    {
        /// <summary>
        ///
        /// </summary>
        public ClassifierScalarFilterOperator(string value)
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
        public static ClassifierScalarFilterOperator Eq { get; } = new("eq");

        /// <summary>
        ///
        /// </summary>
        public static ClassifierScalarFilterOperator Neq { get; } = new("neq");
        /// <summary>
        ///
        /// </summary>
        public static ClassifierScalarFilterOperator FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "eq" => Eq,
                "neq" => Neq,
                _ => new ClassifierScalarFilterOperator(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "eq" => true,
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
        public bool Equals(ClassifierScalarFilterOperator other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ClassifierScalarFilterOperator other && Equals(other);
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
        public static bool operator ==(ClassifierScalarFilterOperator left, ClassifierScalarFilterOperator right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ClassifierScalarFilterOperator left, ClassifierScalarFilterOperator right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClassifierScalarFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClassifierScalarFilterOperator value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClassifierScalarFilterOperator? ToEnum(string value)
        {
            return ClassifierScalarFilterOperator.FromValue(value);
        }
    }
}