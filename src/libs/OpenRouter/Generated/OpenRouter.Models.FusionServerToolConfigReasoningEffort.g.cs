
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Reasoning effort level for panelist and judge inner calls.
    /// </summary>
    public enum FusionServerToolConfigReasoningEffort
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
    public static class FusionServerToolConfigReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FusionServerToolConfigReasoningEffort value)
        {
            return value switch
            {
                FusionServerToolConfigReasoningEffort.High => "high",
                FusionServerToolConfigReasoningEffort.Low => "low",
                FusionServerToolConfigReasoningEffort.Medium => "medium",
                FusionServerToolConfigReasoningEffort.Minimal => "minimal",
                FusionServerToolConfigReasoningEffort.None => "none",
                FusionServerToolConfigReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FusionServerToolConfigReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => FusionServerToolConfigReasoningEffort.High,
                "low" => FusionServerToolConfigReasoningEffort.Low,
                "medium" => FusionServerToolConfigReasoningEffort.Medium,
                "minimal" => FusionServerToolConfigReasoningEffort.Minimal,
                "none" => FusionServerToolConfigReasoningEffort.None,
                "xhigh" => FusionServerToolConfigReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}