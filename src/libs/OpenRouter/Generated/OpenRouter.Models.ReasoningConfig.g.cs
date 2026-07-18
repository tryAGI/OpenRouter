
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Configuration for reasoning mode in the response
    /// </summary>
    public sealed partial class ReasoningConfig
    {
        /// <summary>
        /// Controls which reasoning is available to the model. `auto` uses the model default (same as omitting); `all_turns` includes reasoning from earlier turns passed in input; `current_turn` limits to the current turn only. Only supported by OpenAI GPT-5.6 and newer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ReasoningContextJsonConverter))]
        public global::OpenRouter.ReasoningContext? Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ReasoningEffortJsonConverter))]
        public global::OpenRouter.ReasoningEffort? Effort { get; set; }

        /// <summary>
        /// Selects the reasoning mode. `standard` is the default; `pro` engages deeper reasoning on models that support it, billed at standard token rates. Only supported by OpenAI GPT-5.6 and newer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ReasoningModeJsonConverter))]
        public global::OpenRouter.ReasoningMode? Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ReasoningSummaryVerbosityJsonConverter))]
        public global::OpenRouter.ReasoningSummaryVerbosity? Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningConfig" /> class.
        /// </summary>
        /// <param name="context">
        /// Controls which reasoning is available to the model. `auto` uses the model default (same as omitting); `all_turns` includes reasoning from earlier turns passed in input; `current_turn` limits to the current turn only. Only supported by OpenAI GPT-5.6 and newer.
        /// </param>
        /// <param name="effort"></param>
        /// <param name="mode">
        /// Selects the reasoning mode. `standard` is the default; `pro` engages deeper reasoning on models that support it, billed at standard token rates. Only supported by OpenAI GPT-5.6 and newer.
        /// </param>
        /// <param name="summary"></param>
        /// <param name="enabled"></param>
        /// <param name="maxTokens"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReasoningConfig(
            global::OpenRouter.ReasoningContext? context,
            global::OpenRouter.ReasoningEffort? effort,
            global::OpenRouter.ReasoningMode? mode,
            global::OpenRouter.ReasoningSummaryVerbosity? summary,
            bool? enabled,
            int? maxTokens)
        {
            this.Context = context;
            this.Effort = effort;
            this.Mode = mode;
            this.Summary = summary;
            this.Enabled = enabled;
            this.MaxTokens = maxTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningConfig" /> class.
        /// </summary>
        public ReasoningConfig()
        {
        }

    }
}