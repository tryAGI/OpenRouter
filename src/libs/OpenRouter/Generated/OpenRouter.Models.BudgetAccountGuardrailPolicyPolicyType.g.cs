
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BudgetAccountGuardrailPolicyPolicyType
    {
        /// <summary>
        ///
        /// </summary>
        Budget,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BudgetAccountGuardrailPolicyPolicyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BudgetAccountGuardrailPolicyPolicyType value)
        {
            return value switch
            {
                BudgetAccountGuardrailPolicyPolicyType.Budget => "budget",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BudgetAccountGuardrailPolicyPolicyType? ToEnum(string value)
        {
            return value switch
            {
                "budget" => BudgetAccountGuardrailPolicyPolicyType.Budget,
                _ => null,
            };
        }
    }
}