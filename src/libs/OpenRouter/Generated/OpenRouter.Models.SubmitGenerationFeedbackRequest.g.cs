
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Structured feedback about a specific generation
    /// </summary>
    public sealed partial class SubmitGenerationFeedbackRequest
    {
        /// <summary>
        /// The category of feedback being reported
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.SubmitGenerationFeedbackRequestCategoryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.SubmitGenerationFeedbackRequestCategory Category { get; set; }

        /// <summary>
        /// An optional free-text comment describing the feedback
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// The generation to submit feedback on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GenerationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitGenerationFeedbackRequest" /> class.
        /// </summary>
        /// <param name="category">
        /// The category of feedback being reported
        /// </param>
        /// <param name="generationId">
        /// The generation to submit feedback on
        /// </param>
        /// <param name="comment">
        /// An optional free-text comment describing the feedback
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitGenerationFeedbackRequest(
            global::OpenRouter.SubmitGenerationFeedbackRequestCategory category,
            string generationId,
            string? comment)
        {
            this.Category = category;
            this.Comment = comment;
            this.GenerationId = generationId ?? throw new global::System.ArgumentNullException(nameof(generationId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitGenerationFeedbackRequest" /> class.
        /// </summary>
        public SubmitGenerationFeedbackRequest()
        {
        }

    }
}