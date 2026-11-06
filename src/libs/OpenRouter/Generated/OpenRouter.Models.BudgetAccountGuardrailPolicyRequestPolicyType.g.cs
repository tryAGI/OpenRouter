
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BudgetAccountGuardrailPolicyRequestPolicyType
    {
        /// <summary>
        ///
        /// </summary>
        Budget,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BudgetAccountGuardrailPolicyRequestPolicyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BudgetAccountGuardrailPolicyRequestPolicyType value)
        {
            return value switch
            {
                BudgetAccountGuardrailPolicyRequestPolicyType.Budget => "budget",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BudgetAccountGuardrailPolicyRequestPolicyType? ToEnum(string value)
        {
            return value switch
            {
                "budget" => BudgetAccountGuardrailPolicyRequestPolicyType.Budget,
                _ => null,
            };
        }
    }
}