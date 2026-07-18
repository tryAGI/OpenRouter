
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentMessageItemContentItemsOneOf1Detail
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Original,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentMessageItemContentItemsOneOf1DetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentMessageItemContentItemsOneOf1Detail value)
        {
            return value switch
            {
                AgentMessageItemContentItemsOneOf1Detail.Auto => "auto",
                AgentMessageItemContentItemsOneOf1Detail.High => "high",
                AgentMessageItemContentItemsOneOf1Detail.Low => "low",
                AgentMessageItemContentItemsOneOf1Detail.Original => "original",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentMessageItemContentItemsOneOf1Detail? ToEnum(string value)
        {
            return value switch
            {
                "auto" => AgentMessageItemContentItemsOneOf1Detail.Auto,
                "high" => AgentMessageItemContentItemsOneOf1Detail.High,
                "low" => AgentMessageItemContentItemsOneOf1Detail.Low,
                "original" => AgentMessageItemContentItemsOneOf1Detail.Original,
                _ => null,
            };
        }
    }
}