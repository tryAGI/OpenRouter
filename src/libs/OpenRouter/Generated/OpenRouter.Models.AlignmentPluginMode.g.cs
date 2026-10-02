
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// `enforce`: a turn that breaks a rule is withheld, retried, and finally returned as an error. `audit`: every turn is evaluated and returned. Default `enforce`.
    /// </summary>
    public readonly partial struct AlignmentPluginMode : global::System.IEquatable<AlignmentPluginMode>
    {
        /// <summary>
        ///
        /// </summary>
        public AlignmentPluginMode(string value)
        {
            Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        ///
        /// </summary>
        public string Value { get; }
        /// <summary>
        /// a turn that breaks a rule is withheld, retried, and finally returned as an error. `audit`: every turn is evaluated and returned. Default `enforce`.
        /// </summary>
        public static AlignmentPluginMode Audit { get; } = new("audit");

        /// <summary>
        /// a turn that breaks a rule is withheld, retried, and finally returned as an error. `audit`: every turn is evaluated and returned. Default `enforce`.
        /// </summary>
        public static AlignmentPluginMode Enforce { get; } = new("enforce");
        /// <summary>
        ///
        /// </summary>
        public static AlignmentPluginMode FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "audit" => Audit,
                "enforce" => Enforce,
                _ => new AlignmentPluginMode(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "audit" => true,
            "enforce" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(AlignmentPluginMode other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AlignmentPluginMode other && Equals(other);
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
        public static bool operator ==(AlignmentPluginMode left, AlignmentPluginMode right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AlignmentPluginMode left, AlignmentPluginMode right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlignmentPluginModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlignmentPluginMode value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlignmentPluginMode? ToEnum(string value)
        {
            return AlignmentPluginMode.FromValue(value);
        }
    }
}