
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An openrouter:subagent server tool output item
    /// </summary>
    public sealed partial class OutputSubagentServerToolItem
    {
        /// <summary>
        /// Error message when the subagent task did not produce an outcome.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Slug of the worker model that executed the task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The worker model's result (the outcome text returned to the delegating model).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        public string? Outcome { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ToolCallStatus Status { get; set; }

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
        /// <param name="status"></param>
        /// <param name="error">
        /// Error message when the subagent task did not produce an outcome.
        /// </param>
        /// <param name="id"></param>
        /// <param name="model">
        /// Slug of the worker model that executed the task.
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
            global::OpenRouter.ToolCallStatus status,
            string? error,
            string? id,
            string? model,
            string? outcome,
            string? taskDescription,
            string? taskName,
            global::OpenRouter.OutputSubagentServerToolItemType type)
        {
            this.Error = error;
            this.Id = id;
            this.Model = model;
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