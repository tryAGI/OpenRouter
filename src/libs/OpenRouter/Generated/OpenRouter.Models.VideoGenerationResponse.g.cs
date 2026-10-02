
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"generation_id":"gen-vid-1789480874-Ab3dEf9hIjKlMnOpQrSt","id":"gen-vid-1789480874-Ab3dEf9hIjKlMnOpQrSt","polling_url":"/api/v1/videos/gen-vid-1789480874-Ab3dEf9hIjKlMnOpQrSt","status":"pending"}
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
        /// The video job ID, in the `gen-vid-&lt;timestamp&gt;-&lt;20 alphanumerics&gt;` generation ID format. Pass it as `previous_job_id` to continue the generation.
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
        /// Usage and cost information for the video generation. Available once the job has completed.<br/>
        /// Example: {"cost":0.5,"is_byok":false}
        /// </summary>
        /// <example>{"cost":0.5,"is_byok":false}</example>
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
        /// <param name="id">
        /// The video job ID, in the `gen-vid-&lt;timestamp&gt;-&lt;20 alphanumerics&gt;` generation ID format. Pass it as `previous_job_id` to continue the generation.
        /// </param>
        /// <param name="pollingUrl"></param>
        /// <param name="status"></param>
        /// <param name="error"></param>
        /// <param name="generationId">
        /// The generation ID associated with this video generation job. Available once the job has been processed.
        /// </param>
        /// <param name="unsignedUrls"></param>
        /// <param name="usage">
        /// Usage and cost information for the video generation. Available once the job has completed.<br/>
        /// Example: {"cost":0.5,"is_byok":false}
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