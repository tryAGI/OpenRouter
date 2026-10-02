#nullable enable

namespace OpenRouter
{
    public partial interface IVideoGenerationClient
    {
        /// <summary>
        /// Submit a video generation request<br/>
        /// Submits a video generation request and returns a polling URL to check status
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.VideoGenerationResponse> GenerateAsync(

            global::OpenRouter.VideoGenerationRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit a video generation request<br/>
        /// Submits a video generation request and returns a polling URL to check status
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.VideoGenerationResponse>> GenerateAsResponseAsync(

            global::OpenRouter.VideoGenerationRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit a video generation request<br/>
        /// Submits a video generation request and returns a polling URL to check status
        /// </summary>
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
        /// <param name="model"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.VideoGenerationResponse> GenerateAsync(
            string model,
            global::OpenRouter.VideoGenerationRequestAspectRatio? aspectRatio = default,
            string? callbackUrl = default,
            int? creativity = default,
            int? duration = default,
            global::System.Collections.Generic.IList<global::OpenRouter.FrameImage>? frameImages = default,
            bool? generateAudio = default,
            global::System.Collections.Generic.IList<global::OpenRouter.InputReference>? inputReferences = default,
            string? previousJobId = default,
            string? prompt = default,
            global::OpenRouter.VideoGenerationRequestProvider? provider = default,
            global::OpenRouter.VideoGenerationRequestResolution? resolution = default,
            int? seed = default,
            string? sessionId = default,
            string? size = default,
            global::OpenRouter.TraceConfig? trace = default,
            double? upscaleFactor = default,
            string? user = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}