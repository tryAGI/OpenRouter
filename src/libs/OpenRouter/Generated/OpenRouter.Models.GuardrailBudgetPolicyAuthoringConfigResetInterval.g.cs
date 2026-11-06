
#nullable enable

namespace OpenRouter
{

    /// <summary>
    ///
    /// </summary>
    public readonly partial struct GuardrailBudgetPolicyAuthoringConfigResetInterval : global::System.IEquatable<GuardrailBudgetPolicyAuthoringConfigResetInterval>
    {
        /// <summary>
        ///
        /// </summary>
        public GuardrailBudgetPolicyAuthoringConfigResetInterval(string value)
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
        public static GuardrailBudgetPolicyAuthoringConfigResetInterval Daily { get; } = new("daily");

        /// <summary>
        ///
        /// </summary>
        public static GuardrailBudgetPolicyAuthoringConfigResetInterval Monthly { get; } = new("monthly");

        /// <summary>
        ///
        /// </summary>
        public static GuardrailBudgetPolicyAuthoringConfigResetInterval Weekly { get; } = new("weekly");
        /// <summary>
        ///
        /// </summary>
        public static GuardrailBudgetPolicyAuthoringConfigResetInterval FromValue(string value)
        {
            value = value ?? throw new global::System.ArgumentNullException(nameof(value));

            return value switch
            {
                "daily" => Daily,
                "monthly" => Monthly,
                "weekly" => Weekly,
                _ => new GuardrailBudgetPolicyAuthoringConfigResetInterval(value),
            };
        }

        /// <summary>
        ///
        /// </summary>
        public bool IsKnown => Value switch
        {
            "daily" => true,
            "monthly" => true,
            "weekly" => true,
            _ => false,
        };

        /// <summary>
        ///
        /// </summary>
        public override string ToString() => Value ?? string.Empty;

        /// <summary>
        ///
        /// </summary>
        public bool Equals(GuardrailBudgetPolicyAuthoringConfigResetInterval other)
        {
            return string.Equals(Value, other.Value, global::System.StringComparison.Ordinal);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GuardrailBudgetPolicyAuthoringConfigResetInterval other && Equals(other);
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
        public static bool operator ==(GuardrailBudgetPolicyAuthoringConfigResetInterval left, GuardrailBudgetPolicyAuthoringConfigResetInterval right) => left.Equals(right);

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GuardrailBudgetPolicyAuthoringConfigResetInterval left, GuardrailBudgetPolicyAuthoringConfigResetInterval right) => !left.Equals(right);
    }


    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GuardrailBudgetPolicyAuthoringConfigResetIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailBudgetPolicyAuthoringConfigResetInterval value)
        {
            return value.Value ?? throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null);
        }

        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailBudgetPolicyAuthoringConfigResetInterval? ToEnum(string value)
        {
            return GuardrailBudgetPolicyAuthoringConfigResetInterval.FromValue(value);
        }
    }
}