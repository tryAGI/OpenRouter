
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateObservabilityDestinationRequestFilterRulesGroupsItems
    {
        /// <summary>
        /// Default Value: and
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logic")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UpdateObservabilityDestinationRequestFilterRulesGroupsItemsLogicJsonConverter))]
        public global::OpenRouter.UpdateObservabilityDestinationRequestFilterRulesGroupsItemsLogic? Logic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItems> Rules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObservabilityDestinationRequestFilterRulesGroupsItems" /> class.
        /// </summary>
        /// <param name="rules"></param>
        /// <param name="logic">
        /// Default Value: and
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateObservabilityDestinationRequestFilterRulesGroupsItems(
            global::System.Collections.Generic.IList<global::OpenRouter.UpdateObservabilityDestinationRequestFilterRulesGroupsItemsRulesItems> rules,
            global::OpenRouter.UpdateObservabilityDestinationRequestFilterRulesGroupsItemsLogic? logic)
        {
            this.Logic = logic;
            this.Rules = rules ?? throw new global::System.ArgumentNullException(nameof(rules));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObservabilityDestinationRequestFilterRulesGroupsItems" /> class.
        /// </summary>
        public UpdateObservabilityDestinationRequestFilterRulesGroupsItems()
        {
        }

    }
}