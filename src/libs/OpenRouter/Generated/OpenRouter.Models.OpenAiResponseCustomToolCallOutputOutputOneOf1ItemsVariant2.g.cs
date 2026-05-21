
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Image input content item
    /// </summary>
    public sealed partial class OpenAiResponseCustomToolCallOutputOutputOneOf1ItemsVariant2
    {
        /// <summary>
        /// Discriminator value: input_image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OpenAiResponseCustomToolCallOutputOutputOneOf1ItemsVariant2TypeJsonConverter))]
        public global::OpenRouter.OpenAiResponseCustomToolCallOutputOutputOneOf1ItemsVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputImageDetailJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputImageDetail Detail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAiResponseCustomToolCallOutputOutputOneOf1ItemsVariant2" /> class.
        /// </summary>
        /// <param name="detail"></param>
        /// <param name="type">
        /// Discriminator value: input_image
        /// </param>
        /// <param name="imageUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAiResponseCustomToolCallOutputOutputOneOf1ItemsVariant2(
            global::OpenRouter.OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputImageDetail detail,
            global::OpenRouter.OpenAiResponseCustomToolCallOutputOutputOneOf1ItemsVariant2Type type,
            string? imageUrl)
        {
            this.Type = type;
            this.Detail = detail;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAiResponseCustomToolCallOutputOutputOneOf1ItemsVariant2" /> class.
        /// </summary>
        public OpenAiResponseCustomToolCallOutputOutputOneOf1ItemsVariant2()
        {
        }

    }
}