
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An openrouter:bash server tool output item<br/>
    /// Example: {"command":"ls -la","exitCode":0,"id":"bash_tmp_abc123","status":"completed","stdout":"total 0\n","type":"openrouter:bash"}
    /// </summary>
    public sealed partial class OutputBashServerToolItem
    {
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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("command")]
        public string? Command { get; set; }

        /// <summary>
        /// The canonical container id the command ran under — the `{container_id}` for the Container Files API, reusable as a `container_reference` in later requests. Present on every sandbox-executed call, even when no files changed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container_id")]
        public string? ContainerId { get; set; }

        /// <summary>
        /// The error message when the sandbox call failed before producing a result (for example, the per-user container limit was reached). Set together with `status: 'failed'`; absent on a successful call. A non-zero `exitCode` is a command failure, not a tool failure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exitCode")]
        public int? ExitCode { get; set; }

        /// <summary>
        /// Citations for the files the sandbox command created or modified, most-recently-touched first (at most 10). Retrieve them via the Container Files API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputBashServerToolItemFile>? Files { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("stderr")]
        public string? Stderr { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stdout")]
        public string? Stdout { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputBashServerToolItemTypeJsonConverter))]
        public global::OpenRouter.OutputBashServerToolItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputBashServerToolItem" /> class.
        /// </summary>
        /// <param name="status">
        /// Example: completed
        /// </param>
        /// <param name="arguments">
        /// The raw tool-call arguments string as emitted by the model.
        /// </param>
        /// <param name="callId">
        /// The model-generated tool call id from the originating turn.
        /// </param>
        /// <param name="command"></param>
        /// <param name="containerId">
        /// The canonical container id the command ran under — the `{container_id}` for the Container Files API, reusable as a `container_reference` in later requests. Present on every sandbox-executed call, even when no files changed.
        /// </param>
        /// <param name="error">
        /// The error message when the sandbox call failed before producing a result (for example, the per-user container limit was reached). Set together with `status: 'failed'`; absent on a successful call. A non-zero `exitCode` is a command failure, not a tool failure.
        /// </param>
        /// <param name="exitCode"></param>
        /// <param name="files">
        /// Citations for the files the sandbox command created or modified, most-recently-touched first (at most 10). Retrieve them via the Container Files API.
        /// </param>
        /// <param name="id"></param>
        /// <param name="stderr"></param>
        /// <param name="stdout"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputBashServerToolItem(
            global::OpenRouter.FailableToolCallStatus status,
            string? arguments,
            string? callId,
            string? command,
            string? containerId,
            string? error,
            int? exitCode,
            global::System.Collections.Generic.IList<global::OpenRouter.OutputBashServerToolItemFile>? files,
            string? id,
            string? stderr,
            string? stdout,
            global::OpenRouter.OutputBashServerToolItemType type)
        {
            this.Arguments = arguments;
            this.CallId = callId;
            this.Command = command;
            this.ContainerId = containerId;
            this.Error = error;
            this.ExitCode = exitCode;
            this.Files = files;
            this.Id = id;
            this.Status = status;
            this.Stderr = stderr;
            this.Stdout = stdout;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputBashServerToolItem" /> class.
        /// </summary>
        public OutputBashServerToolItem()
        {
        }

    }
}