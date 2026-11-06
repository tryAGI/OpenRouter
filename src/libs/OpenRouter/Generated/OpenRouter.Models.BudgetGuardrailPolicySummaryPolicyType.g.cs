
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BudgetGuardrailPolicySummaryPolicyType
    {
        /// <summary>
        ///
        /// </summary>
        Budget,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BudgetGuardrailPolicySummaryPolicyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BudgetGuardrailPolicySummaryPolicyType value)
        {
            return value switch
            {
                BudgetGuardrailPolicySummaryPolicyType.Budget => "budget",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BudgetGuardrailPolicySummaryPolicyType? ToEnum(string value)
        {
            return value switch
            {
                "budget" => BudgetGuardrailPolicySummaryPolicyType.Budget,
                _ => null,
            };
        }
    }
}