
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateEmbeddingsRequestInputVariant6ItemContentItemVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.CreateEmbeddingsRequestInputVariant6ItemContentItemVariant2ImageUrl ImageUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.CreateEmbeddingsRequestInputVariant6ItemContentItemVariant2TypeJsonConverter))]
        public global::OpenRouter.CreateEmbeddingsRequestInputVariant6ItemContentItemVariant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmbeddingsRequestInputVariant6ItemContentItemVariant2" /> class.
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEmbeddingsRequestInputVariant6ItemContentItemVariant2(
            global::OpenRouter.CreateEmbeddingsRequestInputVariant6ItemContentItemVariant2ImageUrl imageUrl,
            global::OpenRouter.CreateEmbeddingsRequestInputVariant6ItemContentItemVariant2Type type)
        {
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmbeddingsRequestInputVariant6ItemContentItemVariant2" /> class.
        /// </summary>
        public CreateEmbeddingsRequestInputVariant6ItemContentItemVariant2()
        {
        }

    }
}