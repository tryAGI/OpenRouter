
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Optional structured filter rules. `null` clears the rules. Omitting keeps the current value.
    /// </summary>
    public sealed partial class UpdateObservabilityDestinationRequestFilterRules
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ObservabilityFilterRuleGroup> Groups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObservabilityDestinationRequestFilterRules" /> class.
        /// </summary>
        /// <param name="groups"></param>
        /// <param name="enabled">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateObservabilityDestinationRequestFilterRules(
            global::System.Collections.Generic.IList<global::OpenRouter.ObservabilityFilterRuleGroup> groups,
            bool? enabled)
        {
            this.Enabled = enabled;
            this.Groups = groups ?? throw new global::System.ArgumentNullException(nameof(groups));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateObservabilityDestinationRequestFilterRules" /> class.
        /// </summary>
        public UpdateObservabilityDestinationRequestFilterRules()
        {
        }

    }
}