
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CompoundFilterType : global::System.IEquatable<CompoundFilterType>
    {
        /// <summary>
        ///
        /// </summary>
        public CompoundFilterType(string value)
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
        public static CompoundFilterType And { get; } = new("and");

        /// <summary>
        ///
        /// </summary>
        public static CompoundFilterType Or { get; } = new("or");
        /// <summary>
        ///
        /// </summary>
        public static CompoundFilterType FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "and" => And,
                "or" => Or,
                _ => new CompoundFilterType(value),
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
        public bool Equals(CompoundFilterType other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CompoundFilterType other && Equals(other);
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
        public static bool operator ==(CompoundFilterType left, CompoundFilterType right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CompoundFilterType left, CompoundFilterType right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompoundFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompoundFilterType value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompoundFilterType? ToEnum(string value)
        {
            return CompoundFilterType.FromValue(value);
        }
    }
}