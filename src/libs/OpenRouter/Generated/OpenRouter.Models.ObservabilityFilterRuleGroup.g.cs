
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ObservabilityFilterRuleGroup
    {
        /// <summary>
        /// Default Value: and
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logic")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ObservabilityFilterRuleGroupLogicJsonConverter))]
        public global::OpenRouter.ObservabilityFilterRuleGroupLogic? Logic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ObservabilityFilterRuleGroupRulesItems> Rules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservabilityFilterRuleGroup" /> class.
        /// </summary>
        /// <param name="rules"></param>
        /// <param name="logic">
        /// Default Value: and
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ObservabilityFilterRuleGroup(
            global::System.Collections.Generic.IList<global::OpenRouter.ObservabilityFilterRuleGroupRulesItems> rules,
            global::OpenRouter.ObservabilityFilterRuleGroupLogic? logic)
        {
            this.Logic = logic;
            this.Rules = rules ?? throw new global::System.ArgumentNullException(nameof(rules));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservabilityFilterRuleGroup" /> class.
        /// </summary>
        public ObservabilityFilterRuleGroup()
        {
        }

    }
}