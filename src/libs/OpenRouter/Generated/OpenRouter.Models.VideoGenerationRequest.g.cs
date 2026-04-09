
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoGenerationRequest
    {
        /// <summary>
        /// Aspect ratio of the generated video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.VideoGenerationRequestAspectRatioJsonConverter))]
        public global::OpenRouter.VideoGenerationRequestAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Duration of the generated video in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Whether to generate audio alongside the video. Defaults to true for models that support audio output, false otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generate_audio")]
        public bool? GenerateAudio { get; set; }

        /// <summary>
        /// Reference images to guide video generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_references")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ContentPartImage>? InputReferences { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Provider-specific passthrough configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public global::OpenRouter.VideoGenerationRequestProvider? Provider { get; set; }

        /// <summary>
        /// Resolution of the generated video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.VideoGenerationRequestResolutionJsonConverter))]
        public global::OpenRouter.VideoGenerationRequestResolution? Resolution { get; set; }

        /// <summary>
        /// If specified, the generation will sample deterministically, such that repeated requests with the same seed and parameters should return the same result. Determinism is not guaranteed for all providers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Exact pixel dimensions of the generated video in "WIDTHxHEIGHT" format (e.g. "1280x720"). Interchangeable with resolution + aspect_ratio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoGenerationRequest" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="prompt"></param>
        /// <param name="aspectRatio">
        /// Aspect ratio of the generated video
        /// </param>
        /// <param name="duration">
        /// Duration of the generated video in seconds
        /// </param>
        /// <param name="generateAudio">
        /// Whether to generate audio alongside the video. Defaults to true for models that support audio output, false otherwise.
        /// </param>
        /// <param name="inputReferences">
        /// Reference images to guide video generation
        /// </param>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoGenerationRequest(
            string model,
            string prompt,
            global::OpenRouter.VideoGenerationRequestAspectRatio? aspectRatio,
            int? duration,
            bool? generateAudio,
            global::System.Collections.Generic.IList<global::OpenRouter.ContentPartImage>? inputReferences,
            global::OpenRouter.VideoGenerationRequestProvider? provider,
            global::OpenRouter.VideoGenerationRequestResolution? resolution,
            int? seed,
            string? size)
        {
            this.AspectRatio = aspectRatio;
            this.Duration = duration;
            this.GenerateAudio = generateAudio;
            this.InputReferences = inputReferences;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Provider = provider;
            this.Resolution = resolution;
            this.Seed = seed;
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoGenerationRequest" /> class.
        /// </summary>
        public VideoGenerationRequest()
        {
        }
    }
}