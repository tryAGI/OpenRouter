
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ModelAvailabilityGuardrailPolicySummaryPolicyType
    {
        /// <summary>
        ///
        /// </summary>
        ModelAvailability,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelAvailabilityGuardrailPolicySummaryPolicyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelAvailabilityGuardrailPolicySummaryPolicyType value)
        {
            return value switch
            {
                ModelAvailabilityGuardrailPolicySummaryPolicyType.ModelAvailability => "model_availability",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelAvailabilityGuardrailPolicySummaryPolicyType? ToEnum(string value)
        {
            return value switch
            {
                "model_availability" => ModelAvailabilityGuardrailPolicySummaryPolicyType.ModelAvailability,
                _ => null,
            };
        }
    }
}