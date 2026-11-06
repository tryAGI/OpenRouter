
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ModelAvailabilityAccountGuardrailPolicyPolicyType
    {
        /// <summary>
        ///
        /// </summary>
        ModelAvailability,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelAvailabilityAccountGuardrailPolicyPolicyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelAvailabilityAccountGuardrailPolicyPolicyType value)
        {
            return value switch
            {
                ModelAvailabilityAccountGuardrailPolicyPolicyType.ModelAvailability => "model_availability",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelAvailabilityAccountGuardrailPolicyPolicyType? ToEnum(string value)
        {
            return value switch
            {
                "model_availability" => ModelAvailabilityAccountGuardrailPolicyPolicyType.ModelAvailability,
                _ => null,
            };
        }
    }
}