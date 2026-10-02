
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event emitted when an output item is complete<br/>
    /// Example: {"item":{"content":[{"annotations":[],"text":"Hello! How can I help you?","type":"output_text"}],"id":"item-1","role":"assistant","status":"completed","type":"message"},"output_index":0,"sequence_number":8,"type":"response.output_item.done"}
    /// </summary>
    public sealed partial class OutputItemDoneEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.Item2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.Item2 Item { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputItemDoneEventTypeJsonConverter))]
        public global::OpenRouter.OutputItemDoneEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemDoneEvent" /> class.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="outputIndex"></param>
        /// <param name="sequenceNumber"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputItemDoneEvent(
            global::OpenRouter.Item2 item,
            int outputIndex,
            int sequenceNumber,
            global::OpenRouter.OutputItemDoneEventType type)
        {
            this.Item = item;
            this.OutputIndex = outputIndex;
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemDoneEvent" /> class.
        /// </summary>
        public OutputItemDoneEvent()
        {
        }

    }
}