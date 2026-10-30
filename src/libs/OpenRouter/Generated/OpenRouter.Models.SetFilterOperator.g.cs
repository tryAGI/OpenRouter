
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// Set-membership operator taking an array filter value.<br/>
    /// Example: in
    /// </summary>
    public readonly partial struct SetFilterOperator : global::System.IEquatable<SetFilterOperator>
    {
        /// <summary>
        ///
        /// </summary>
        public SetFilterOperator(string value)
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
        public static SetFilterOperator In { get; } = new("in");

        /// <summary>
        ///
        /// </summary>
        public static SetFilterOperator NotIn { get; } = new("not_in");
        /// <summary>
        ///
        /// </summary>
        public static SetFilterOperator FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "in" => In,
                "not_in" => NotIn,
                _ => new SetFilterOperator(value),
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
        public bool Equals(SetFilterOperator other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SetFilterOperator other && Equals(other);
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
        public static bool operator ==(SetFilterOperator left, SetFilterOperator right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SetFilterOperator left, SetFilterOperator right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SetFilterOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SetFilterOperator value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SetFilterOperator? ToEnum(string value)
        {
            return SetFilterOperator.FromValue(value);
        }
    }
}