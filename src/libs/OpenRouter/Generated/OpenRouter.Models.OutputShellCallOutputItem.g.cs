
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A native `shell_call_output` item matching OpenAI's Responses API shape. Carries per-command stdout, stderr, and the exit/timeout outcome. A sandbox failure terminates the item as `incomplete` with `error` set.<br/>
    /// Example: {"call_id":"call_abc123","id":"sho_abc123","output":[{"outcome":{"exit_code":0,"type":"exit"},"stderr":"","stdout":"hello\n"}],"status":"completed","type":"shell_call_output"}
    /// </summary>
    public sealed partial class OutputShellCallOutputItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// The canonical container id the command ran under — the `{container_id}` for the Container Files API, reusable as a `container_reference` in later requests. Present on every sandbox-executed call, even when no files changed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container_id")]
        public string? ContainerId { get; set; }

        /// <summary>
        /// The error message when the sandbox call failed before producing a result (for example, the per-user container limit was reached). Set together with `status: 'incomplete'` and an empty `output`; absent on a successful call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Citations for the files the sandbox command created or modified, most-recently-touched first (at most 10). Retrieve them via the Container Files API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<global::OpenRouter.OutputShellCallOutputItemFile>? Files { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_length")]
        public int? MaxOutputLength { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ShellCallOutputContent> Output { get; set; }

        /// <summary>
        /// Status of a shell call or its output.<br/>
        /// Example: completed
        /// </summary>
        /// <example>completed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ShellCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ShellCallStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputShellCallOutputItemTypeJsonConverter))]
        public global::OpenRouter.OutputShellCallOutputItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputShellCallOutputItem" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="id"></param>
        /// <param name="output"></param>
        /// <param name="status">
        /// Status of a shell call or its output.<br/>
        /// Example: completed
        /// </param>
        /// <param name="containerId">
        /// The canonical container id the command ran under — the `{container_id}` for the Container Files API, reusable as a `container_reference` in later requests. Present on every sandbox-executed call, even when no files changed.
        /// </param>
        /// <param name="error">
        /// The error message when the sandbox call failed before producing a result (for example, the per-user container limit was reached). Set together with `status: 'incomplete'` and an empty `output`; absent on a successful call.
        /// </param>
        /// <param name="files">
        /// Citations for the files the sandbox command created or modified, most-recently-touched first (at most 10). Retrieve them via the Container Files API.
        /// </param>
        /// <param name="maxOutputLength"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputShellCallOutputItem(
            string callId,
            string id,
            global::System.Collections.Generic.IList<global::OpenRouter.ShellCallOutputContent> output,
            global::OpenRouter.ShellCallStatus status,
            string? containerId,
            string? error,
            global::System.Collections.Generic.IList<global::OpenRouter.OutputShellCallOutputItemFile>? files,
            int? maxOutputLength,
            global::OpenRouter.OutputShellCallOutputItemType type)
        {
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.ContainerId = containerId;
            this.Error = error;
            this.Files = files;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.MaxOutputLength = maxOutputLength;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputShellCallOutputItem" /> class.
        /// </summary>
        public OutputShellCallOutputItem()
        {
        }

    }
}