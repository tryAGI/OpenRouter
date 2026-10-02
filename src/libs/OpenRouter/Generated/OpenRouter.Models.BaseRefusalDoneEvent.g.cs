
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event emitted when refusal streaming is complete<br/>
    /// Example: {"content_index":0,"item_id":"item-1","output_index":0,"refusal":"I\u0027m sorry, but I can\u0027t assist with that request.","sequence_number":6,"type":"response.refusal.done"}
    /// </summary>
    public sealed partial class BaseRefusalDoneEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContentIndex { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("refusal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Refusal { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BaseRefusalDoneEventTypeJsonConverter))]
        public global::OpenRouter.BaseRefusalDoneEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRefusalDoneEvent" /> class.
        /// </summary>
        /// <param name="contentIndex"></param>
        /// <param name="itemId"></param>
        /// <param name="outputIndex"></param>
        /// <param name="refusal"></param>
        /// <param name="sequenceNumber"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseRefusalDoneEvent(
            int contentIndex,
            string itemId,
            int outputIndex,
            string refusal,
            int sequenceNumber,
            global::OpenRouter.BaseRefusalDoneEventType type)
        {
            this.ContentIndex = contentIndex;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.Refusal = refusal ?? throw new global::System.ArgumentNullException(nameof(refusal));
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRefusalDoneEvent" /> class.
        /// </summary>
        public BaseRefusalDoneEvent()
        {
        }

    }
}