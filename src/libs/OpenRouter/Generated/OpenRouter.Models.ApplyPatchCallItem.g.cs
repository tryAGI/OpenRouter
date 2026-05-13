
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A file create/update/delete via diff patch
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ApplyPatchCallItemOperationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ApplyPatchCallItemOperation Operation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ApplyPatchCallItemStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ApplyPatchCallItemStatus Status { get; set; }

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
        /// <param name="operation"></param>
        /// <param name="status"></param>
        /// <param name="id"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApplyPatchCallItem(
            string callId,
            global::OpenRouter.ApplyPatchCallItemOperation operation,
            global::OpenRouter.ApplyPatchCallItemStatus status,
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