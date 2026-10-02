
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum AnthropicAdvisorMessageUsageIterationVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        AdvisorMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicAdvisorMessageUsageIterationVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicAdvisorMessageUsageIterationVariant2Type value)
        {
            return value switch
            {
                AnthropicAdvisorMessageUsageIterationVariant2Type.AdvisorMessage => "advisor_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicAdvisorMessageUsageIterationVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "advisor_message" => AnthropicAdvisorMessageUsageIterationVariant2Type.AdvisorMessage,
                _ => null,
            };
        }
    }
}