
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsField
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
    public static class UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsField value)
        {
            return value switch
            {
                UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsField.ApiKeyName => "api_key_name",
                UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsField.CompletionTokens => "completion_tokens",
                UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsField.FinishReason => "finish_reason",
                UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsField.Input => "input",
                UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsField.Model => "model",
                UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsField.Output => "output",
                UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsField.PromptTokens => "prompt_tokens",
                UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsField.Provider => "provider",
                UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsField.SessionId => "session_id",
                UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsField.TotalCost => "total_cost",
                UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsField.TotalTokens => "total_tokens",
                UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsField.UserId => "user_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsField? ToEnum(string value)
        {
            return value switch
            {
                "api_key_name" => UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsField.ApiKeyName,
                "completion_tokens" => UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsField.CompletionTokens,
                "finish_reason" => UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsField.FinishReason,
                "input" => UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsField.Input,
                "model" => UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsField.Model,
                "output" => UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsField.Output,
                "prompt_tokens" => UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsField.PromptTokens,
                "provider" => UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsField.Provider,
                "session_id" => UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsField.SessionId,
                "total_cost" => UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsField.TotalCost,
                "total_tokens" => UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsField.TotalTokens,
                "user_id" => UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsField.UserId,
                _ => null,
            };
        }
    }
}