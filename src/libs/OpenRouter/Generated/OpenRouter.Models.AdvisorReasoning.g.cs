
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Reasoning configuration forwarded to the advisor call. Use this to control reasoning effort and token budget for models that support extended thinking.
    /// </summary>
    public sealed partial class AdvisorReasoning
    {
        /// <summary>
        /// Reasoning effort level for the advisor call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AdvisorReasoningEffortJsonConverter))]
        public global::OpenRouter.AdvisorReasoningEffort? Effort { get; set; }

        /// <summary>
        /// Maximum number of reasoning tokens the advisor may use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvisorReasoning" /> class.
        /// </summary>
        /// <param name="effort">
        /// Reasoning effort level for the advisor call.
        /// </param>
        /// <param name="maxTokens">
        /// Maximum number of reasoning tokens the advisor may use.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdvisorReasoning(
            global::OpenRouter.AdvisorReasoningEffort? effort,
            int? maxTokens)
        {
            this.Effort = effort;
            this.MaxTokens = maxTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvisorReasoning" /> class.
        /// </summary>
        public AdvisorReasoning()
        {
        }

    }
}