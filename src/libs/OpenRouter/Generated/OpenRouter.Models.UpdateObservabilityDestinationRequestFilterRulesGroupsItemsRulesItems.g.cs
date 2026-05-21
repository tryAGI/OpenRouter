
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsFieldJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsField Field { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsOperator Operator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValueJsonConverter))]
        public global::OpenRouter.UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValue? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItems" /> class.
        /// </summary>
        /// <param name="field"></param>
        /// <param name="operator"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItems(
            global::OpenRouter.UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsField field,
            global::OpenRouter.UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsOperator @operator,
            global::OpenRouter.UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItemsValue? value)
        {
            this.Field = field;
            this.Operator = @operator;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItems" /> class.
        /// </summary>
        public UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItems()
        {
        }

    }
}