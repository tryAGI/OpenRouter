
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An openrouter:apply_patch server tool output item. The turn halts when validation succeeds so the client can apply the patch and echo an `apply_patch_call_output` on the next turn.
    /// </summary>
    public sealed partial class OutputApplyPatchServerToolItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        public string? CallId { get; set; }

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
        public global::OpenRouter.ApplyPatchCallOperation? Operation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ToolCallStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputApplyPatchServerToolItem" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="callId"></param>
        /// <param name="id"></param>
        /// <param name="operation">
        /// The patch operation requested by an `apply_patch_call`. `create_file` and `update_file` carry a V4A diff; `delete_file` omits it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputApplyPatchServerToolItem(
            global::OpenRouter.ToolCallStatus status,
            string? callId,
            string? id,
            global::OpenRouter.ApplyPatchCallOperation? operation)
        {
            this.CallId = callId;
            this.Id = id;
            this.Operation = operation;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputApplyPatchServerToolItem" /> class.
        /// </summary>
        public OutputApplyPatchServerToolItem()
        {
        }

    }
}