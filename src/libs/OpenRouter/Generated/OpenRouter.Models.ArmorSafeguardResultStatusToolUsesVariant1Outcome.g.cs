
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ArmorSafeguardResultStatusToolUsesVariant1Outcome : global::System.IEquatable<ArmorSafeguardResultStatusToolUsesVariant1Outcome>
    {
        /// <summary>
        ///
        /// </summary>
        public ArmorSafeguardResultStatusToolUsesVariant1Outcome(string value)
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
        public static ArmorSafeguardResultStatusToolUsesVariant1Outcome Flagged { get; } = new("flagged");

        /// <summary>
        ///
        /// </summary>
        public static ArmorSafeguardResultStatusToolUsesVariant1Outcome NotFlagged { get; } = new("not_flagged");
        /// <summary>
        ///
        /// </summary>
        public static ArmorSafeguardResultStatusToolUsesVariant1Outcome FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "flagged" => Flagged,
                "not_flagged" => NotFlagged,
                _ => new ArmorSafeguardResultStatusToolUsesVariant1Outcome(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "flagged" => true,
            "not_flagged" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(ArmorSafeguardResultStatusToolUsesVariant1Outcome other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ArmorSafeguardResultStatusToolUsesVariant1Outcome other && Equals(other);
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
        public static bool operator ==(ArmorSafeguardResultStatusToolUsesVariant1Outcome left, ArmorSafeguardResultStatusToolUsesVariant1Outcome right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ArmorSafeguardResultStatusToolUsesVariant1Outcome left, ArmorSafeguardResultStatusToolUsesVariant1Outcome right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ArmorSafeguardResultStatusToolUsesVariant1OutcomeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ArmorSafeguardResultStatusToolUsesVariant1Outcome value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ArmorSafeguardResultStatusToolUsesVariant1Outcome? ToEnum(string value)
        {
            return ArmorSafeguardResultStatusToolUsesVariant1Outcome.FromValue(value);
        }
    }
}