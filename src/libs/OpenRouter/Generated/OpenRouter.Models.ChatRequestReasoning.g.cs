
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Configuration options for reasoning models
    /// </summary>
    public sealed partial class ChatRequestReasoning
    {
        /// <summary>
        /// Constrains effort on reasoning for reasoning models
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OneOfJsonConverter<global::OpenRouter.ChatRequestReasoningEffort?, object>))]
        public global::OpenRouter.OneOf<global::OpenRouter.ChatRequestReasoningEffort?, object>? Effort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ChatRequestReasoningSummaryJsonConverter))]
        public global::OpenRouter.ChatRequestReasoningSummary? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestReasoning" /> class.
        /// </summary>
        /// <param name="effort">
        /// Constrains effort on reasoning for reasoning models
        /// </param>
        /// <param name="summary"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatRequestReasoning(
            global::OpenRouter.OneOf<global::OpenRouter.ChatRequestReasoningEffort?, object>? effort,
            global::OpenRouter.ChatRequestReasoningSummary? summary)
        {
            this.Effort = effort;
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