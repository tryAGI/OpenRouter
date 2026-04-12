
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FrameImage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ContentPartImageImageUrl ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ContentPartImageTypeJsonConverter))]
        public global::OpenRouter.ContentPartImageType Type { get; set; }

        /// <summary>
        /// Whether this image represents the first or last frame of the video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.FrameImageFrameTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.FrameImageFrameType FrameType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FrameImage" /> class.
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <param name="frameType">
        /// Whether this image represents the first or last frame of the video
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FrameImage(
            global::OpenRouter.ContentPartImageImageUrl imageUrl,
            global::OpenRouter.FrameImageFrameType frameType,
            global::OpenRouter.ContentPartImageType type)
        {
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.Type = type;
            this.FrameType = frameType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FrameImage" /> class.
        /// </summary>
        public FrameImage()
        {
        }
    }
}