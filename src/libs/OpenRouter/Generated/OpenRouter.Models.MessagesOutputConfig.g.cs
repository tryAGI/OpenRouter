
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Configuration for controlling output behavior. Supports the effort parameter and structured output format.
    /// </summary>
    public sealed partial class MessagesOutputConfig
    {
        /// <summary>
        /// How much effort the model should put into its response. Higher effort levels may result in more thorough analysis but take longer. Valid values are `low`, `medium`, `high`, `xhigh`, or `max`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.MessagesOutputConfigEffort?, object>))]
        public global::OpenRouter.OneOf<global::OpenRouter.MessagesOutputConfigEffort?, object>? Effort { get; set; }

        /// <summary>
        /// A schema to specify Claude's output format in responses. See [structured outputs](https://platform.claude.com/docs/en/build-with-claude/structured-outputs).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.MessagesOutputConfigFormat, object>))]
        public global::OpenRouter.OneOf<global::OpenRouter.MessagesOutputConfigFormat, object>? Format { get; set; }

        /// <summary>
        /// Task budget for an agentic turn. The model sees a countdown of remaining tokens and uses it to prioritize work and wind down gracefully. Advisory — does not enforce a hard cap.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_budget")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.MessagesOutputConfigTaskBudget, object>))]
        public global::OpenRouter.OneOf<global::OpenRouter.MessagesOutputConfigTaskBudget, object>? TaskBudget { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesOutputConfig" /> class.
        /// </summary>
        /// <param name="effort">
        /// How much effort the model should put into its response. Higher effort levels may result in more thorough analysis but take longer. Valid values are `low`, `medium`, `high`, `xhigh`, or `max`.
        /// </param>
        /// <param name="format">
        /// A schema to specify Claude's output format in responses. See [structured outputs](https://platform.claude.com/docs/en/build-with-claude/structured-outputs).
        /// </param>
        /// <param name="taskBudget">
        /// Task budget for an agentic turn. The model sees a countdown of remaining tokens and uses it to prioritize work and wind down gracefully. Advisory — does not enforce a hard cap.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesOutputConfig(
            global::OpenRouter.OneOf<global::OpenRouter.MessagesOutputConfigEffort?, object>? effort,
            global::OpenRouter.OneOf<global::OpenRouter.MessagesOutputConfigFormat, object>? format,
            global::OpenRouter.OneOf<global::OpenRouter.MessagesOutputConfigTaskBudget, object>? taskBudget)
        {
            this.Effort = effort;
            this.Format = format;
            this.TaskBudget = taskBudget;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesOutputConfig" /> class.
        /// </summary>
        public MessagesOutputConfig()
        {
        }
    }
}