
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public enum AnthropicAdvisorToolResultType
    {
        /// <summary>
        ///
        /// </summary>
        AdvisorToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicAdvisorToolResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicAdvisorToolResultType value)
        {
            return value switch
            {
                AnthropicAdvisorToolResultType.AdvisorToolResult => "advisor_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicAdvisorToolResultType? ToEnum(string value)
        {
            return value switch
            {
                "advisor_tool_result" => AnthropicAdvisorToolResultType.AdvisorToolResult,
                _ => null,
            };
        }
    }
}