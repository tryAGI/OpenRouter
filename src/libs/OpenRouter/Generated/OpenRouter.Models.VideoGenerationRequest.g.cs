
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"aspect_ratio":"16:9","duration":8,"model":"google/veo-3.1","prompt":"A serene mountain landscape at sunset","resolution":"720p"}
    /// </summary>
    public sealed partial class VideoGenerationRequest
    {
        /// <summary>
        /// Aspect ratio of the generated video<br/>
        /// Example: 16:9
        /// </summary>
        /// <example>16:9</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.VideoGenerationRequestAspectRatioJsonConverter))]
        public global::OpenRouter.VideoGenerationRequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// URL to receive a webhook notification when the video generation job completes. Overrides the workspace-level default callback URL if set. Must be HTTPS.<br/>
        /// Example: https://example.com/webhook
        /// </summary>
        /// <example>https://example.com/webhook</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Creativity level for video upscaling models only. This parameter is not supported by video generation models.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("creativity")]
        public int? Creativity { get; set; }

        /// <summary>
        /// Duration of the generated video in seconds<br/>
        /// Example: 8
        /// </summary>
        /// <example>8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Images to use as the first and/or last frame of the generated video. Each image must specify a frame_type of first_frame or last_frame.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_images")]
        public global::System.Collections.Generic.IList<global::OpenRouter.FrameImage>? FrameImages { get; set; }

        /// <summary>
        /// Whether to generate audio alongside the video. Defaults to the endpoint's generate_audio capability flag, false if not set.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("generate_audio")]
        public bool? GenerateAudio { get; set; }

        /// <summary>
        /// Reference assets to guide video generation. Accepts image, audio, and video references. Audio and video references are only honored by providers that support them (including BytePlus Seedance generation 2 and newer); other providers use image references and ignore the rest.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_references")]
        public global::System.Collections.Generic.IList<global::OpenRouter.InputReference>? InputReferences { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// ID of a completed video job to edit or extend, as returned by the submit response. The new job runs on the same model and endpoint that produced the previous one. Only models that support continuation accept this field.<br/>
        /// Example: gen-vid-1789493115-a1B2c3D4e5F6g7H8i9J0
        /// </summary>
        /// <example>gen-vid-1789493115-a1B2c3D4e5F6g7H8i9J0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_job_id")]
        public string? PreviousJobId { get; set; }

        /// <summary>
        /// Text prompt describing the video to generate. Optional for models that support generating a video from image input alone; required by all other models.<br/>
        /// Example: A serene mountain landscape at sunset
        /// </summary>
        /// <example>A serene mountain landscape at sunset</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Provider-specific passthrough configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public global::OpenRouter.VideoGenerationRequestProvider? Provider { get; set; }

        /// <summary>
        /// Resolution of the generated video<br/>
        /// Example: 720p
        /// </summary>
        /// <example>720p</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.VideoGenerationRequestResolutionJsonConverter))]
        public global::OpenRouter.VideoGenerationRequestResolution? Resolution { get; set; }

        /// <summary>
        /// If specified, the generation will sample deterministically, such that repeated requests with the same seed and parameters should return the same result. Determinism is not guaranteed for all providers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow). Used for observability grouping in Broadcast and private logging; never sent to the provider. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.<br/>
        /// Example: session-1234
        /// </summary>
        /// <example>session-1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Exact pixel dimensions of the generated video in "WIDTHxHEIGHT" format (e.g. "1280x720"). Interchangeable with resolution + aspect_ratio.<br/>
        /// Example: 1280x720
        /// </summary>
        /// <example>1280x720</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }

        /// <summary>
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.<br/>
        /// Example: {"trace_id":"trace-abc123","trace_name":"my-app-trace"}
        /// </summary>
        /// <example>{"trace_id":"trace-abc123","trace_name":"my-app-trace"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace")]
        public global::OpenRouter.TraceConfig? Trace { get; set; }

        /// <summary>
        /// Upscale factor for video upscaling models only. This parameter is not supported by video generation models.<br/>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("upscale_factor")]
        public double? UpscaleFactor { get; set; }

        /// <summary>
        /// A unique identifier representing your end-user. Forwarded to Broadcast and private logging as the end-user id; never sent to the provider.<br/>
        /// Example: user-1234
        /// </summary>
        /// <example>user-1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoGenerationRequest" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="aspectRatio">
        /// Aspect ratio of the generated video<br/>
        /// Example: 16:9
        /// </param>
        /// <param name="callbackUrl">
        /// URL to receive a webhook notification when the video generation job completes. Overrides the workspace-level default callback URL if set. Must be HTTPS.<br/>
        /// Example: https://example.com/webhook
        /// </param>
        /// <param name="creativity">
        /// Creativity level for video upscaling models only. This parameter is not supported by video generation models.<br/>
        /// Example: 1
        /// </param>
        /// <param name="duration">
        /// Duration of the generated video in seconds<br/>
        /// Example: 8
        /// </param>
        /// <param name="frameImages">
        /// Images to use as the first and/or last frame of the generated video. Each image must specify a frame_type of first_frame or last_frame.
        /// </param>
        /// <param name="generateAudio">
        /// Whether to generate audio alongside the video. Defaults to the endpoint's generate_audio capability flag, false if not set.<br/>
        /// Example: true
        /// </param>
        /// <param name="inputReferences">
        /// Reference assets to guide video generation. Accepts image, audio, and video references. Audio and video references are only honored by providers that support them (including BytePlus Seedance generation 2 and newer); other providers use image references and ignore the rest.
        /// </param>
        /// <param name="previousJobId">
        /// ID of a completed video job to edit or extend, as returned by the submit response. The new job runs on the same model and endpoint that produced the previous one. Only models that support continuation accept this field.<br/>
        /// Example: gen-vid-1789493115-a1B2c3D4e5F6g7H8i9J0
        /// </param>
        /// <param name="prompt">
        /// Text prompt describing the video to generate. Optional for models that support generating a video from image input alone; required by all other models.<br/>
        /// Example: A serene mountain landscape at sunset
        /// </param>
        /// <param name="provider">
        /// Provider-specific passthrough configuration
        /// </param>
        /// <param name="resolution">
        /// Resolution of the generated video<br/>
        /// Example: 720p
        /// </param>
        /// <param name="seed">
        /// If specified, the generation will sample deterministically, such that repeated requests with the same seed and parameters should return the same result. Determinism is not guaranteed for all providers.
        /// </param>
        /// <param name="sessionId">
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow). Used for observability grouping in Broadcast and private logging; never sent to the provider. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.<br/>
        /// Example: session-1234
        /// </param>
        /// <param name="size">
        /// Exact pixel dimensions of the generated video in "WIDTHxHEIGHT" format (e.g. "1280x720"). Interchangeable with resolution + aspect_ratio.<br/>
        /// Example: 1280x720
        /// </param>
        /// <param name="trace">
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.<br/>
        /// Example: {"trace_id":"trace-abc123","trace_name":"my-app-trace"}
        /// </param>
        /// <param name="upscaleFactor">
        /// Upscale factor for video upscaling models only. This parameter is not supported by video generation models.<br/>
        /// Example: 2
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user. Forwarded to Broadcast and private logging as the end-user id; never sent to the provider.<br/>
        /// Example: user-1234
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoGenerationRequest(
            string model,
            global::OpenRouter.VideoGenerationRequestAspectRatio? aspectRatio,
            string? callbackUrl,
            int? creativity,
            int? duration,
            global::System.Collections.Generic.IList<global::OpenRouter.FrameImage>? frameImages,
            bool? generateAudio,
            global::System.Collections.Generic.IList<global::OpenRouter.InputReference>? inputReferences,
            string? previousJobId,
            string? prompt,
            global::OpenRouter.VideoGenerationRequestProvider? provider,
            global::OpenRouter.VideoGenerationRequestResolution? resolution,
            int? seed,
            string? sessionId,
            string? size,
            global::OpenRouter.TraceConfig? trace,
            double? upscaleFactor,
            string? user)
        {
            this.AspectRatio = aspectRatio;
            this.CallbackUrl = callbackUrl;
            this.Creativity = creativity;
            this.Duration = duration;
            this.FrameImages = frameImages;
            this.GenerateAudio = generateAudio;
            this.InputReferences = inputReferences;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.PreviousJobId = previousJobId;
            this.Prompt = prompt;
            this.Provider = provider;
            this.Resolution = resolution;
            this.Seed = seed;
            this.SessionId = sessionId;
            this.Size = size;
            this.Trace = trace;
            this.UpscaleFactor = upscaleFactor;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoGenerationRequest" /> class.
        /// </summary>
        public VideoGenerationRequest()
        {
        }

    }
}