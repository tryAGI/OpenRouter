
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum AccountGuardrailPolicyRequestDiscriminatorPolicyType
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
    public static class AccountGuardrailPolicyRequestDiscriminatorPolicyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccountGuardrailPolicyRequestDiscriminatorPolicyType value)
        {
            return value switch
            {
                AccountGuardrailPolicyRequestDiscriminatorPolicyType.Budget => "budget",
                AccountGuardrailPolicyRequestDiscriminatorPolicyType.ModelAvailability => "model_availability",
                AccountGuardrailPolicyRequestDiscriminatorPolicyType.Moderation => "moderation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccountGuardrailPolicyRequestDiscriminatorPolicyType? ToEnum(string value)
        {
            return value switch
            {
                "budget" => AccountGuardrailPolicyRequestDiscriminatorPolicyType.Budget,
                "model_availability" => AccountGuardrailPolicyRequestDiscriminatorPolicyType.ModelAvailability,
                "moderation" => AccountGuardrailPolicyRequestDiscriminatorPolicyType.Moderation,
                _ => null,
            };
        }
    }
}