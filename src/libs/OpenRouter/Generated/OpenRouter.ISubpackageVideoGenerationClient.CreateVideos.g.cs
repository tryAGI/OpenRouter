#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageVideoGenerationClient
    {
        /// <summary>
        /// Submit a video generation request<br/>
        /// Submits a video generation request and returns a polling URL to check status
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.VideoGenerationResponse> CreateVideosAsync(

            global::OpenRouter.VideoGenerationRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit a video generation request<br/>
        /// Submits a video generation request and returns a polling URL to check status
        /// </summary>
        /// <param name="aspectRatio">
        /// Aspect ratio of the generated video
        /// </param>
        /// <param name="callbackUrl">
        /// URL to receive a webhook notification when the video generation job completes. Overrides the workspace-level default callback URL if set. Must be HTTPS.
        /// </param>
        /// <param name="duration">
        /// Duration of the generated video in seconds
        /// </param>
        /// <param name="frameImages">
        /// Images to use as the first and/or last frame of the generated video. Each image must specify a frame_type of first_frame or last_frame.
        /// </param>
        /// <param name="generateAudio">
        /// Whether to generate audio alongside the video. Defaults to the endpoint's generate_audio capability flag, false if not set.
        /// </param>
        /// <param name="inputReferences">
        /// Reference images to guide video generation
        /// </param>
        /// <param name="model"></param>
        /// <param name="prompt"></param>
        /// <param name="provider">
        /// Provider-specific passthrough configuration
        /// </param>
        /// <param name="resolution">
        /// Resolution of the generated video
        /// </param>
        /// <param name="seed">
        /// If specified, the generation will sample deterministically, such that repeated requests with the same seed and parameters should return the same result. Determinism is not guaranteed for all providers.
        /// </param>
        /// <param name="size">
        /// Exact pixel dimensions of the generated video in "WIDTHxHEIGHT" format (e.g. "1280x720"). Interchangeable with resolution + aspect_ratio.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.VideoGenerationResponse> CreateVideosAsync(
            string model,
            string prompt,
            global::OpenRouter.VideoGenerationRequestAspectRatio? aspectRatio = default,
            string? callbackUrl = default,
            int? duration = default,
            global::System.Collections.Generic.IList<global::OpenRouter.FrameImage>? frameImages = default,
            bool? generateAudio = default,
            global::System.Collections.Generic.IList<global::OpenRouter.ContentPartImage>? inputReferences = default,
            global::OpenRouter.VideoGenerationRequestProvider? provider = default,
            global::OpenRouter.VideoGenerationRequestResolution? resolution = default,
            int? seed = default,
            string? size = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}