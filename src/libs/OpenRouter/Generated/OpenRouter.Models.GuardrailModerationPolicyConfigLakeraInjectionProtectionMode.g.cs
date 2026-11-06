
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct GuardrailModerationPolicyConfigLakeraInjectionProtectionMode : global::System.IEquatable<GuardrailModerationPolicyConfigLakeraInjectionProtectionMode>
    {
        /// <summary>
        ///
        /// </summary>
        public GuardrailModerationPolicyConfigLakeraInjectionProtectionMode(string value)
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
        public static GuardrailModerationPolicyConfigLakeraInjectionProtectionMode Block { get; } = new("block");

        /// <summary>
        ///
        /// </summary>
        public static GuardrailModerationPolicyConfigLakeraInjectionProtectionMode Flag { get; } = new("flag");
        /// <summary>
        ///
        /// </summary>
        public static GuardrailModerationPolicyConfigLakeraInjectionProtectionMode FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "block" => Block,
                "flag" => Flag,
                _ => new GuardrailModerationPolicyConfigLakeraInjectionProtectionMode(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "block" => true,
            "flag" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(GuardrailModerationPolicyConfigLakeraInjectionProtectionMode other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GuardrailModerationPolicyConfigLakeraInjectionProtectionMode other && Equals(other);
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
        public static bool operator ==(GuardrailModerationPolicyConfigLakeraInjectionProtectionMode left, GuardrailModerationPolicyConfigLakeraInjectionProtectionMode right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GuardrailModerationPolicyConfigLakeraInjectionProtectionMode left, GuardrailModerationPolicyConfigLakeraInjectionProtectionMode right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GuardrailModerationPolicyConfigLakeraInjectionProtectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailModerationPolicyConfigLakeraInjectionProtectionMode value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailModerationPolicyConfigLakeraInjectionProtectionMode? ToEnum(string value)
        {
            return GuardrailModerationPolicyConfigLakeraInjectionProtectionMode.FromValue(value);
        }
    }
}