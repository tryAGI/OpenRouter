
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Image input content item
    /// </summary>
    public sealed partial class InputImage
    {
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
        /// Initializes a new instance of the <see cref="InputImage" /> class.
        /// </summary>
        /// <param name="detail"></param>
        /// <param name="imageUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputImage(
            global::OpenRouter.OpenAiResponseInputMessageItemContentItemsDiscriminatorMappingInputImageDetail detail,
            string? imageUrl)
        {
            this.Detail = detail;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputImage" /> class.
        /// </summary>
        public InputImage()
        {
        }

    }
}