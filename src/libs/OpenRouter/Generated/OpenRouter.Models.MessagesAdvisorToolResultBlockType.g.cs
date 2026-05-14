
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesAdvisorToolResultBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        AdvisorToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesAdvisorToolResultBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesAdvisorToolResultBlockType value)
        {
            return value switch
            {
                MessagesAdvisorToolResultBlockType.AdvisorToolResult => "advisor_tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesAdvisorToolResultBlockType? ToEnum(string value)
        {
            return value switch
            {
                "advisor_tool_result" => MessagesAdvisorToolResultBlockType.AdvisorToolResult,
                _ => null,
            };
        }
    }
}