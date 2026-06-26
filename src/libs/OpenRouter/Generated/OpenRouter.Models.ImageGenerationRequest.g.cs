
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Image generation request input
    /// </summary>
    public sealed partial class ImageGenerationRequest
    {
        /// <summary>
        /// Normalized aspect ratio of the generated image. Providers clamp to their supported subset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ImageGenerationRequestAspectRatioJsonConverter))]
        public global::OpenRouter.ImageGenerationRequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Background treatment. `transparent` requires an output_format that supports alpha (png or webp).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ImageGenerationRequestBackgroundJsonConverter))]
        public global::OpenRouter.ImageGenerationRequestBackground? Background { get; set; }

        /// <summary>
        /// Reference images to guide image-to-image generation, as base64 data URLs or HTTP(S) URLs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_references")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ContentPartImage>? InputReferences { get; set; }

        /// <summary>
        /// The image generation model to use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Number of images to generate (1-10). Providers that only support single-image generation reject n &gt; 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n")]
        public int? N { get; set; }

        /// <summary>
        /// Compression level (0-100) for webp/jpeg output. Ignored for png and by providers without a compression knob.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_compression")]
        public int? OutputCompression { get; set; }

        /// <summary>
        /// Encoding of the returned image bytes. Most models produce raster formats (png, jpeg, webp). SVG is supported by vectorization models (e.g. Quiver) — the SVG markup is UTF-8 base64-encoded in `b64_json`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ImageGenerationRequestOutputFormatJsonConverter))]
        public global::OpenRouter.ImageGenerationRequestOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Text description of the desired image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Provider-specific passthrough configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public global::OpenRouter.ImageGenerationRequestProvider? Provider { get; set; }

        /// <summary>
        /// Rendering quality. Providers without a quality knob ignore this.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ImageGenerationRequestQualityJsonConverter))]
        public global::OpenRouter.ImageGenerationRequestQuality? Quality { get; set; }

        /// <summary>
        /// Normalized resolution tier of the generated image. Concrete pixel dimensions are derived per-provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ImageGenerationRequestResolutionJsonConverter))]
        public global::OpenRouter.ImageGenerationRequestResolution? Resolution { get; set; }

        /// <summary>
        /// If specified, the generation will sample deterministically, such that repeated requests with the same seed and parameters should return the same result. Determinism is not guaranteed for all providers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Optional. A convenience shorthand for output dimensions — pass a tier ("2K", "4K") or explicit pixels ("2048x2048") and we normalize it to the right dimensions for the chosen provider. Interchangeable with resolution + aspect_ratio; use those directly for enumerated, per-model discoverable values. Conflicting size + resolution/aspect_ratio is rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }

        /// <summary>
        /// If true, partial images are streamed as SSE events as they become available. Only supported by providers with native streaming (currently OpenAI). Non-streaming providers ignore this flag and return a buffered response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The image generation model to use
        /// </param>
        /// <param name="prompt">
        /// Text description of the desired image
        /// </param>
        /// <param name="aspectRatio">
        /// Normalized aspect ratio of the generated image. Providers clamp to their supported subset.
        /// </param>
        /// <param name="background">
        /// Background treatment. `transparent` requires an output_format that supports alpha (png or webp).
        /// </param>
        /// <param name="inputReferences">
        /// Reference images to guide image-to-image generation, as base64 data URLs or HTTP(S) URLs.
        /// </param>
        /// <param name="n">
        /// Number of images to generate (1-10). Providers that only support single-image generation reject n &gt; 1.
        /// </param>
        /// <param name="outputCompression">
        /// Compression level (0-100) for webp/jpeg output. Ignored for png and by providers without a compression knob.
        /// </param>
        /// <param name="outputFormat">
        /// Encoding of the returned image bytes. Most models produce raster formats (png, jpeg, webp). SVG is supported by vectorization models (e.g. Quiver) — the SVG markup is UTF-8 base64-encoded in `b64_json`.
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
            global::OpenRouter.ImageGenerationRequestProvider? provider,
            global::OpenRouter.ImageGenerationRequestQuality? quality,
            global::OpenRouter.ImageGenerationRequestResolution? resolution,
            int? seed,
            string? size,
            bool? stream)
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
            this.Size = size;
            this.Stream = stream;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationRequest" /> class.
        /// </summary>
        public ImageGenerationRequest()
        {
        }

    }
}