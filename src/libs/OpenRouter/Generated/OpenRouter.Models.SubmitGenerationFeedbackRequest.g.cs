
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Structured feedback about a specific generation<br/>
    /// Example: {"category":"incorrect_response","comment":"The model repeated the same paragraph three times.","generation_id":"gen-3bhGkxlo4XFrqiabUM7NDtwDzWwG"}
    /// </summary>
    public sealed partial class SubmitGenerationFeedbackRequest
    {
        /// <summary>
        /// The category of feedback being reported<br/>
        /// Example: incorrect_response
        /// </summary>
        /// <example>incorrect_response</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.SubmitGenerationFeedbackRequestCategoryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.SubmitGenerationFeedbackRequestCategory Category { get; set; }

        /// <summary>
        /// An optional free-text comment describing the feedback<br/>
        /// Example: The model repeated the same paragraph three times.
        /// </summary>
        /// <example>The model repeated the same paragraph three times.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// The generation to submit feedback on<br/>
        /// Example: gen-3bhGkxlo4XFrqiabUM7NDtwDzWwG
        /// </summary>
        /// <example>gen-3bhGkxlo4XFrqiabUM7NDtwDzWwG</example>
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
        /// The category of feedback being reported<br/>
        /// Example: incorrect_response
        /// </param>
        /// <param name="generationId">
        /// The generation to submit feedback on<br/>
        /// Example: gen-3bhGkxlo4XFrqiabUM7NDtwDzWwG
        /// </param>
        /// <param name="comment">
        /// An optional free-text comment describing the feedback<br/>
        /// Example: The model repeated the same paragraph three times.
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