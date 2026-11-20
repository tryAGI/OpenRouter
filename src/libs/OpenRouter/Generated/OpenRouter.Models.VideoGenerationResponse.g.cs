
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"generation_id":"gen-vid-1789480874-Ab3dEf9hIjKlMnOpQrSt","id":"gen-vid-1789480874-Ab3dEf9hIjKlMnOpQrSt","polling_url":"/api/v1/videos/gen-vid-1789480874-Ab3dEf9hIjKlMnOpQrSt","status":"pending","status_detail":"queued_at_provider"}
    /// </summary>
    public sealed partial class VideoGenerationResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Unix timestamp in seconds when OpenRouter's stored copy of the outputs stops being available. Present only when that copy exists.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? ExpiresAt { get; set; }

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
        /// Percent complete, from 0 to 100 and possibly fractional, reported by the provider while `status_detail` is `generating`. Present only for providers that report it, and absent once the job moves to `finalizing`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public double? Progress { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.VideoGenerationResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.VideoGenerationResponseStatus Status { get; set; }

        /// <summary>
        /// The step within `status` for a job that is not finished: `submitting` and `queued_at_provider` under `pending`, `generating` and `finalizing` under `in_progress`. When present, it only moves forward, and steps may be skipped between polls. It is absent once the job is finished and can also be absent mid-job when the step is unknown, so use `status` to tell whether the job is finished.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.VideoGenerationResponseStatusDetailJsonConverter))]
        public global::OpenRouter.VideoGenerationResponseStatusDetail? StatusDetail { get; set; }

        /// <summary>
        /// OpenRouter content URLs for each output. They need your API key in the `Authorization` header and keep working for as long as the output is available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unsigned_urls")]
        public global::System.Collections.Generic.IList<string>? UnsignedUrls { get; set; }

        /// <summary>
        /// Signed download URLs for OpenRouter's stored copy of each output, usable without an API key until `expires_at`. Anyone holding a URL can download that output until it expires, so treat it like a secret. Present only when the stored copy exists.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        public global::System.Collections.Generic.IList<string>? Urls { get; set; }

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
        /// <param name="expiresAt">
        /// Unix timestamp in seconds when OpenRouter's stored copy of the outputs stops being available. Present only when that copy exists.
        /// </param>
        /// <param name="generationId">
        /// The generation ID associated with this video generation job. Available once the job has been processed.
        /// </param>
        /// <param name="progress">
        /// Percent complete, from 0 to 100 and possibly fractional, reported by the provider while `status_detail` is `generating`. Present only for providers that report it, and absent once the job moves to `finalizing`.
        /// </param>
        /// <param name="statusDetail">
        /// The step within `status` for a job that is not finished: `submitting` and `queued_at_provider` under `pending`, `generating` and `finalizing` under `in_progress`. When present, it only moves forward, and steps may be skipped between polls. It is absent once the job is finished and can also be absent mid-job when the step is unknown, so use `status` to tell whether the job is finished.
        /// </param>
        /// <param name="unsignedUrls">
        /// OpenRouter content URLs for each output. They need your API key in the `Authorization` header and keep working for as long as the output is available.
        /// </param>
        /// <param name="urls">
        /// Signed download URLs for OpenRouter's stored copy of each output, usable without an API key until `expires_at`. Anyone holding a URL can download that output until it expires, so treat it like a secret. Present only when the stored copy exists.
        /// </param>
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
            global::System.DateTimeOffset? expiresAt,
            string? generationId,
            double? progress,
            global::OpenRouter.VideoGenerationResponseStatusDetail? statusDetail,
            global::System.Collections.Generic.IList<string>? unsignedUrls,
            global::System.Collections.Generic.IList<string>? urls,
            global::OpenRouter.VideoGenerationUsage? usage)
        {
            this.Error = error;
            this.ExpiresAt = expiresAt;
            this.GenerationId = generationId;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.PollingUrl = pollingUrl ?? throw new global::System.ArgumentNullException(nameof(pollingUrl));
            this.Progress = progress;
            this.Status = status;
            this.StatusDetail = statusDetail;
            this.UnsignedUrls = unsignedUrls;
            this.Urls = urls;
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