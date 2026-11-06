
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum BudgetGuardrailPolicyPolicyType
    {
        /// <summary>
        ///
        /// </summary>
        Budget,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BudgetGuardrailPolicyPolicyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BudgetGuardrailPolicyPolicyType value)
        {
            return value switch
            {
                BudgetGuardrailPolicyPolicyType.Budget => "budget",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BudgetGuardrailPolicyPolicyType? ToEnum(string value)
        {
            return value switch
            {
                "budget" => BudgetGuardrailPolicyPolicyType.Budget,
                _ => null,
            };
        }
    }
}