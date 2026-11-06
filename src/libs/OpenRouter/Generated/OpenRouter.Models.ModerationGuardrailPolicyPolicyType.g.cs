
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ModerationGuardrailPolicyPolicyType
    {
        /// <summary>
        ///
        /// </summary>
        Moderation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModerationGuardrailPolicyPolicyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationGuardrailPolicyPolicyType value)
        {
            return value switch
            {
                ModerationGuardrailPolicyPolicyType.Moderation => "moderation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationGuardrailPolicyPolicyType? ToEnum(string value)
        {
            return value switch
            {
                "moderation" => ModerationGuardrailPolicyPolicyType.Moderation,
                _ => null,
            };
        }
    }
}