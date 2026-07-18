
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentMessageItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentMessageItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentMessageItemType value)
        {
            return value switch
            {
                AgentMessageItemType.AgentMessage => "agent_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentMessageItemType? ToEnum(string value)
        {
            return value switch
            {
                "agent_message" => AgentMessageItemType.AgentMessage,
                _ => null,
            };
        }
    }
}