
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"call_id":"call_abc123","id":"apc_abc123","operation":{"diff":"@@ function main() {\n\u002B  console.log(\u0022hi\u0022);\n }","path":"/src/main.ts","type":"update_file"},"status":"completed","type":"apply_patch_call"}
    /// </summary>
    public sealed partial class OutputItemApplyPatchCall
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
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OperationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.Operation Operation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputItemApplyPatchCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OutputItemApplyPatchCallStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputItemApplyPatchCallTypeJsonConverter))]
        public global::OpenRouter.OutputItemApplyPatchCallType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemApplyPatchCall" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="id"></param>
        /// <param name="operation"></param>
        /// <param name="status"></param>
        /// <param name="createdBy"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputItemApplyPatchCall(
            string callId,
            string id,
            global::OpenRouter.Operation operation,
            global::OpenRouter.OutputItemApplyPatchCallStatus status,
            string? createdBy,
            global::OpenRouter.OutputItemApplyPatchCallType type)
        {
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.CreatedBy = createdBy;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Operation = operation;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputItemApplyPatchCall" /> class.
        /// </summary>
        public OutputItemApplyPatchCall()
        {
        }

    }
}