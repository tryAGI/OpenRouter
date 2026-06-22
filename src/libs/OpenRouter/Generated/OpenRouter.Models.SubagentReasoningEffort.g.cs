
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Reasoning effort level for the subagent call.
    /// </summary>
    public enum SubagentReasoningEffort
    {
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
        Max,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Minimal,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubagentReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubagentReasoningEffort value)
        {
            return value switch
            {
                SubagentReasoningEffort.High => "high",
                SubagentReasoningEffort.Low => "low",
                SubagentReasoningEffort.Max => "max",
                SubagentReasoningEffort.Medium => "medium",
                SubagentReasoningEffort.Minimal => "minimal",
                SubagentReasoningEffort.None => "none",
                SubagentReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubagentReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => SubagentReasoningEffort.High,
                "low" => SubagentReasoningEffort.Low,
                "max" => SubagentReasoningEffort.Max,
                "medium" => SubagentReasoningEffort.Medium,
                "minimal" => SubagentReasoningEffort.Minimal,
                "none" => SubagentReasoningEffort.None,
                "xhigh" => SubagentReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}