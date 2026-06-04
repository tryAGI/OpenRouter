
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// video_url variant
    /// </summary>
    public sealed partial class InputReferenceVariant3
    {
        /// <summary>
        /// Discriminator value: video_url
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InputReferenceVariant3TypeJsonConverter))]
        public global::OpenRouter.InputReferenceVariant3Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.InputReferenceDiscriminatorMappingVideoUrlVideoUrl VideoUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputReferenceVariant3" /> class.
        /// </summary>
        /// <param name="videoUrl"></param>
        /// <param name="type">
        /// Discriminator value: video_url
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputReferenceVariant3(
            global::OpenRouter.InputReferenceDiscriminatorMappingVideoUrlVideoUrl videoUrl,
            global::OpenRouter.InputReferenceVariant3Type type)
        {
            this.Type = type;
            this.VideoUrl = videoUrl ?? throw new global::System.ArgumentNullException(nameof(videoUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputReferenceVariant3" /> class.
        /// </summary>
        public InputReferenceVariant3()
        {
        }

    }
}