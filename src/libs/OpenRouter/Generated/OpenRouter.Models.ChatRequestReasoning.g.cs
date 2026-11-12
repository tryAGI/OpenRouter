
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Configuration options for reasoning models<br/>
    /// Example: {"effort":"medium","summary":"concise"}
    /// </summary>
    public sealed partial class ChatRequestReasoning
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
        /// Constrains effort on reasoning for reasoning models<br/>
        /// Example: medium
        /// </summary>
        /// <example>medium</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatRequestReasoningEffortJsonConverter))]
        public global::OpenRouter.ChatRequestReasoningEffort? Effort { get; set; }

        /// <summary>
        /// Enables reasoning with default settings. Defaults to being inferred from `effort` or `max_tokens`.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// When true, the model still reasons but the reasoning is omitted from the response. Defaults to false.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public bool? Exclude { get; set; }

        /// <summary>
        /// Maximum number of tokens the model may spend on reasoning, for models that take a reasoning token budget instead of an effort level. Cannot be combined with `reasoning.effort` or the top-level `reasoning_effort`: a request that sets both is rejected with "Only one of "reasoning.effort" and "reasoning.max_tokens" can be specified".<br/>
        /// Example: 2000
        /// </summary>
        /// <example>2000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Selects the reasoning mode. `standard` is the default; `pro` engages deeper reasoning on models that support it, billed at standard token rates. Only supported by OpenAI GPT-5.6 and newer.<br/>
        /// Example: standard
        /// </summary>
        /// <example>standard</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ReasoningModeJsonConverter))]
        public global::OpenRouter.ReasoningMode? Mode { get; set; }

        /// <summary>
        /// Example: concise
        /// </summary>
        /// <example>concise</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatReasoningSummaryVerbosityEnumJsonConverter))]
        public global::OpenRouter.ChatReasoningSummaryVerbosityEnum? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestReasoning" /> class.
        /// </summary>
        /// <param name="context">
        /// Controls which reasoning is available to the model. `auto` uses the model default (same as omitting); `all_turns` includes reasoning from earlier turns passed in input; `current_turn` limits to the current turn only. Only supported by OpenAI GPT-5.6 and newer.<br/>
        /// Example: all_turns
        /// </param>
        /// <param name="effort">
        /// Constrains effort on reasoning for reasoning models<br/>
        /// Example: medium
        /// </param>
        /// <param name="enabled">
        /// Enables reasoning with default settings. Defaults to being inferred from `effort` or `max_tokens`.<br/>
        /// Example: true
        /// </param>
        /// <param name="exclude">
        /// When true, the model still reasons but the reasoning is omitted from the response. Defaults to false.<br/>
        /// Example: false
        /// </param>
        /// <param name="maxTokens">
        /// Maximum number of tokens the model may spend on reasoning, for models that take a reasoning token budget instead of an effort level. Cannot be combined with `reasoning.effort` or the top-level `reasoning_effort`: a request that sets both is rejected with "Only one of "reasoning.effort" and "reasoning.max_tokens" can be specified".<br/>
        /// Example: 2000
        /// </param>
        /// <param name="mode">
        /// Selects the reasoning mode. `standard` is the default; `pro` engages deeper reasoning on models that support it, billed at standard token rates. Only supported by OpenAI GPT-5.6 and newer.<br/>
        /// Example: standard
        /// </param>
        /// <param name="summary">
        /// Example: concise
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatRequestReasoning(
            global::OpenRouter.ReasoningContext? context,
            global::OpenRouter.ChatRequestReasoningEffort? effort,
            bool? enabled,
            bool? exclude,
            int? maxTokens,
            global::OpenRouter.ReasoningMode? mode,
            global::OpenRouter.ChatReasoningSummaryVerbosityEnum? summary)
        {
            this.Context = context;
            this.Effort = effort;
            this.Enabled = enabled;
            this.Exclude = exclude;
            this.MaxTokens = maxTokens;
            this.Mode = mode;
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestReasoning" /> class.
        /// </summary>
        public ChatRequestReasoning()
        {
        }

    }
}