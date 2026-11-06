
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ModerationAccountGuardrailPolicyPolicyType
    {
        /// <summary>
        ///
        /// </summary>
        Moderation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModerationAccountGuardrailPolicyPolicyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationAccountGuardrailPolicyPolicyType value)
        {
            return value switch
            {
                ModerationAccountGuardrailPolicyPolicyType.Moderation => "moderation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationAccountGuardrailPolicyPolicyType? ToEnum(string value)
        {
            return value switch
            {
                "moderation" => ModerationAccountGuardrailPolicyPolicyType.Moderation,
                _ => null,
            };
        }
    }
}