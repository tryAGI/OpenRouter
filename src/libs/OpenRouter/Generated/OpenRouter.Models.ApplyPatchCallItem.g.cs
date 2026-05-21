
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A tool call emitted by the model requesting a V4A patch operation. The client applies the patch and echoes an `apply_patch_call_output` on the next turn.
    /// </summary>
    public sealed partial class ApplyPatchCallItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The patch operation requested by an `apply_patch_call`. `create_file` and `update_file` carry a V4A diff; `delete_file` omits it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ApplyPatchCallOperationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ApplyPatchCallOperation Operation { get; set; }

        /// <summary>
        /// Lifecycle state of an `apply_patch_call` output item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ApplyPatchCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ApplyPatchCallStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ApplyPatchCallItemTypeJsonConverter))]
        public global::OpenRouter.ApplyPatchCallItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyPatchCallItem" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="operation">
        /// The patch operation requested by an `apply_patch_call`. `create_file` and `update_file` carry a V4A diff; `delete_file` omits it.
        /// </param>
        /// <param name="status">
        /// Lifecycle state of an `apply_patch_call` output item.
        /// </param>
        /// <param name="id"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApplyPatchCallItem(
            string callId,
            global::OpenRouter.ApplyPatchCallOperation operation,
            global::OpenRouter.ApplyPatchCallStatus status,
            string? id,
            global::OpenRouter.ApplyPatchCallItemType type)
        {
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Id = id;
            this.Operation = operation;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyPatchCallItem" /> class.
        /// </summary>
        public ApplyPatchCallItem()
        {
        }

    }
}