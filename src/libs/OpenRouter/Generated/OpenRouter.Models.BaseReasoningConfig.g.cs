
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"effort":"medium","summary":"auto"}
    /// </summary>
    public sealed partial class BaseReasoningConfig
    {
        /// <summary>
        /// Controls which reasoning is available to the model. `auto` uses the model default (same as omitting); `all_turns` includes reasoning from earlier turns passed in input; `current_turn` limits to the current turn only. Only supported by OpenAI GPT-5.6 and newer.<br/>
        /// Example: all_turns
        /// </summary>
        /// <example>all_turns</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ReasoningContextJsonConverter))]
        public global::OpenRouter.ReasoningContext? Context { get; set; }

        /// <summary>
        /// Example: medium
        /// </summary>
        /// <example>medium</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ReasoningEffortJsonConverter))]
        public global::OpenRouter.ReasoningEffort? Effort { get; set; }

        /// <summary>
        /// Selects the reasoning mode. `standard` is the default; `pro` engages deeper reasoning on models that support it, billed at standard token rates. Only supported by OpenAI GPT-5.6 and newer.<br/>
        /// Example: standard
        /// </summary>
        /// <example>standard</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ReasoningModeJsonConverter))]
        public global::OpenRouter.ReasoningMode? Mode { get; set; }

        /// <summary>
        /// Example: auto
        /// </summary>
        /// <example>auto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ReasoningSummaryVerbosityJsonConverter))]
        public global::OpenRouter.ReasoningSummaryVerbosity? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseReasoningConfig" /> class.
        /// </summary>
        /// <param name="context">
        /// Controls which reasoning is available to the model. `auto` uses the model default (same as omitting); `all_turns` includes reasoning from earlier turns passed in input; `current_turn` limits to the current turn only. Only supported by OpenAI GPT-5.6 and newer.<br/>
        /// Example: all_turns
        /// </param>
        /// <param name="effort">
        /// Example: medium
        /// </param>
        /// <param name="mode">
        /// Selects the reasoning mode. `standard` is the default; `pro` engages deeper reasoning on models that support it, billed at standard token rates. Only supported by OpenAI GPT-5.6 and newer.<br/>
        /// Example: standard
        /// </param>
        /// <param name="summary">
        /// Example: auto
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseReasoningConfig(
            global::OpenRouter.ReasoningContext? context,
            global::OpenRouter.ReasoningEffort? effort,
            global::OpenRouter.ReasoningMode? mode,
            global::OpenRouter.ReasoningSummaryVerbosity? summary)
        {
            this.Context = context;
            this.Effort = effort;
            this.Mode = mode;
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseReasoningConfig" /> class.
        /// </summary>
        public BaseReasoningConfig()
        {
        }

    }
}