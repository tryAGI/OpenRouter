
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ModerationGuardrailPolicyDetailPolicyType
    {
        /// <summary>
        ///
        /// </summary>
        Moderation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModerationGuardrailPolicyDetailPolicyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationGuardrailPolicyDetailPolicyType value)
        {
            return value switch
            {
                ModerationGuardrailPolicyDetailPolicyType.Moderation => "moderation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationGuardrailPolicyDetailPolicyType? ToEnum(string value)
        {
            return value switch
            {
                "moderation" => ModerationGuardrailPolicyDetailPolicyType.Moderation,
                _ => null,
            };
        }
    }
}