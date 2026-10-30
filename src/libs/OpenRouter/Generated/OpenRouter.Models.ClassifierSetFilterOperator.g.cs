
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Set-membership operator taking an array filter value.<br/>
    /// Example: in
    /// </summary>
    public readonly partial struct ClassifierSetFilterOperator : global::System.IEquatable<ClassifierSetFilterOperator>
    {
        /// <summary>
        ///
        /// </summary>
        public ClassifierSetFilterOperator(string value)
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
        public static ClassifierSetFilterOperator In { get; } = new("in");

        /// <summary>
        ///
        /// </summary>
        public static ClassifierSetFilterOperator NotIn { get; } = new("not_in");
        /// <summary>
        ///
        /// </summary>
        public static ClassifierSetFilterOperator FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "in" => In,
                "not_in" => NotIn,
                _ => new ClassifierSetFilterOperator(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "in" => true,
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
        public bool Equals(ClassifierSetFilterOperator other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ClassifierSetFilterOperator other && Equals(other);
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
        public static bool operator ==(ClassifierSetFilterOperator left, ClassifierSetFilterOperator right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ClassifierSetFilterOperator left, ClassifierSetFilterOperator right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClassifierSetFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClassifierSetFilterOperator value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClassifierSetFilterOperator? ToEnum(string value)
        {
            return ClassifierSetFilterOperator.FromValue(value);
        }
    }
}