
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum AccountGuardrailPolicyDiscriminatorPolicyType
    {
        /// <summary>
        ///
        /// </summary>
        Budget,
        /// <summary>
        ///
        /// </summary>
        ModelAvailability,
        /// <summary>
        ///
        /// </summary>
        Moderation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AccountGuardrailPolicyDiscriminatorPolicyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccountGuardrailPolicyDiscriminatorPolicyType value)
        {
            return value switch
            {
                AccountGuardrailPolicyDiscriminatorPolicyType.Budget => "budget",
                AccountGuardrailPolicyDiscriminatorPolicyType.ModelAvailability => "model_availability",
                AccountGuardrailPolicyDiscriminatorPolicyType.Moderation => "moderation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccountGuardrailPolicyDiscriminatorPolicyType? ToEnum(string value)
        {
            return value switch
            {
                "budget" => AccountGuardrailPolicyDiscriminatorPolicyType.Budget,
                "model_availability" => AccountGuardrailPolicyDiscriminatorPolicyType.ModelAvailability,
                "moderation" => AccountGuardrailPolicyDiscriminatorPolicyType.Moderation,
                _ => null,
            };
        }
    }
}