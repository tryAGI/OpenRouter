
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Reasoning configuration forwarded to panelist and judge inner calls. Use this to control reasoning effort and token budget for models that support extended thinking.
    /// </summary>
    public sealed partial class FusionServerToolConfigReasoning
    {
        /// <summary>
        /// Reasoning effort level for panelist and judge inner calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.FusionServerToolConfigReasoningEffortJsonConverter))]
        public global::OpenRouter.FusionServerToolConfigReasoningEffort? Effort { get; set; }

        /// <summary>
        /// Maximum number of reasoning tokens each panelist and judge model may use. Helps bound cost when models allocate too much budget to chain-of-thought.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FusionServerToolConfigReasoning" /> class.
        /// </summary>
        /// <param name="effort">
        /// Reasoning effort level for panelist and judge inner calls.
        /// </param>
        /// <param name="maxTokens">
        /// Maximum number of reasoning tokens each panelist and judge model may use. Helps bound cost when models allocate too much budget to chain-of-thought.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FusionServerToolConfigReasoning(
            global::OpenRouter.FusionServerToolConfigReasoningEffort? effort,
            int? maxTokens)
        {
            this.Effort = effort;
            this.MaxTokens = maxTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FusionServerToolConfigReasoning" /> class.
        /// </summary>
        public FusionServerToolConfigReasoning()
        {
        }

    }
}