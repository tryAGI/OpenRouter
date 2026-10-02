
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Image generation request input<br/>
    /// Example: {"model":"bytedance-seed/seedream-4.5","prompt":"a red panda astronaut floating in space, studio lighting"}
    /// </summary>
    public sealed partial class ImageGenerationRequest
    {
        /// <summary>
        /// Normalized aspect ratio of the generated image. Providers clamp to their supported subset.<br/>
        /// Example: 16:9
        /// </summary>
        /// <example>16:9</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ImageGenerationRequestAspectRatioJsonConverter))]
        public global::OpenRouter.ImageGenerationRequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Background treatment. `transparent` requires an output_format that supports alpha (png or webp).<br/>
        /// Example: auto
        /// </summary>
        /// <example>auto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ImageGenerationRequestBackgroundJsonConverter))]
        public global::OpenRouter.ImageGenerationRequestBackground? Background { get; set; }

        /// <summary>
        /// Reference images to guide image-to-image generation, as base64 data URLs or HTTP(S) URLs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_references")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ContentPartImage>? InputReferences { get; set; }

        /// <summary>
        /// The image generation model to use<br/>
        /// Example: bytedance-seed/seedream-4.5
        /// </summary>
        /// <example>bytedance-seed/seedream-4.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Upper bound on the number of images to generate (1-10). Providers may return fewer images, and providers that only support single-image generation reject n &gt; 1.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        /// Compression level (0-100) for webp/jpeg output. Ignored for png and by providers without a compression knob.<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_compression")]
        public int? OutputCompression { get; set; }

        /// <summary>
        /// Encoding of the returned image bytes. Most models produce raster formats (png, jpeg, webp). SVG is supported by vectorization models (e.g. Quiver) — the SVG markup is UTF-8 base64-encoded in `b64_json`.<br/>
        /// Example: png
        /// </summary>
        /// <example>png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ImageGenerationRequestOutputFormatJsonConverter))]
        public global::OpenRouter.ImageGenerationRequestOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Text description of the desired image<br/>
        /// Example: a red panda astronaut floating in space, studio lighting
        /// </summary>
        /// <example>a red panda astronaut floating in space, studio lighting</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Provider routing preferences and provider-specific passthrough configuration.<br/>
        /// Example: {"allow_fallbacks":false,"only":["google-ai-studio"]}
        /// </summary>
        /// <example>{"allow_fallbacks":false,"only":["google-ai-studio"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public global::OpenRouter.ImageGenerationProviderPreferences? Provider { get; set; }

        /// <summary>
        /// Rendering quality. Providers without a quality knob ignore this.<br/>
        /// Example: high
        /// </summary>
        /// <example>high</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ImageGenerationRequestQualityJsonConverter))]
        public global::OpenRouter.ImageGenerationRequestQuality? Quality { get; set; }

        /// <summary>
        /// Normalized resolution tier of the generated image. Concrete pixel dimensions are derived per-provider.<br/>
        /// Example: 2K
        /// </summary>
        /// <example>2K</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ImageGenerationRequestResolutionJsonConverter))]
        public global::OpenRouter.ImageGenerationRequestResolution? Resolution { get; set; }

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
        /// Optional. A convenience shorthand for output dimensions — pass a tier ("2K", "4K") or explicit pixels ("2048x2048") and we normalize it to the right dimensions for the chosen provider. A tier size is equivalent to setting `resolution` and combines with `aspect_ratio`. An explicit pixel size is authoritative: a mismatched `resolution` or `aspect_ratio` alongside it is rejected with a 400.<br/>
        /// Example: 2K
        /// </summary>
        /// <example>2K</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }

        /// <summary>
        /// If true, partial images are streamed as SSE events as they become available. Only supported by providers with native streaming (currently OpenAI). Non-streaming providers ignore this flag and return a buffered response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.<br/>
        /// Example: {"trace_id":"trace-abc123","trace_name":"my-app-trace"}
        /// </summary>
        /// <example>{"trace_id":"trace-abc123","trace_name":"my-app-trace"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace")]
        public global::OpenRouter.TraceConfig? Trace { get; set; }

        /// <summary>
        /// A stable identifier for your end-users. Used to help detect and prevent abuse. Never sent to providers verbatim: for providers whose data policy requires user IDs, it is folded into a hashed, per-account upstream user identifier.<br/>
        /// Example: end-user-abc123
        /// </summary>
        /// <example>end-user-abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The image generation model to use<br/>
        /// Example: bytedance-seed/seedream-4.5
        /// </param>
        /// <param name="prompt">
        /// Text description of the desired image<br/>
        /// Example: a red panda astronaut floating in space, studio lighting
        /// </param>
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
        /// <param name="stream">
        /// If true, partial images are streamed as SSE events as they become available. Only supported by providers with native streaming (currently OpenAI). Non-streaming providers ignore this flag and return a buffered response.
        /// </param>
        /// <param name="trace">
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.<br/>
        /// Example: {"trace_id":"trace-abc123","trace_name":"my-app-trace"}
        /// </param>
        /// <param name="user">
        /// A stable identifier for your end-users. Used to help detect and prevent abuse. Never sent to providers verbatim: for providers whose data policy requires user IDs, it is folded into a hashed, per-account upstream user identifier.<br/>
        /// Example: end-user-abc123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationRequest(
            string model,
            string prompt,
            global::OpenRouter.ImageGenerationRequestAspectRatio? aspectRatio,
            global::OpenRouter.ImageGenerationRequestBackground? background,
            global::System.Collections.Generic.IList<global::OpenRouter.ContentPartImage>? inputReferences,
            int? n,
            int? outputCompression,
            global::OpenRouter.ImageGenerationRequestOutputFormat? outputFormat,
            global::OpenRouter.ImageGenerationProviderPreferences? provider,
            global::OpenRouter.ImageGenerationRequestQuality? quality,
            global::OpenRouter.ImageGenerationRequestResolution? resolution,
            int? seed,
            string? sessionId,
            string? size,
            bool? stream,
            global::OpenRouter.TraceConfig? trace,
            string? user)
        {
            this.AspectRatio = aspectRatio;
            this.Background = background;
            this.InputReferences = inputReferences;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.N = n;
            this.OutputCompression = outputCompression;
            this.OutputFormat = outputFormat;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Provider = provider;
            this.Quality = quality;
            this.Resolution = resolution;
            this.Seed = seed;
            this.SessionId = sessionId;
            this.Size = size;
            this.Stream = stream;
            this.Trace = trace;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationRequest" /> class.
        /// </summary>
        public ImageGenerationRequest()
        {
        }

    }
}