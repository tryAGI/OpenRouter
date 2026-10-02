
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Incremental chunk of `operation.diff` for an `apply_patch_call`. Matches OpenAI's streaming shape.<br/>
    /// Example: {"delta":"\u002Bconsole.log(\u0022hi\u0022);\n","item_id":"apc_abc123","output_index":0,"sequence_number":5,"type":"response.apply_patch_call_operation_diff.delta"}
    /// </summary>
    public sealed partial class ApplyPatchCallOperationDiffDeltaEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Delta { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ApplyPatchCallOperationDiffDeltaEventTypeJsonConverter))]
        public global::OpenRouter.ApplyPatchCallOperationDiffDeltaEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyPatchCallOperationDiffDeltaEvent" /> class.
        /// </summary>
        /// <param name="delta"></param>
        /// <param name="itemId"></param>
        /// <param name="outputIndex"></param>
        /// <param name="sequenceNumber"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApplyPatchCallOperationDiffDeltaEvent(
            string delta,
            string itemId,
            int outputIndex,
            int sequenceNumber,
            global::OpenRouter.ApplyPatchCallOperationDiffDeltaEventType type)
        {
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyPatchCallOperationDiffDeltaEvent" /> class.
        /// </summary>
        public ApplyPatchCallOperationDiffDeltaEvent()
        {
        }

    }
}