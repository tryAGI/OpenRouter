
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ModelAvailabilityAccountGuardrailPolicyRequestPolicyType
    {
        /// <summary>
        ///
        /// </summary>
        ModelAvailability,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelAvailabilityAccountGuardrailPolicyRequestPolicyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelAvailabilityAccountGuardrailPolicyRequestPolicyType value)
        {
            return value switch
            {
                ModelAvailabilityAccountGuardrailPolicyRequestPolicyType.ModelAvailability => "model_availability",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelAvailabilityAccountGuardrailPolicyRequestPolicyType? ToEnum(string value)
        {
            return value switch
            {
                "model_availability" => ModelAvailabilityAccountGuardrailPolicyRequestPolicyType.ModelAvailability,
                _ => null,
            };
        }
    }
}