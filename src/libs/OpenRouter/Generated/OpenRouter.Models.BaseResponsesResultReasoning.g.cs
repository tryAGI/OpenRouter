
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseResponsesResultReasoning
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        public global::OpenRouter.BaseResponsesResultReasoningEffort? Effort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public global::OpenRouter.BaseResponsesResultReasoningSummary? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseResponsesResultReasoning" /> class.
        /// </summary>
        /// <param name="effort"></param>
        /// <param name="summary"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseResponsesResultReasoning(
            global::OpenRouter.BaseResponsesResultReasoningEffort? effort,
            global::OpenRouter.BaseResponsesResultReasoningSummary? summary)
        {
            this.Effort = effort;
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseResponsesResultReasoning" /> class.
        /// </summary>
        public BaseResponsesResultReasoning()
        {
        }
    }
}