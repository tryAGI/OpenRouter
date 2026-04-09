
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
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
        /// Canonical slug for the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canonical_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CanonicalSlug { get; set; }

        /// <summary>
        /// Unix timestamp of when the model was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset Created { get; set; }

        /// <summary>
        /// Description of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Hugging Face model identifier, if applicable
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hugging_face_id")]
        public string? HuggingFaceId { get; set; }

        /// <summary>
        /// Unique identifier for the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Display name of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Pricing SKUs with provider prefix stripped, values as strings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing_skus")]
        public global::System.Collections.Generic.Dictionary<string, string>? PricingSkus { get; set; }

        /// <summary>
        /// Supported output aspect ratios
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_aspect_ratios")]
        public global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedAspectRatiosItems>? SupportedAspectRatios { get; set; }

        /// <summary>
        /// Supported video durations in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_durations")]
        public global::System.Collections.Generic.IList<int>? SupportedDurations { get; set; }

        /// <summary>
        /// Supported output resolutions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_resolutions")]
        public global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedResolutionsItems>? SupportedResolutions { get; set; }

        /// <summary>
        /// Supported output sizes (width x height)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_sizes")]
        public global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedSizesItems>? SupportedSizes { get; set; }

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
        /// Canonical slug for the model
        /// </param>
        /// <param name="created">
        /// Unix timestamp of when the model was created
        /// </param>
        /// <param name="id">
        /// Unique identifier for the model
        /// </param>
        /// <param name="name">
        /// Display name of the model
        /// </param>
        /// <param name="description">
        /// Description of the model
        /// </param>
        /// <param name="huggingFaceId">
        /// Hugging Face model identifier, if applicable
        /// </param>
        /// <param name="pricingSkus">
        /// Pricing SKUs with provider prefix stripped, values as strings
        /// </param>
        /// <param name="supportedAspectRatios">
        /// Supported output aspect ratios
        /// </param>
        /// <param name="supportedDurations">
        /// Supported video durations in seconds
        /// </param>
        /// <param name="supportedResolutions">
        /// Supported output resolutions
        /// </param>
        /// <param name="supportedSizes">
        /// Supported output sizes (width x height)
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
            string? description,
            string? huggingFaceId,
            global::System.Collections.Generic.Dictionary<string, string>? pricingSkus,
            global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedAspectRatiosItems>? supportedAspectRatios,
            global::System.Collections.Generic.IList<int>? supportedDurations,
            global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedResolutionsItems>? supportedResolutions,
            global::System.Collections.Generic.IList<global::OpenRouter.VideoModelSupportedSizesItems>? supportedSizes)
        {
            this.AllowedPassthroughParameters = allowedPassthroughParameters ?? throw new global::System.ArgumentNullException(nameof(allowedPassthroughParameters));
            this.CanonicalSlug = canonicalSlug ?? throw new global::System.ArgumentNullException(nameof(canonicalSlug));
            this.Created = created;
            this.Description = description;
            this.HuggingFaceId = huggingFaceId;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PricingSkus = pricingSkus;
            this.SupportedAspectRatios = supportedAspectRatios;
            this.SupportedDurations = supportedDurations;
            this.SupportedResolutions = supportedResolutions;
            this.SupportedSizes = supportedSizes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoModel" /> class.
        /// </summary>
        public VideoModel()
        {
        }
    }
}