#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageImagesClient
    {
        /// <summary>
        /// Generate an image<br/>
        /// Generates an image from a text prompt via the image generation router
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ImageGenerationResponse> CreateImagesAsync(

            global::OpenRouter.ImageGenerationRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate an image<br/>
        /// Generates an image from a text prompt via the image generation router
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ImageGenerationResponse>> CreateImagesAsResponseAsync(

            global::OpenRouter.ImageGenerationRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate an image<br/>
        /// Generates an image from a text prompt via the image generation router
        /// </summary>
        /// <param name="aspectRatio">
        /// Normalized aspect ratio of the generated image. Providers clamp to their supported subset.
        /// </param>
        /// <param name="background">
        /// Background treatment. `transparent` requires an output_format that supports alpha (png or webp).
        /// </param>
        /// <param name="inputReferences">
        /// Reference images to guide image-to-image generation, as base64 data URLs or HTTP(S) URLs.
        /// </param>
        /// <param name="model">
        /// The image generation model to use
        /// </param>
        /// <param name="n">
        /// Number of images to generate (1-10). Providers that only support single-image generation reject n &gt; 1.
        /// </param>
        /// <param name="outputCompression">
        /// Compression level (0-100) for webp/jpeg output. Ignored for png and by providers without a compression knob.
        /// </param>
        /// <param name="outputFormat">
        /// Encoding of the returned image bytes.
        /// </param>
        /// <param name="prompt">
        /// Text description of the desired image
        /// </param>
        /// <param name="provider">
        /// Provider-specific passthrough configuration
        /// </param>
        /// <param name="quality">
        /// Rendering quality. Providers without a quality knob ignore this.
        /// </param>
        /// <param name="resolution">
        /// Normalized resolution tier of the generated image. Concrete pixel dimensions are derived per-provider.
        /// </param>
        /// <param name="seed">
        /// If specified, the generation will sample deterministically, such that repeated requests with the same seed and parameters should return the same result. Determinism is not guaranteed for all providers.
        /// </param>
        /// <param name="size">
        /// Optional. A convenience shorthand for output dimensions — pass a tier ("2K", "4K") or explicit pixels ("2048x2048") and we normalize it to the right dimensions for the chosen provider. Interchangeable with resolution + aspect_ratio; use those directly for enumerated, per-model discoverable values. Conflicting size + resolution/aspect_ratio is rejected.
        /// </param>
        /// <param name="stream">
        /// If true, partial images are streamed as SSE events as they become available. Only supported by providers with native streaming (currently OpenAI). Non-streaming providers ignore this flag and return a buffered response.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ImageGenerationResponse> CreateImagesAsync(
            string model,
            string prompt,
            global::OpenRouter.ImageGenerationRequestAspectRatio? aspectRatio = default,
            global::OpenRouter.ImageGenerationRequestBackground? background = default,
            global::System.Collections.Generic.IList<global::OpenRouter.ContentPartImage>? inputReferences = default,
            int? n = default,
            int? outputCompression = default,
            global::OpenRouter.ImageGenerationRequestOutputFormat? outputFormat = default,
            global::OpenRouter.ImageGenerationRequestProvider? provider = default,
            global::OpenRouter.ImageGenerationRequestQuality? quality = default,
            global::OpenRouter.ImageGenerationRequestResolution? resolution = default,
            int? seed = default,
            string? size = default,
            bool? stream = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}