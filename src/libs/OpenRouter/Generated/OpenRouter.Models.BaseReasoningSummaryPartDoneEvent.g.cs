
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event emitted when a reasoning summary part is complete<br/>
    /// Example: {"item_id":"item-1","output_index":0,"part":{"text":"Analyzing the problem step by step to find the optimal solution.","type":"summary_text"},"sequence_number":7,"summary_index":0,"type":"response.reasoning_summary_part.done"}
    /// </summary>
    public sealed partial class BaseReasoningSummaryPartDoneEvent
    {
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
        /// Example: {"text":"Analyzed the problem using first principles","type":"summary_text"}
        /// </summary>
        /// <example>{"text":"Analyzed the problem using first principles","type":"summary_text"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("part")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ReasoningSummaryText Part { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SummaryIndex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BaseReasoningSummaryPartDoneEventTypeJsonConverter))]
        public global::OpenRouter.BaseReasoningSummaryPartDoneEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseReasoningSummaryPartDoneEvent" /> class.
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="outputIndex"></param>
        /// <param name="part">
        /// Example: {"text":"Analyzed the problem using first principles","type":"summary_text"}
        /// </param>
        /// <param name="sequenceNumber"></param>
        /// <param name="summaryIndex"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseReasoningSummaryPartDoneEvent(
            string itemId,
            int outputIndex,
            global::OpenRouter.ReasoningSummaryText part,
            int sequenceNumber,
            int summaryIndex,
            global::OpenRouter.BaseReasoningSummaryPartDoneEventType type)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.Part = part ?? throw new global::System.ArgumentNullException(nameof(part));
            this.SequenceNumber = sequenceNumber;
            this.SummaryIndex = summaryIndex;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseReasoningSummaryPartDoneEvent" /> class.
        /// </summary>
        public BaseReasoningSummaryPartDoneEvent()
        {
        }

    }
}