
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum ModerationGuardrailPolicySummaryPolicyType
    {
        /// <summary>
        ///
        /// </summary>
        Moderation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModerationGuardrailPolicySummaryPolicyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationGuardrailPolicySummaryPolicyType value)
        {
            return value switch
            {
                ModerationGuardrailPolicySummaryPolicyType.Moderation => "moderation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationGuardrailPolicySummaryPolicyType? ToEnum(string value)
        {
            return value switch
            {
                "moderation" => ModerationGuardrailPolicySummaryPolicyType.Moderation,
                _ => null,
            };
        }
    }
}