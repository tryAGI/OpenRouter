
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubagentServerToolOpenRouterType
    {
        /// <summary>
        /// 
        /// </summary>
        Openrouter_subagent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubagentServerToolOpenRouterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubagentServerToolOpenRouterType value)
        {
            return value switch
            {
                SubagentServerToolOpenRouterType.Openrouter_subagent => "openrouter:subagent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubagentServerToolOpenRouterType? ToEnum(string value)
        {
            return value switch
            {
                "openrouter:subagent" => SubagentServerToolOpenRouterType.Openrouter_subagent,
                _ => null,
            };
        }
    }
}