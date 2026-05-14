
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicAdvisorMessageUsageIterationType
    {
        /// <summary>
        /// 
        /// </summary>
        AdvisorMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicAdvisorMessageUsageIterationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicAdvisorMessageUsageIterationType value)
        {
            return value switch
            {
                AnthropicAdvisorMessageUsageIterationType.AdvisorMessage => "advisor_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicAdvisorMessageUsageIterationType? ToEnum(string value)
        {
            return value switch
            {
                "advisor_message" => AnthropicAdvisorMessageUsageIterationType.AdvisorMessage,
                _ => null,
            };
        }
    }
}