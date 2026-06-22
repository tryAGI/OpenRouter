
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Breakdown of tokens used in the prompt.
    /// </summary>
    public sealed partial class ImageGenerationUsagePromptTokensDetails
    {
        /// <summary>
        /// Tokens used for input audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_tokens")]
        public int? AudioTokens { get; set; }

        /// <summary>
        /// Tokens written to cache. Only returned for models with explicit caching and cache write pricing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_write_tokens")]
        public int? CacheWriteTokens { get; set; }

        /// <summary>
        /// Tokens cached by the endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_tokens")]
        public int? CachedTokens { get; set; }

        /// <summary>
        /// Tokens used for input files/documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_tokens")]
        public int? FileTokens { get; set; }

        /// <summary>
        /// Tokens used for input video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_tokens")]
        public int? VideoTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationUsagePromptTokensDetails" /> class.
        /// </summary>
        /// <param name="audioTokens">
        /// Tokens used for input audio.
        /// </param>
        /// <param name="cacheWriteTokens">
        /// Tokens written to cache. Only returned for models with explicit caching and cache write pricing.
        /// </param>
        /// <param name="cachedTokens">
        /// Tokens cached by the endpoint.
        /// </param>
        /// <param name="fileTokens">
        /// Tokens used for input files/documents.
        /// </param>
        /// <param name="videoTokens">
        /// Tokens used for input video.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationUsagePromptTokensDetails(
            int? audioTokens,
            int? cacheWriteTokens,
            int? cachedTokens,
            int? fileTokens,
            int? videoTokens)
        {
            this.AudioTokens = audioTokens;
            this.CacheWriteTokens = cacheWriteTokens;
            this.CachedTokens = cachedTokens;
            this.FileTokens = fileTokens;
            this.VideoTokens = videoTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationUsagePromptTokensDetails" /> class.
        /// </summary>
        public ImageGenerationUsagePromptTokensDetails()
        {
        }

    }
}