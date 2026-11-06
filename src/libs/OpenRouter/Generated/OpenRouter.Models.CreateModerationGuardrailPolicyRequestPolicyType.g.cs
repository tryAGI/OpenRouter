
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateModerationGuardrailPolicyRequestPolicyType
    {
        /// <summary>
        ///
        /// </summary>
        Moderation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateModerationGuardrailPolicyRequestPolicyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModerationGuardrailPolicyRequestPolicyType value)
        {
            return value switch
            {
                CreateModerationGuardrailPolicyRequestPolicyType.Moderation => "moderation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModerationGuardrailPolicyRequestPolicyType? ToEnum(string value)
        {
            return value switch
            {
                "moderation" => CreateModerationGuardrailPolicyRequestPolicyType.Moderation,
                _ => null,
            };
        }
    }
}