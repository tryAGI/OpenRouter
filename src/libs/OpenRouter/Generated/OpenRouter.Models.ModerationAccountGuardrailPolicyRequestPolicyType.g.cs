
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ModerationAccountGuardrailPolicyRequestPolicyType
    {
        /// <summary>
        ///
        /// </summary>
        Moderation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModerationAccountGuardrailPolicyRequestPolicyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationAccountGuardrailPolicyRequestPolicyType value)
        {
            return value switch
            {
                ModerationAccountGuardrailPolicyRequestPolicyType.Moderation => "moderation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationAccountGuardrailPolicyRequestPolicyType? ToEnum(string value)
        {
            return value switch
            {
                "moderation" => ModerationAccountGuardrailPolicyRequestPolicyType.Moderation,
                _ => null,
            };
        }
    }
}