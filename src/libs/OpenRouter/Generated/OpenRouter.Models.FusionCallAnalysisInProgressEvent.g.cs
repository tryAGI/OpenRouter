
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Emitted when the fusion analyst starts producing the structured analysis.<br/>
    /// Example: {"analyst_model":"openai/gpt-5","item_id":"st_fusion_abc","judge_model":"openai/gpt-5","output_index":0,"sequence_number":25,"type":"response.fusion_call.analysis.in_progress"}
    /// </summary>
    public sealed partial class FusionCallAnalysisInProgressEvent
    {
        /// <summary>
        /// Slug of the model producing the structured analysis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analyst_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AnalystModel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// Deprecated alias of `analyst_model`, kept so existing consumers keep working. Always carries the same value. Use `analyst_model`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("judge_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JudgeModel { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.FusionCallAnalysisInProgressEventTypeJsonConverter))]
        public global::OpenRouter.FusionCallAnalysisInProgressEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FusionCallAnalysisInProgressEvent" /> class.
        /// </summary>
        /// <param name="analystModel">
        /// Slug of the model producing the structured analysis.
        /// </param>
        /// <param name="itemId"></param>
        /// <param name="judgeModel">
        /// Deprecated alias of `analyst_model`, kept so existing consumers keep working. Always carries the same value. Use `analyst_model`.
        /// </param>
        /// <param name="outputIndex"></param>
        /// <param name="sequenceNumber"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FusionCallAnalysisInProgressEvent(
            string analystModel,
            string itemId,
            string judgeModel,
            int outputIndex,
            int sequenceNumber,
            global::OpenRouter.FusionCallAnalysisInProgressEventType type)
        {
            this.AnalystModel = analystModel ?? throw new global::System.ArgumentNullException(nameof(analystModel));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.JudgeModel = judgeModel ?? throw new global::System.ArgumentNullException(nameof(judgeModel));
            this.OutputIndex = outputIndex;
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FusionCallAnalysisInProgressEvent" /> class.
        /// </summary>
        public FusionCallAnalysisInProgressEvent()
        {
        }

    }
}