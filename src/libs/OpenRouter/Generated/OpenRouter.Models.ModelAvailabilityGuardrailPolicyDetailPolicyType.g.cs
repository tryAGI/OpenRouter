
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ModelAvailabilityGuardrailPolicyDetailPolicyType
    {
        /// <summary>
        ///
        /// </summary>
        ModelAvailability,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelAvailabilityGuardrailPolicyDetailPolicyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelAvailabilityGuardrailPolicyDetailPolicyType value)
        {
            return value switch
            {
                ModelAvailabilityGuardrailPolicyDetailPolicyType.ModelAvailability => "model_availability",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelAvailabilityGuardrailPolicyDetailPolicyType? ToEnum(string value)
        {
            return value switch
            {
                "model_availability" => ModelAvailabilityGuardrailPolicyDetailPolicyType.ModelAvailability,
                _ => null,
            };
        }
    }
}