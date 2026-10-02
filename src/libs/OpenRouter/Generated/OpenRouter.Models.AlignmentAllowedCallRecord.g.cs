
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AlignmentAllowedCallRecord
    {
        /// <summary>
        /// Number of the record, from 1. A record is one evaluated assistant message; a model call of a server-tool loop that produces several messages has one record per message, and a retry continues the numbering.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Call { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AlignmentAllowedCallRecordOutcomeJsonConverter))]
        public global::OpenRouter.AlignmentAllowedCallRecordOutcome Outcome { get; set; }

        /// <summary>
        /// One record per rule, in the order of `rules` in the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.AlignmentRuleRecord> Rules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlignmentAllowedCallRecord" /> class.
        /// </summary>
        /// <param name="call">
        /// Number of the record, from 1. A record is one evaluated assistant message; a model call of a server-tool loop that produces several messages has one record per message, and a retry continues the numbering.
        /// </param>
        /// <param name="rules">
        /// One record per rule, in the order of `rules` in the request.
        /// </param>
        /// <param name="outcome"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlignmentAllowedCallRecord(
            int call,
            global::System.Collections.Generic.IList<global::OpenRouter.AlignmentRuleRecord> rules,
            global::OpenRouter.AlignmentAllowedCallRecordOutcome outcome)
        {
            this.Call = call;
            this.Outcome = outcome;
            this.Rules = rules ?? throw new global::System.ArgumentNullException(nameof(rules));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlignmentAllowedCallRecord" /> class.
        /// </summary>
        public AlignmentAllowedCallRecord()
        {
        }

    }
}