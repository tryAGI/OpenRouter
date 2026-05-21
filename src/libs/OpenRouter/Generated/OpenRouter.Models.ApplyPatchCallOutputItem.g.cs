
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The client's echo of an `apply_patch_call` after applying the patch. `output` is an optional human-readable log; `status` is `completed` when the patch was applied successfully, `failed` otherwise.
    /// </summary>
    public sealed partial class ApplyPatchCallOutputItem
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public string? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ApplyPatchCallOutputItemStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ApplyPatchCallOutputItemStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ApplyPatchCallOutputItemTypeJsonConverter))]
        public global::OpenRouter.ApplyPatchCallOutputItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyPatchCallOutputItem" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="status"></param>
        /// <param name="id"></param>
        /// <param name="output"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApplyPatchCallOutputItem(
            string callId,
            global::OpenRouter.ApplyPatchCallOutputItemStatus status,
            string? id,
            string? output,
            global::OpenRouter.ApplyPatchCallOutputItemType type)
        {
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Id = id;
            this.Output = output;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyPatchCallOutputItem" /> class.
        /// </summary>
        public ApplyPatchCallOutputItem()
        {
        }

    }
}