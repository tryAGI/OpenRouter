
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum OutputSubagentServerToolItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Openrouter_subagent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputSubagentServerToolItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputSubagentServerToolItemType value)
        {
            return value switch
            {
                OutputSubagentServerToolItemType.Openrouter_subagent => "openrouter:subagent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputSubagentServerToolItemType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:subagent" => OutputSubagentServerToolItemType.Openrouter_subagent,
                _ => null,
            };
        }
    }
}