
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A call the model made to a `tool_search` tool declared with `"execution": "client"`. The client runs the search and replays this item with a `tool_search_output` item.<br/>
    /// Example: {"arguments":{"query":"weather"},"call_id":"call-abc123","execution":"client","id":"tsc-abc123","status":"completed","type":"tool_search_call"}
    /// </summary>
    public sealed partial class OutputToolSearchCallItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public object? Arguments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputToolSearchCallItemExecutionJsonConverter))]
        public global::OpenRouter.OutputToolSearchCallItemExecution Execution { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ToolCallStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputToolSearchCallItemTypeJsonConverter))]
        public global::OpenRouter.OutputToolSearchCallItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputToolSearchCallItem" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="status">
        /// Example: completed
        /// </param>
        /// <param name="arguments"></param>
        /// <param name="execution"></param>
        /// <param name="id"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputToolSearchCallItem(
            string callId,
            global::OpenRouter.ToolCallStatus status,
            object? arguments,
            global::OpenRouter.OutputToolSearchCallItemExecution execution,
            string? id,
            global::OpenRouter.OutputToolSearchCallItemType type)
        {
            this.Arguments = arguments;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Execution = execution;
            this.Id = id;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputToolSearchCallItem" /> class.
        /// </summary>
        public OutputToolSearchCallItem()
        {
        }

    }
}