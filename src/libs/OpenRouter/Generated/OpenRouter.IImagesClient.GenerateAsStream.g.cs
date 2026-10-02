#nullable enable

namespace OpenRouter
{
    public partial interface IImagesClient
    {
        /// <summary>
        /// Generate an image<br/>
        /// Generates an image from a text prompt via the image generation router
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::OpenRouter.ImageStreamingResponse> GenerateAsStreamAsync(

            global::OpenRouter.ImageGenerationRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate an image<br/>
        /// Generates an image from a text prompt via the image generation router
        /// </summary>
        /// <param name="aspectRatio">
        /// Normalized aspect ratio of the generated image. Providers clamp to their supported subset.<br/>
        /// Example: 16:9
        /// </param>
        /// <param name="background">
        /// Background treatment. `transparent` requires an output_format that supports alpha (png or webp).<br/>
        /// Example: auto
        /// </param>
        /// <param name="inputReferences">
        /// Reference images to guide image-to-image generation, as base64 data URLs or HTTP(S) URLs.
        /// </param>
        /// <param name="model">
        /// The image generation model to use<br/>
        /// Example: bytedance-seed/seedream-4.5
        /// </param>
        /// <param name="n">
        /// Upper bound on the number of images to generate (1-10). Providers may return fewer images, and providers that only support single-image generation reject n &gt; 1.<br/>
        /// Example: 1
        /// </param>
        /// <param name="outputCompression">
        /// Compression level (0-100) for webp/jpeg output. Ignored for png and by providers without a compression knob.<br/>
        /// Example: 100
        /// </param>
        /// <param name="outputFormat">
        /// Encoding of the returned image bytes. Most models produce raster formats (png, jpeg, webp). SVG is supported by vectorization models (e.g. Quiver) — the SVG markup is UTF-8 base64-encoded in `b64_json`.<br/>
        /// Example: png
        /// </param>
        /// <param name="prompt">
        /// Text description of the desired image<br/>
        /// Example: a red panda astronaut floating in space, studio lighting
        /// </param>
        /// <param name="provider">
        /// Provider routing preferences and provider-specific passthrough configuration.<br/>
        /// Example: {"allow_fallbacks":false,"only":["google-ai-studio"]}
        /// </param>
        /// <param name="quality">
        /// Rendering quality. Providers without a quality knob ignore this.<br/>
        /// Example: high
        /// </param>
        /// <param name="resolution">
        /// Normalized resolution tier of the generated image. Concrete pixel dimensions are derived per-provider.<br/>
        /// Example: 2K
        /// </param>
        /// <param name="seed">
        /// If specified, the generation will sample deterministically, such that repeated requests with the same seed and parameters should return the same result. Determinism is not guaranteed for all providers.
        /// </param>
        /// <param name="sessionId">
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow). Used for observability grouping in Broadcast and private logging; never sent to the provider. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.<br/>
        /// Example: session-1234
        /// </param>
        /// <param name="size">
        /// Optional. A convenience shorthand for output dimensions — pass a tier ("2K", "4K") or explicit pixels ("2048x2048") and we normalize it to the right dimensions for the chosen provider. A tier size is equivalent to setting `resolution` and combines with `aspect_ratio`. An explicit pixel size is authoritative: a mismatched `resolution` or `aspect_ratio` alongside it is rejected with a 400.<br/>
        /// Example: 2K
        /// </param>
        /// <param name="trace">
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.<br/>
        /// Example: {"trace_id":"trace-abc123","trace_name":"my-app-trace"}
        /// </param>
        /// <param name="user">
        /// A stable identifier for your end-users. Used to help detect and prevent abuse. Never sent to providers verbatim: for providers whose data policy requires user IDs, it is folded into a hashed, per-account upstream user identifier.<br/>
        /// Example: end-user-abc123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::OpenRouter.ImageStreamingResponse> GenerateAsStreamAsync(
            string model,
            string prompt,
            global::OpenRouter.ImageGenerationRequestAspectRatio? aspectRatio = default,
            global::OpenRouter.ImageGenerationRequestBackground? background = default,
            global::System.Collections.Generic.IList<global::OpenRouter.ContentPartImage>? inputReferences = default,
            int? n = default,
            int? outputCompression = default,
            global::OpenRouter.ImageGenerationRequestOutputFormat? outputFormat = default,
            global::OpenRouter.ImageGenerationProviderPreferences? provider = default,
            global::OpenRouter.ImageGenerationRequestQuality? quality = default,
            global::OpenRouter.ImageGenerationRequestResolution? resolution = default,
            int? seed = default,
            string? sessionId = default,
            string? size = default,
            global::OpenRouter.TraceConfig? trace = default,
            string? user = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}