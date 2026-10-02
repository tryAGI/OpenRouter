
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Event emitted when text streaming is complete<br/>
    /// Example: {"content_index":0,"item_id":"item-1","logprobs":[],"output_index":0,"sequence_number":6,"text":"Hello! How can I help you?","type":"response.output_text.done"}
    /// </summary>
    public sealed partial class BaseTextDoneEvent
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
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.OpenResponsesLogProbs> Logprobs { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BaseTextDoneEventTypeJsonConverter))]
        public global::OpenRouter.BaseTextDoneEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseTextDoneEvent" /> class.
        /// </summary>
        /// <param name="contentIndex"></param>
        /// <param name="itemId"></param>
        /// <param name="logprobs"></param>
        /// <param name="outputIndex"></param>
        /// <param name="sequenceNumber"></param>
        /// <param name="text"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseTextDoneEvent(
            int contentIndex,
            string itemId,
            global::System.Collections.Generic.IList<global::OpenRouter.OpenResponsesLogProbs> logprobs,
            int outputIndex,
            int sequenceNumber,
            string text,
            global::OpenRouter.BaseTextDoneEventType type)
        {
            this.ContentIndex = contentIndex;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.Logprobs = logprobs ?? throw new global::System.ArgumentNullException(nameof(logprobs));
            this.OutputIndex = outputIndex;
            this.SequenceNumber = sequenceNumber;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseTextDoneEvent" /> class.
        /// </summary>
        public BaseTextDoneEvent()
        {
        }

    }
}