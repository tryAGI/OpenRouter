
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateBudgetGuardrailPolicyRequestPolicyType
    {
        /// <summary>
        ///
        /// </summary>
        Budget,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateBudgetGuardrailPolicyRequestPolicyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBudgetGuardrailPolicyRequestPolicyType value)
        {
            return value switch
            {
                CreateBudgetGuardrailPolicyRequestPolicyType.Budget => "budget",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBudgetGuardrailPolicyRequestPolicyType? ToEnum(string value)
        {
            return value switch
            {
                "budget" => CreateBudgetGuardrailPolicyRequestPolicyType.Budget,
                _ => null,
            };
        }
    }
}