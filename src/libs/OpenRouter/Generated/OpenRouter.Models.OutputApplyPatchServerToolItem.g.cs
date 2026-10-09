
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An openrouter:apply_patch server tool output item. The turn halts when validation succeeds so the client can apply the patch and echo an `apply_patch_call_output` on the next turn.<br/>
    /// Example: {"call_id":"call_abc123","id":"apc_abc123","operation":{"diff":"@@ function main() {\n\u002B  console.log(\u0022hi\u0022);\n }","path":"/src/main.ts","type":"update_file"},"status":"completed","type":"openrouter:apply_patch"}
    /// </summary>
    public sealed partial class OutputApplyPatchServerToolItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        public string? CallId { get; set; }

        /// <summary>
        /// The error message when the tool call failed before producing a result. Set together with `status: 'failed'`; absent on a successful call.<br/>
        /// Example: Tool execution failed
        /// </summary>
        /// <example>Tool execution failed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The patch operation requested by an `apply_patch_call`. `create_file` and `update_file` carry a V4A diff; `delete_file` omits it.<br/>
        /// Example: {"diff":"@@ function main() {\n\u002B  console.log(\u0022hi\u0022);\n }","path":"/src/main.ts","type":"update_file"}
        /// </summary>
        /// <example>{"diff":"@@ function main() {\n\u002B  console.log(\u0022hi\u0022);\n }","path":"/src/main.ts","type":"update_file"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ApplyPatchCallOperationJsonConverter))]
        public global::OpenRouter.ApplyPatchCallOperation? Operation { get; set; }

        /// <summary>
        /// Example: completed
        /// </summary>
        /// <example>completed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.FailableToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.FailableToolCallStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputApplyPatchServerToolItemTypeJsonConverter))]
        public global::OpenRouter.OutputApplyPatchServerToolItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputApplyPatchServerToolItem" /> class.
        /// </summary>
        /// <param name="status">
        /// Example: completed
        /// </param>
        /// <param name="callId"></param>
        /// <param name="error">
        /// The error message when the tool call failed before producing a result. Set together with `status: 'failed'`; absent on a successful call.<br/>
        /// Example: Tool execution failed
        /// </param>
        /// <param name="id"></param>
        /// <param name="operation">
        /// The patch operation requested by an `apply_patch_call`. `create_file` and `update_file` carry a V4A diff; `delete_file` omits it.<br/>
        /// Example: {"diff":"@@ function main() {\n\u002B  console.log(\u0022hi\u0022);\n }","path":"/src/main.ts","type":"update_file"}
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputApplyPatchServerToolItem(
            global::OpenRouter.FailableToolCallStatus status,
            string? callId,
            string? error,
            string? id,
            global::OpenRouter.ApplyPatchCallOperation? operation,
            global::OpenRouter.OutputApplyPatchServerToolItemType type)
        {
            this.CallId = callId;
            this.Error = error;
            this.Id = id;
            this.Operation = operation;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputApplyPatchServerToolItem" /> class.
        /// </summary>
        public OutputApplyPatchServerToolItem()
        {
        }

    }
}