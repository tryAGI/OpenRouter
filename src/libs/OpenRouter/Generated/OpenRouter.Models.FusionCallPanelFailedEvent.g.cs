
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Emitted when a fusion panel model fails.<br/>
    /// Example: {"error":"Upstream provider error","item_id":"st_fusion_abc","model":"openai/gpt-5","output_index":0,"sequence_number":18,"status_code":502,"type":"response.fusion_call.panel.failed"}
    /// </summary>
    public sealed partial class FusionCallPanelFailedEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        public int? StatusCode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.FusionCallPanelFailedEventTypeJsonConverter))]
        public global::OpenRouter.FusionCallPanelFailedEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FusionCallPanelFailedEvent" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="itemId"></param>
        /// <param name="model"></param>
        /// <param name="outputIndex"></param>
        /// <param name="sequenceNumber"></param>
        /// <param name="statusCode"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FusionCallPanelFailedEvent(
            string error,
            string itemId,
            string model,
            int outputIndex,
            int sequenceNumber,
            int? statusCode,
            global::OpenRouter.FusionCallPanelFailedEventType type)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.OutputIndex = outputIndex;
            this.SequenceNumber = sequenceNumber;
            this.StatusCode = statusCode;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FusionCallPanelFailedEvent" /> class.
        /// </summary>
        public FusionCallPanelFailedEvent()
        {
        }

    }
}