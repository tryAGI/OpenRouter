
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoGenerationResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// The generation ID associated with this video generation job. Available once the job has been processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        public string? GenerationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("polling_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PollingUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.VideoGenerationResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.VideoGenerationResponseStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unsigned_urls")]
        public global::System.Collections.Generic.IList<string>? UnsignedUrls { get; set; }

        /// <summary>
        /// Usage and cost information for the video generation. Available once the job has completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::OpenRouter.VideoGenerationUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoGenerationResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pollingUrl"></param>
        /// <param name="status"></param>
        /// <param name="error"></param>
        /// <param name="generationId">
        /// The generation ID associated with this video generation job. Available once the job has been processed.
        /// </param>
        /// <param name="unsignedUrls"></param>
        /// <param name="usage">
        /// Usage and cost information for the video generation. Available once the job has completed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoGenerationResponse(
            string id,
            string pollingUrl,
            global::OpenRouter.VideoGenerationResponseStatus status,
            string? error,
            string? generationId,
            global::System.Collections.Generic.IList<string>? unsignedUrls,
            global::OpenRouter.VideoGenerationUsage? usage)
        {
            this.Error = error;
            this.GenerationId = generationId;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.PollingUrl = pollingUrl ?? throw new global::System.ArgumentNullException(nameof(pollingUrl));
            this.Status = status;
            this.UnsignedUrls = unsignedUrls;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoGenerationResponse" /> class.
        /// </summary>
        public VideoGenerationResponse()
        {
        }
    }
}