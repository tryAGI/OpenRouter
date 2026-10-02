
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AlignmentUnavailableCallRecord
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AlignmentUnavailableCallRecordOutcomeJsonConverter))]
        public global::OpenRouter.AlignmentUnavailableCallRecordOutcome Outcome { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AlignmentUnavailableCallRecordReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AlignmentUnavailableCallRecordReason Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlignmentUnavailableCallRecord" /> class.
        /// </summary>
        /// <param name="call">
        /// Number of the record, from 1. A record is one evaluated assistant message; a model call of a server-tool loop that produces several messages has one record per message, and a retry continues the numbering.
        /// </param>
        /// <param name="reason"></param>
        /// <param name="outcome"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlignmentUnavailableCallRecord(
            int call,
            global::OpenRouter.AlignmentUnavailableCallRecordReason reason,
            global::OpenRouter.AlignmentUnavailableCallRecordOutcome outcome)
        {
            this.Call = call;
            this.Outcome = outcome;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlignmentUnavailableCallRecord" /> class.
        /// </summary>
        public AlignmentUnavailableCallRecord()
        {
        }

    }
}