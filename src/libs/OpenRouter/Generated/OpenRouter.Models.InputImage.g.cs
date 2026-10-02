
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Image input content item. Provide either an image_url (a URL or a base64 data URL) or the file_id of an uploaded image.<br/>
    /// Example: {"detail":"auto","image_url":"https://example.com/image.jpg","type":"input_image"}
    /// </summary>
    public sealed partial class InputImage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InputImageDetailJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.InputImageDetail Detail { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.InputImageTypeJsonConverter))]
        public global::OpenRouter.InputImageType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputImage" /> class.
        /// </summary>
        /// <param name="detail"></param>
        /// <param name="fileId"></param>
        /// <param name="imageUrl"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputImage(
            global::OpenRouter.InputImageDetail detail,
            string? fileId,
            string? imageUrl,
            global::OpenRouter.InputImageType type)
        {
            this.Detail = detail;
            this.FileId = fileId;
            this.ImageUrl = imageUrl;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputImage" /> class.
        /// </summary>
        public InputImage()
        {
        }

    }
}