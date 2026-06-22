
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Reasoning effort level for the advisor call.
    /// </summary>
    public enum AdvisorReasoningEffort
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
    public static class AdvisorReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AdvisorReasoningEffort value)
        {
            return value switch
            {
                AdvisorReasoningEffort.High => "high",
                AdvisorReasoningEffort.Low => "low",
                AdvisorReasoningEffort.Max => "max",
                AdvisorReasoningEffort.Medium => "medium",
                AdvisorReasoningEffort.Minimal => "minimal",
                AdvisorReasoningEffort.None => "none",
                AdvisorReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AdvisorReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => AdvisorReasoningEffort.High,
                "low" => AdvisorReasoningEffort.Low,
                "max" => AdvisorReasoningEffort.Max,
                "medium" => AdvisorReasoningEffort.Medium,
                "minimal" => AdvisorReasoningEffort.Minimal,
                "none" => AdvisorReasoningEffort.None,
                "xhigh" => AdvisorReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}