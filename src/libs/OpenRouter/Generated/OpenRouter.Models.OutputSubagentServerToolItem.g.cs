
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An openrouter:subagent server tool output item<br/>
    /// Example: {"id":"st_tmp_abc123","status":"completed","type":"openrouter:subagent"}
    /// </summary>
    public sealed partial class OutputSubagentServerToolItem
    {
        /// <summary>
        /// EXPERIMENTAL — subject to change without notice. The `call_id` of the tool call that spawned this subagent. This id will also be included as the `subagent_id` on any `function_call` items created by the subagent. This must be returned in the request so the `function_call` can be matched with the correct subagent. A suspended `in_progress` item is announced once and never re-emitted or terminally closed — completion arrives as a new item with the same `call_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        public string? CallId { get; set; }

        /// <summary>
        /// Error message when the subagent task did not produce an outcome. Set together with `status: 'failed'` on the terminal item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Provider-safe function name of the specific subagent instance that produced this item (e.g. `openrouter_subagent__1`). Present only on items from non-default instances — the second and later subagent entries in the request `tools` array. The first (default) instance omits it, even when multiple subagents are configured. When a replayed item echoes this field back, the transcript rehydrates the call under that instance's tool. This identity is positional: it is derived from the index of the subagent entry in the request `tools` array, so keep the order of subagent entries stable across requests in a conversation.<br/>
        /// Example: openrouter_subagent__1
        /// </summary>
        /// <example>openrouter_subagent__1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance_name")]
        public string? InstanceName { get; set; }

        /// <summary>
        /// Slug of the worker model that executed the task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Configured name of the subagent that executed the task (the `name` on its tool entry). Present only for named subagents; omitted for an unnamed (default) subagent.<br/>
        /// Example: summarizer
        /// </summary>
        /// <example>summarizer</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The worker model's result (the outcome text returned to the delegating model).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        public string? Outcome { get; set; }

        /// <summary>
        /// Example: completed
        /// </summary>
        /// <example>completed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.FailableToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.FailableToolCallStatus Status { get; set; }

        /// <summary>
        /// The task description the delegating model sent to the worker.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_description")]
        public string? TaskDescription { get; set; }

        /// <summary>
        /// The short task identifier the delegating model supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_name")]
        public string? TaskName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OutputSubagentServerToolItemTypeJsonConverter))]
        public global::OpenRouter.OutputSubagentServerToolItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputSubagentServerToolItem" /> class.
        /// </summary>
        /// <param name="status">
        /// Example: completed
        /// </param>
        /// <param name="callId">
        /// EXPERIMENTAL — subject to change without notice. The `call_id` of the tool call that spawned this subagent. This id will also be included as the `subagent_id` on any `function_call` items created by the subagent. This must be returned in the request so the `function_call` can be matched with the correct subagent. A suspended `in_progress` item is announced once and never re-emitted or terminally closed — completion arrives as a new item with the same `call_id`.
        /// </param>
        /// <param name="error">
        /// Error message when the subagent task did not produce an outcome. Set together with `status: 'failed'` on the terminal item.
        /// </param>
        /// <param name="id"></param>
        /// <param name="instanceName">
        /// Provider-safe function name of the specific subagent instance that produced this item (e.g. `openrouter_subagent__1`). Present only on items from non-default instances — the second and later subagent entries in the request `tools` array. The first (default) instance omits it, even when multiple subagents are configured. When a replayed item echoes this field back, the transcript rehydrates the call under that instance's tool. This identity is positional: it is derived from the index of the subagent entry in the request `tools` array, so keep the order of subagent entries stable across requests in a conversation.<br/>
        /// Example: openrouter_subagent__1
        /// </param>
        /// <param name="model">
        /// Slug of the worker model that executed the task.
        /// </param>
        /// <param name="name">
        /// Configured name of the subagent that executed the task (the `name` on its tool entry). Present only for named subagents; omitted for an unnamed (default) subagent.<br/>
        /// Example: summarizer
        /// </param>
        /// <param name="outcome">
        /// The worker model's result (the outcome text returned to the delegating model).
        /// </param>
        /// <param name="taskDescription">
        /// The task description the delegating model sent to the worker.
        /// </param>
        /// <param name="taskName">
        /// The short task identifier the delegating model supplied.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutputSubagentServerToolItem(
            global::OpenRouter.FailableToolCallStatus status,
            string? callId,
            string? error,
            string? id,
            string? instanceName,
            string? model,
            string? name,
            string? outcome,
            string? taskDescription,
            string? taskName,
            global::OpenRouter.OutputSubagentServerToolItemType type)
        {
            this.CallId = callId;
            this.Error = error;
            this.Id = id;
            this.InstanceName = instanceName;
            this.Model = model;
            this.Name = name;
            this.Outcome = outcome;
            this.Status = status;
            this.TaskDescription = taskDescription;
            this.TaskName = taskName;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputSubagentServerToolItem" /> class.
        /// </summary>
        public OutputSubagentServerToolItem()
        {
        }

    }
}