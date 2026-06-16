
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// image_url variant
    /// </summary>
    public sealed partial class InputReferenceVariant2
    {
        /// <summary>
        /// Discriminator value: image_url
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InputReferenceVariant2TypeJsonConverter))]
        public global::OpenRouter.InputReferenceVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.InputReferenceDiscriminatorMappingImageUrlImageUrl ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputReferenceVariant2" /> class.
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <param name="type">
        /// Discriminator value: image_url
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputReferenceVariant2(
            global::OpenRouter.InputReferenceDiscriminatorMappingImageUrlImageUrl imageUrl,
            global::OpenRouter.InputReferenceVariant2Type type)
        {
            this.Type = type;
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputReferenceVariant2" /> class.
        /// </summary>
        public InputReferenceVariant2()
        {
        }

    }
}