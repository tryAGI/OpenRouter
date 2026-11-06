
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
        /// Constrains effort on reasoning for reasoning models<br/>
        /// Example: medium
        /// </summary>
        /// <example>medium</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatRequestReasoningEffortJsonConverter))]
        public global::OpenRouter.ChatRequestReasoningEffort? Effort { get; set; }

        /// <summary>
        /// Maximum number of tokens the model may spend on reasoning, for models that take a reasoning token budget instead of an effort level. Cannot be combined with `reasoning.effort` or the top-level `reasoning_effort`: a request that sets both is rejected with "Only one of "reasoning.effort" and "reasoning.max_tokens" can be specified".<br/>
        /// Example: 2000
        /// </summary>
        /// <example>2000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

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
        /// <param name="effort">
        /// Constrains effort on reasoning for reasoning models<br/>
        /// Example: medium
        /// </param>
        /// <param name="maxTokens">
        /// Maximum number of tokens the model may spend on reasoning, for models that take a reasoning token budget instead of an effort level. Cannot be combined with `reasoning.effort` or the top-level `reasoning_effort`: a request that sets both is rejected with "Only one of "reasoning.effort" and "reasoning.max_tokens" can be specified".<br/>
        /// Example: 2000
        /// </param>
        /// <param name="summary">
        /// Example: concise
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatRequestReasoning(
            global::OpenRouter.ChatRequestReasoningEffort? effort,
            int? maxTokens,
            global::OpenRouter.ChatReasoningSummaryVerbosityEnum? summary)
        {
            this.Effort = effort;
            this.MaxTokens = maxTokens;
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