
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A native `shell_call` output item matching OpenAI's Responses API shape. Emitted for the sandbox-backed `shell` tool.<br/>
    /// Example: {"action":{"commands":["echo hello"],"max_output_length":null,"timeout_ms":null},"call_id":"call_abc123","id":"shc_abc123","status":"completed","type":"shell_call"}
    /// </summary>
    public sealed partial class OutputShellCallItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public global::OpenRouter.OutputShellCallItemAction? Action { get; set; }

        /// <summary>
        /// The raw tool-call arguments string as emitted by the model. Echo back unchanged when replaying history; used verbatim to preserve provider prompt-cache prefixes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public string? Arguments { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputShellCallItemTypeJsonConverter))]
        public global::OpenRouter.OutputShellCallItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputShellCallItem" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="id"></param>
        /// <param name="status">
        /// Status of a shell call or its output.<br/>
        /// Example: completed
        /// </param>
        /// <param name="action"></param>
        /// <param name="arguments">
        /// The raw tool-call arguments string as emitted by the model. Echo back unchanged when replaying history; used verbatim to preserve provider prompt-cache prefixes.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputShellCallItem(
            string callId,
            string id,
            global::OpenRouter.ShellCallStatus status,
            global::OpenRouter.OutputShellCallItemAction? action,
            string? arguments,
            global::OpenRouter.OutputShellCallItemType type)
        {
            this.Action = action;
            this.Arguments = arguments;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputShellCallItem" /> class.
        /// </summary>
        public OutputShellCallItem()
        {
        }

    }
}