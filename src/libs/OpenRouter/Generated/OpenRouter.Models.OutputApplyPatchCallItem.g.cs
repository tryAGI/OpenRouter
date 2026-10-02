
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A native `apply_patch_call` output item matching OpenAI's Responses API shape. Emitted when the client requested the `apply_patch` shorthand.<br/>
    /// Example: {"call_id":"call_abc123","id":"apc_abc123","operation":{"diff":"@@ function main() {\n\u002B  console.log(\u0022hi\u0022);\n }","path":"/src/main.ts","type":"update_file"},"status":"completed","type":"apply_patch_call"}
    /// </summary>
    public sealed partial class OutputApplyPatchCallItem
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The patch operation requested by an `apply_patch_call`. `create_file` and `update_file` carry a V4A diff; `delete_file` omits it.<br/>
        /// Example: {"diff":"@@ function main() {\n\u002B  console.log(\u0022hi\u0022);\n }","path":"/src/main.ts","type":"update_file"}
        /// </summary>
        /// <example>{"diff":"@@ function main() {\n\u002B  console.log(\u0022hi\u0022);\n }","path":"/src/main.ts","type":"update_file"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ApplyPatchCallOperationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ApplyPatchCallOperation Operation { get; set; }

        /// <summary>
        /// Lifecycle state of an `apply_patch_call` output item.<br/>
        /// Example: completed
        /// </summary>
        /// <example>completed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ApplyPatchCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ApplyPatchCallStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputApplyPatchCallItemTypeJsonConverter))]
        public global::OpenRouter.OutputApplyPatchCallItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputApplyPatchCallItem" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="id"></param>
        /// <param name="operation">
        /// The patch operation requested by an `apply_patch_call`. `create_file` and `update_file` carry a V4A diff; `delete_file` omits it.<br/>
        /// Example: {"diff":"@@ function main() {\n\u002B  console.log(\u0022hi\u0022);\n }","path":"/src/main.ts","type":"update_file"}
        /// </param>
        /// <param name="status">
        /// Lifecycle state of an `apply_patch_call` output item.<br/>
        /// Example: completed
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputApplyPatchCallItem(
            string callId,
            string id,
            global::OpenRouter.ApplyPatchCallOperation operation,
            global::OpenRouter.ApplyPatchCallStatus status,
            global::OpenRouter.OutputApplyPatchCallItemType type)
        {
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Operation = operation;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputApplyPatchCallItem" /> class.
        /// </summary>
        public OutputApplyPatchCallItem()
        {
        }

    }
}