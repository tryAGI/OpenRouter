
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Per-modality token breakdown. Only present when the input contains 2+ modalities (e.g. text + image) and the upstream provider returns modality-level usage data. Only non-zero modality counts are included.
    /// </summary>
    public sealed partial class EmbeddingsPostResponsesContentApplicationJsonSchemaUsagePromptTokensDetails
    {
        /// <summary>
        /// Number of audio tokens in the input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_tokens")]
        public int? AudioTokens { get; set; }

        /// <summary>
        /// Number of image tokens in the input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_tokens")]
        public int? ImageTokens { get; set; }

        /// <summary>
        /// Number of text tokens in the input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_tokens")]
        public int? TextTokens { get; set; }

        /// <summary>
        /// Number of video tokens in the input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_tokens")]
        public int? VideoTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsPostResponsesContentApplicationJsonSchemaUsagePromptTokensDetails" /> class.
        /// </summary>
        /// <param name="audioTokens">
        /// Number of audio tokens in the input
        /// </param>
        /// <param name="imageTokens">
        /// Number of image tokens in the input
        /// </param>
        /// <param name="textTokens">
        /// Number of text tokens in the input
        /// </param>
        /// <param name="videoTokens">
        /// Number of video tokens in the input
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingsPostResponsesContentApplicationJsonSchemaUsagePromptTokensDetails(
            int? audioTokens,
            int? imageTokens,
            int? textTokens,
            int? videoTokens)
        {
            this.AudioTokens = audioTokens;
            this.ImageTokens = imageTokens;
            this.TextTokens = textTokens;
            this.VideoTokens = videoTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsPostResponsesContentApplicationJsonSchemaUsagePromptTokensDetails" /> class.
        /// </summary>
        public EmbeddingsPostResponsesContentApplicationJsonSchemaUsagePromptTokensDetails()
        {
        }
    }
}