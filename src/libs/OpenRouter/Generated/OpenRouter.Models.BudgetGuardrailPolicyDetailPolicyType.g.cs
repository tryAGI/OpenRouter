
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BudgetGuardrailPolicyDetailPolicyType
    {
        /// <summary>
        ///
        /// </summary>
        Budget,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BudgetGuardrailPolicyDetailPolicyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BudgetGuardrailPolicyDetailPolicyType value)
        {
            return value switch
            {
                BudgetGuardrailPolicyDetailPolicyType.Budget => "budget",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BudgetGuardrailPolicyDetailPolicyType? ToEnum(string value)
        {
            return value switch
            {
                "budget" => BudgetGuardrailPolicyDetailPolicyType.Budget,
                _ => null,
            };
        }
    }
}