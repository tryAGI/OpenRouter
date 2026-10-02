
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An openrouter:shell server tool output item<br/>
    /// Example: {"action":{"commands":["echo hello"],"max_output_length":null,"timeout_ms":null},"call_id":"call_abc123","id":"st_tmp_abc123","output":[{"outcome":{"exit_code":0,"type":"exit"},"stderr":"","stdout":"hello\n"}],"status":"completed","type":"openrouter:shell"}
    /// </summary>
    public sealed partial class OutputShellServerToolItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public global::OpenRouter.OutputShellServerToolItemAction? Action { get; set; }

        /// <summary>
        /// The raw tool-call arguments string as emitted by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public string? Arguments { get; set; }

        /// <summary>
        /// The model-generated tool call id from the originating turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        public string? CallId { get; set; }

        /// <summary>
        /// The canonical container id the command ran under — the `{container_id}` for the Container Files API, reusable as a `container_reference` in later requests. Present on every sandbox-executed call, even when no files changed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container_id")]
        public string? ContainerId { get; set; }

        /// <summary>
        /// The error message when the sandbox call failed before producing a result (for example, the per-user container limit was reached). Set together with `status: 'failed'`; absent on a successful call. `output` is omitted when `error` is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Citations for the files the sandbox command created or modified, most-recently-touched first (at most 10). Retrieve them via the Container Files API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputShellServerToolItemFile>? Files { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ShellCallOutputContent>? Output { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputShellServerToolItemTypeJsonConverter))]
        public global::OpenRouter.OutputShellServerToolItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputShellServerToolItem" /> class.
        /// </summary>
        /// <param name="status">
        /// Example: completed
        /// </param>
        /// <param name="action"></param>
        /// <param name="arguments">
        /// The raw tool-call arguments string as emitted by the model.
        /// </param>
        /// <param name="callId">
        /// The model-generated tool call id from the originating turn.
        /// </param>
        /// <param name="containerId">
        /// The canonical container id the command ran under — the `{container_id}` for the Container Files API, reusable as a `container_reference` in later requests. Present on every sandbox-executed call, even when no files changed.
        /// </param>
        /// <param name="error">
        /// The error message when the sandbox call failed before producing a result (for example, the per-user container limit was reached). Set together with `status: 'failed'`; absent on a successful call. `output` is omitted when `error` is set.
        /// </param>
        /// <param name="files">
        /// Citations for the files the sandbox command created or modified, most-recently-touched first (at most 10). Retrieve them via the Container Files API.
        /// </param>
        /// <param name="id"></param>
        /// <param name="output"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputShellServerToolItem(
            global::OpenRouter.FailableToolCallStatus status,
            global::OpenRouter.OutputShellServerToolItemAction? action,
            string? arguments,
            string? callId,
            string? containerId,
            string? error,
            global::System.Collections.Generic.IList<global::OpenRouter.OutputShellServerToolItemFile>? files,
            string? id,
            global::System.Collections.Generic.IList<global::OpenRouter.ShellCallOutputContent>? output,
            global::OpenRouter.OutputShellServerToolItemType type)
        {
            this.Action = action;
            this.Arguments = arguments;
            this.CallId = callId;
            this.ContainerId = containerId;
            this.Error = error;
            this.Files = files;
            this.Id = id;
            this.Output = output;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputShellServerToolItem" /> class.
        /// </summary>
        public OutputShellServerToolItem()
        {
        }

    }
}