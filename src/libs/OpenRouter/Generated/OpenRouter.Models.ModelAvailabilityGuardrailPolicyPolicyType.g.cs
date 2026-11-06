
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ModelAvailabilityGuardrailPolicyPolicyType
    {
        /// <summary>
        ///
        /// </summary>
        ModelAvailability,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelAvailabilityGuardrailPolicyPolicyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelAvailabilityGuardrailPolicyPolicyType value)
        {
            return value switch
            {
                ModelAvailabilityGuardrailPolicyPolicyType.ModelAvailability => "model_availability",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelAvailabilityGuardrailPolicyPolicyType? ToEnum(string value)
        {
            return value switch
            {
                "model_availability" => ModelAvailabilityGuardrailPolicyPolicyType.ModelAvailability,
                _ => null,
            };
        }
    }
}