
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"allowed_passthrough_parameters":[],"canonical_slug":"google/veo-3.1","created":1700000000,"description":"Google video generation model","generate_audio":true,"id":"google/veo-3.1","name":"Veo 3.1","pricing_skus":{"generate":"0.50"},"seed":null,"supported_aspect_ratios":["16:9"],"supported_durations":[5,8],"supported_frame_images":["first_frame","last_frame"],"supported_resolutions":["720p"],"supported_sizes":null}
    /// </summary>
    public sealed partial class VideoModel
    {
        /// <summary>
        /// List of parameters that are allowed to be passed through to the provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_passthrough_parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AllowedPassthroughParameters { get; set; }

        /// <summary>
        /// Canonical slug for the model<br/>
        /// Example: openai/gpt-4
        /// </summary>
        /// <example>openai/gpt-4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("canonical_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CanonicalSlug { get; set; }

        /// <summary>
        /// Unix timestamp of when the model was created<br/>
        /// Example: 1692901234
        /// </summary>
        /// <example>1692901234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset Created { get; set; }

        /// <summary>
        /// Supported creativity levels for video upscaling models
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creativity")]
        public global::System.Collections.Generic.IList<int>? Creativity { get; set; }

        /// <summary>
        /// Description of the model<br/>
        /// Example: GPT-4 is a large multimodal model that can solve difficult problems with greater accuracy.
        /// </summary>
        /// <example>GPT-4 is a large multimodal model that can solve difficult problems with greater accuracy.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether the model supports generating audio alongside video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generate_audio")]
        public bool? GenerateAudio { get; set; }

        /// <summary>
        /// Hugging Face model identifier, if applicable<br/>
        /// Example: microsoft/DialoGPT-medium
        /// </summary>
        /// <example>microsoft/DialoGPT-medium</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hugging_face_id")]
        public string? HuggingFaceId { get; set; }

        /// <summary>
        /// Unique identifier for the model<br/>
        /// Example: openai/gpt-4
        /// </summary>
        /// <example>openai/gpt-4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Display name of the model<br/>
        /// Example: GPT-4
        /// </summary>
        /// <example>GPT-4</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Pricing SKUs with provider prefix stripped, values as strings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing_skus")]
        public global::System.Collections.Generic.Dictionary<string, string>? PricingSkus { get; set; }

        /// <summary>
        /// Whether the model supports deterministic generation via seed parameter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public bool? Seed { get; set; }

        /// <summary>
        /// Supported output aspect ratios
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_aspect_ratios")]
        public global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedAspectRatio>? SupportedAspectRatios { get; set; }

        /// <summary>
        /// Supported video durations in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_durations")]
        public global::System.Collections.Generic.IList<int>? SupportedDurations { get; set; }

        /// <summary>
        /// Supported frame image types (e.g. first_frame, last_frame)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_frame_images")]
        public global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedFrameImage>? SupportedFrameImages { get; set; }

        /// <summary>
        /// Supported output resolutions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_resolutions")]
        public global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedResolution>? SupportedResolutions { get; set; }

        /// <summary>
        /// Supported output sizes (width x height)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_sizes")]
        public global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedSize>? SupportedSizes { get; set; }

        /// <summary>
        /// Supported upscale factor range for video upscaling models
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upscale_factor")]
        public global::OpenRouter.VideoModelUpscaleFactor? UpscaleFactor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoModel" /> class.
        /// </summary>
        /// <param name="allowedPassthroughParameters">
        /// List of parameters that are allowed to be passed through to the provider
        /// </param>
        /// <param name="canonicalSlug">
        /// Canonical slug for the model<br/>
        /// Example: openai/gpt-4
        /// </param>
        /// <param name="created">
        /// Unix timestamp of when the model was created<br/>
        /// Example: 1692901234
        /// </param>
        /// <param name="id">
        /// Unique identifier for the model<br/>
        /// Example: openai/gpt-4
        /// </param>
        /// <param name="name">
        /// Display name of the model<br/>
        /// Example: GPT-4
        /// </param>
        /// <param name="creativity">
        /// Supported creativity levels for video upscaling models
        /// </param>
        /// <param name="description">
        /// Description of the model<br/>
        /// Example: GPT-4 is a large multimodal model that can solve difficult problems with greater accuracy.
        /// </param>
        /// <param name="generateAudio">
        /// Whether the model supports generating audio alongside video
        /// </param>
        /// <param name="huggingFaceId">
        /// Hugging Face model identifier, if applicable<br/>
        /// Example: microsoft/DialoGPT-medium
        /// </param>
        /// <param name="pricingSkus">
        /// Pricing SKUs with provider prefix stripped, values as strings
        /// </param>
        /// <param name="seed">
        /// Whether the model supports deterministic generation via seed parameter
        /// </param>
        /// <param name="supportedAspectRatios">
        /// Supported output aspect ratios
        /// </param>
        /// <param name="supportedDurations">
        /// Supported video durations in seconds
        /// </param>
        /// <param name="supportedFrameImages">
        /// Supported frame image types (e.g. first_frame, last_frame)
        /// </param>
        /// <param name="supportedResolutions">
        /// Supported output resolutions
        /// </param>
        /// <param name="supportedSizes">
        /// Supported output sizes (width x height)
        /// </param>
        /// <param name="upscaleFactor">
        /// Supported upscale factor range for video upscaling models
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoModel(
            global::System.Collections.Generic.IList<string> allowedPassthroughParameters,
            string canonicalSlug,
            global::System.DateTimeOffset created,
            string id,
            string name,
            global::System.Collections.Generic.IList<int>? creativity,
            string? description,
            bool? generateAudio,
            string? huggingFaceId,
            global::System.Collections.Generic.Dictionary<string, string>? pricingSkus,
            bool? seed,
            global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedAspectRatio>? supportedAspectRatios,
            global::System.Collections.Generic.IList<int>? supportedDurations,
            global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedFrameImage>? supportedFrameImages,
            global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedResolution>? supportedResolutions,
            global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedSize>? supportedSizes,
            global::OpenRouter.VideoModelUpscaleFactor? upscaleFactor)
        {
            this.AllowedPassthroughParameters = allowedPassthroughParameters ?? throw new global::System.ArgumentNullException(nameof(allowedPassthroughParameters));
            this.CanonicalSlug = canonicalSlug ?? throw new global::System.ArgumentNullException(nameof(canonicalSlug));
            this.Created = created;
            this.Creativity = creativity;
            this.Description = description;
            this.GenerateAudio = generateAudio;
            this.HuggingFaceId = huggingFaceId;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PricingSkus = pricingSkus;
            this.Seed = seed;
            this.SupportedAspectRatios = supportedAspectRatios;
            this.SupportedDurations = supportedDurations;
            this.SupportedFrameImages = supportedFrameImages;
            this.SupportedResolutions = supportedResolutions;
            this.SupportedSizes = supportedSizes;
            this.UpscaleFactor = upscaleFactor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoModel" /> class.
        /// </summary>
        public VideoModel()
        {
        }

    }
}