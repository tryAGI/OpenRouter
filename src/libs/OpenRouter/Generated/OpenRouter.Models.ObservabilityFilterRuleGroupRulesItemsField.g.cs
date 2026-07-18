
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ObservabilityFilterRuleGroupRulesItemsField
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKeyName,
        /// <summary>
        /// 
        /// </summary>
        CompletionTokens,
        /// <summary>
        /// 
        /// </summary>
        FinishReason,
        /// <summary>
        /// 
        /// </summary>
        Input,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        Output,
        /// <summary>
        /// 
        /// </summary>
        PromptTokens,
        /// <summary>
        /// 
        /// </summary>
        Provider,
        /// <summary>
        /// 
        /// </summary>
        SessionId,
        /// <summary>
        /// 
        /// </summary>
        TotalCost,
        /// <summary>
        /// 
        /// </summary>
        TotalTokens,
        /// <summary>
        /// 
        /// </summary>
        UserId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObservabilityFilterRuleGroupRulesItemsFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityFilterRuleGroupRulesItemsField value)
        {
            return value switch
            {
                ObservabilityFilterRuleGroupRulesItemsField.ApiKeyName => "api_key_name",
                ObservabilityFilterRuleGroupRulesItemsField.CompletionTokens => "completion_tokens",
                ObservabilityFilterRuleGroupRulesItemsField.FinishReason => "finish_reason",
                ObservabilityFilterRuleGroupRulesItemsField.Input => "input",
                ObservabilityFilterRuleGroupRulesItemsField.Model => "model",
                ObservabilityFilterRuleGroupRulesItemsField.Output => "output",
                ObservabilityFilterRuleGroupRulesItemsField.PromptTokens => "prompt_tokens",
                ObservabilityFilterRuleGroupRulesItemsField.Provider => "provider",
                ObservabilityFilterRuleGroupRulesItemsField.SessionId => "session_id",
                ObservabilityFilterRuleGroupRulesItemsField.TotalCost => "total_cost",
                ObservabilityFilterRuleGroupRulesItemsField.TotalTokens => "total_tokens",
                ObservabilityFilterRuleGroupRulesItemsField.UserId => "user_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityFilterRuleGroupRulesItemsField? ToEnum(string value)
        {
            return value switch
            {
                "api_key_name" => ObservabilityFilterRuleGroupRulesItemsField.ApiKeyName,
                "completion_tokens" => ObservabilityFilterRuleGroupRulesItemsField.CompletionTokens,
                "finish_reason" => ObservabilityFilterRuleGroupRulesItemsField.FinishReason,
                "input" => ObservabilityFilterRuleGroupRulesItemsField.Input,
                "model" => ObservabilityFilterRuleGroupRulesItemsField.Model,
                "output" => ObservabilityFilterRuleGroupRulesItemsField.Output,
                "prompt_tokens" => ObservabilityFilterRuleGroupRulesItemsField.PromptTokens,
                "provider" => ObservabilityFilterRuleGroupRulesItemsField.Provider,
                "session_id" => ObservabilityFilterRuleGroupRulesItemsField.SessionId,
                "total_cost" => ObservabilityFilterRuleGroupRulesItemsField.TotalCost,
                "total_tokens" => ObservabilityFilterRuleGroupRulesItemsField.TotalTokens,
                "user_id" => ObservabilityFilterRuleGroupRulesItemsField.UserId,
                _ => null,
            };
        }
    }
}