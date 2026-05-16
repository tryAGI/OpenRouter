
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum ObservabilityFilterRulesConfigGroupsItemsRulesItemsField
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
    public static class ObservabilityFilterRulesConfigGroupsItemsRulesItemsFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObservabilityFilterRulesConfigGroupsItemsRulesItemsField value)
        {
            return value switch
            {
                ObservabilityFilterRulesConfigGroupsItemsRulesItemsField.ApiKeyName => "api_key_name",
                ObservabilityFilterRulesConfigGroupsItemsRulesItemsField.CompletionTokens => "completion_tokens",
                ObservabilityFilterRulesConfigGroupsItemsRulesItemsField.FinishReason => "finish_reason",
                ObservabilityFilterRulesConfigGroupsItemsRulesItemsField.Input => "input",
                ObservabilityFilterRulesConfigGroupsItemsRulesItemsField.Model => "model",
                ObservabilityFilterRulesConfigGroupsItemsRulesItemsField.Output => "output",
                ObservabilityFilterRulesConfigGroupsItemsRulesItemsField.PromptTokens => "prompt_tokens",
                ObservabilityFilterRulesConfigGroupsItemsRulesItemsField.Provider => "provider",
                ObservabilityFilterRulesConfigGroupsItemsRulesItemsField.SessionId => "session_id",
                ObservabilityFilterRulesConfigGroupsItemsRulesItemsField.TotalCost => "total_cost",
                ObservabilityFilterRulesConfigGroupsItemsRulesItemsField.TotalTokens => "total_tokens",
                ObservabilityFilterRulesConfigGroupsItemsRulesItemsField.UserId => "user_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObservabilityFilterRulesConfigGroupsItemsRulesItemsField? ToEnum(string value)
        {
            return value switch
            {
                "api_key_name" => ObservabilityFilterRulesConfigGroupsItemsRulesItemsField.ApiKeyName,
                "completion_tokens" => ObservabilityFilterRulesConfigGroupsItemsRulesItemsField.CompletionTokens,
                "finish_reason" => ObservabilityFilterRulesConfigGroupsItemsRulesItemsField.FinishReason,
                "input" => ObservabilityFilterRulesConfigGroupsItemsRulesItemsField.Input,
                "model" => ObservabilityFilterRulesConfigGroupsItemsRulesItemsField.Model,
                "output" => ObservabilityFilterRulesConfigGroupsItemsRulesItemsField.Output,
                "prompt_tokens" => ObservabilityFilterRulesConfigGroupsItemsRulesItemsField.PromptTokens,
                "provider" => ObservabilityFilterRulesConfigGroupsItemsRulesItemsField.Provider,
                "session_id" => ObservabilityFilterRulesConfigGroupsItemsRulesItemsField.SessionId,
                "total_cost" => ObservabilityFilterRulesConfigGroupsItemsRulesItemsField.TotalCost,
                "total_tokens" => ObservabilityFilterRulesConfigGroupsItemsRulesItemsField.TotalTokens,
                "user_id" => ObservabilityFilterRulesConfigGroupsItemsRulesItemsField.UserId,
                _ => null,
            };
        }
    }
}