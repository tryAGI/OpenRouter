
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateModelAvailabilityGuardrailPolicyRequestPolicyType
    {
        /// <summary>
        ///
        /// </summary>
        ModelAvailability,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateModelAvailabilityGuardrailPolicyRequestPolicyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelAvailabilityGuardrailPolicyRequestPolicyType value)
        {
            return value switch
            {
                CreateModelAvailabilityGuardrailPolicyRequestPolicyType.ModelAvailability => "model_availability",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelAvailabilityGuardrailPolicyRequestPolicyType? ToEnum(string value)
        {
            return value switch
            {
                "model_availability" => CreateModelAvailabilityGuardrailPolicyRequestPolicyType.ModelAvailability,
                _ => null,
            };
        }
    }
}