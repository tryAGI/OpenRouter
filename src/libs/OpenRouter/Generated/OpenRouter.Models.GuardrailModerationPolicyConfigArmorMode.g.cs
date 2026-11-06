
#nullable enable

namespace OpenRouter
{

    /// <summary>
    /// `enforce` withholds blocked calls; `audit` evaluates and reports the same verdicts without withholding any calls, regardless of `on_error`. Default `enforce`.
    /// </summary>
    public readonly partial struct GuardrailModerationPolicyConfigArmorMode : global::System.IEquatable<GuardrailModerationPolicyConfigArmorMode>
    {
        /// <summary>
        ///
        /// </summary>
        public GuardrailModerationPolicyConfigArmorMode(string value)
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
        public static GuardrailModerationPolicyConfigArmorMode Audit { get; } = new("audit");

        /// <summary>
        ///
        /// </summary>
        public static GuardrailModerationPolicyConfigArmorMode Enforce { get; } = new("enforce");
        /// <summary>
        ///
        /// </summary>
        public static GuardrailModerationPolicyConfigArmorMode FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "audit" => Audit,
                "enforce" => Enforce,
                _ => new GuardrailModerationPolicyConfigArmorMode(value),
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
        public bool Equals(GuardrailModerationPolicyConfigArmorMode other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GuardrailModerationPolicyConfigArmorMode other && Equals(other);
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
        public static bool operator ==(GuardrailModerationPolicyConfigArmorMode left, GuardrailModerationPolicyConfigArmorMode right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GuardrailModerationPolicyConfigArmorMode left, GuardrailModerationPolicyConfigArmorMode right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GuardrailModerationPolicyConfigArmorModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailModerationPolicyConfigArmorMode value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailModerationPolicyConfigArmorMode? ToEnum(string value)
        {
            return GuardrailModerationPolicyConfigArmorMode.FromValue(value);
        }
    }
}