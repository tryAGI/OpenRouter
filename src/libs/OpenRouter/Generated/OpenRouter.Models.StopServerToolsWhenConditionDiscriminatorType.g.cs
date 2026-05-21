
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum StopServerToolsWhenConditionDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        FinishReasonIs,
        /// <summary>
        /// 
        /// </summary>
        HasToolCall,
        /// <summary>
        /// 
        /// </summary>
        MaxCost,
        /// <summary>
        /// 
        /// </summary>
        MaxTokensUsed,
        /// <summary>
        /// 
        /// </summary>
        StepCountIs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StopServerToolsWhenConditionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StopServerToolsWhenConditionDiscriminatorType value)
        {
            return value switch
            {
                StopServerToolsWhenConditionDiscriminatorType.FinishReasonIs => "finish_reason_is",
                StopServerToolsWhenConditionDiscriminatorType.HasToolCall => "has_tool_call",
                StopServerToolsWhenConditionDiscriminatorType.MaxCost => "max_cost",
                StopServerToolsWhenConditionDiscriminatorType.MaxTokensUsed => "max_tokens_used",
                StopServerToolsWhenConditionDiscriminatorType.StepCountIs => "step_count_is",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StopServerToolsWhenConditionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "finish_reason_is" => StopServerToolsWhenConditionDiscriminatorType.FinishReasonIs,
                "has_tool_call" => StopServerToolsWhenConditionDiscriminatorType.HasToolCall,
                "max_cost" => StopServerToolsWhenConditionDiscriminatorType.MaxCost,
                "max_tokens_used" => StopServerToolsWhenConditionDiscriminatorType.MaxTokensUsed,
                "step_count_is" => StopServerToolsWhenConditionDiscriminatorType.StepCountIs,
                _ => null,
            };
        }
    }
}