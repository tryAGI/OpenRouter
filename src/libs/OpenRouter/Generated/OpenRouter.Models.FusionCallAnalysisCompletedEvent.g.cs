
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Emitted when the fusion analyst completes with the structured analysis.<br/>
    /// Example: {"analysis":{"blind_spots":[],"consensus":[],"contradictions":[],"partial_coverage":[],"unique_insights":[]},"item_id":"st_fusion_abc","output_index":0,"sequence_number":40,"type":"response.fusion_call.analysis.completed"}
    /// </summary>
    public sealed partial class FusionCallAnalysisCompletedEvent
    {
        /// <summary>
        /// Structured analysis produced by the fusion analyst model.<br/>
        /// Example: {"blind_spots":["No model considered the impact on existing API consumers."],"consensus":["All panel models agree the request is asking for a concise summary."],"contradictions":[{"stances":[{"model":"openai/gpt-5","stance":"Favors an incremental rollout."},{"model":"anthropic/claude-sonnet-4.5","stance":"Favors a single coordinated migration."}],"topic":"Recommended approach"}],"partial_coverage":[{"models":["openai/gpt-5"],"point":"Only one model addressed the rollback strategy."}],"unique_insights":[{"insight":"Highlighted a backwards-compatibility risk the other models missed.","model":"anthropic/claude-sonnet-4.5"}]}
        /// </summary>
        /// <example>{"blind_spots":["No model considered the impact on existing API consumers."],"consensus":["All panel models agree the request is asking for a concise summary."],"contradictions":[{"stances":[{"model":"openai/gpt-5","stance":"Favors an incremental rollout."},{"model":"anthropic/claude-sonnet-4.5","stance":"Favors a single coordinated migration."}],"topic":"Recommended approach"}],"partial_coverage":[{"models":["openai/gpt-5"],"point":"Only one model addressed the rollback strategy."}],"unique_insights":[{"insight":"Highlighted a backwards-compatibility risk the other models missed.","model":"anthropic/claude-sonnet-4.5"}]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.FusionAnalysisResult Analysis { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.FusionCallAnalysisCompletedEventTypeJsonConverter))]
        public global::OpenRouter.FusionCallAnalysisCompletedEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FusionCallAnalysisCompletedEvent" /> class.
        /// </summary>
        /// <param name="analysis">
        /// Structured analysis produced by the fusion analyst model.<br/>
        /// Example: {"blind_spots":["No model considered the impact on existing API consumers."],"consensus":["All panel models agree the request is asking for a concise summary."],"contradictions":[{"stances":[{"model":"openai/gpt-5","stance":"Favors an incremental rollout."},{"model":"anthropic/claude-sonnet-4.5","stance":"Favors a single coordinated migration."}],"topic":"Recommended approach"}],"partial_coverage":[{"models":["openai/gpt-5"],"point":"Only one model addressed the rollback strategy."}],"unique_insights":[{"insight":"Highlighted a backwards-compatibility risk the other models missed.","model":"anthropic/claude-sonnet-4.5"}]}
        /// </param>
        /// <param name="itemId"></param>
        /// <param name="outputIndex"></param>
        /// <param name="sequenceNumber"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FusionCallAnalysisCompletedEvent(
            global::OpenRouter.FusionAnalysisResult analysis,
            string itemId,
            int outputIndex,
            int sequenceNumber,
            global::OpenRouter.FusionCallAnalysisCompletedEventType type)
        {
            this.Analysis = analysis ?? throw new global::System.ArgumentNullException(nameof(analysis));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FusionCallAnalysisCompletedEvent" /> class.
        /// </summary>
        public FusionCallAnalysisCompletedEvent()
        {
        }

    }
}