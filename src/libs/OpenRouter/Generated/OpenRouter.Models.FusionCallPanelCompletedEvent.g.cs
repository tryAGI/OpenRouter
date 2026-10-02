
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Emitted when a fusion panel model finishes with its full content.<br/>
    /// Example: {"content":"Full panel response text...","item_id":"st_fusion_abc","model":"openai/gpt-5","output_index":0,"sequence_number":20,"type":"response.fusion_call.panel.completed"}
    /// </summary>
    public sealed partial class FusionCallPanelCompletedEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.FusionCallPanelCompletedEventTypeJsonConverter))]
        public global::OpenRouter.FusionCallPanelCompletedEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FusionCallPanelCompletedEvent" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="itemId"></param>
        /// <param name="model"></param>
        /// <param name="outputIndex"></param>
        /// <param name="sequenceNumber"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FusionCallPanelCompletedEvent(
            string content,
            string itemId,
            string model,
            int outputIndex,
            int sequenceNumber,
            global::OpenRouter.FusionCallPanelCompletedEventType type)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.OutputIndex = outputIndex;
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FusionCallPanelCompletedEvent" /> class.
        /// </summary>
        public FusionCallPanelCompletedEvent()
        {
        }

    }
}