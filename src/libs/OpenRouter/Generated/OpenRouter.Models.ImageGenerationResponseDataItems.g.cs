
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageGenerationResponseDataItems
    {
        /// <summary>
        /// Base64-encoded image bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("b64_json")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string B64Json { get; set; }

        /// <summary>
        /// Media type (MIME type) of the image. Omitted when the output is a standard raster format (PNG). Present for non-raster outputs such as SVG (`image/svg+xml`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        public string? MediaType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationResponseDataItems" /> class.
        /// </summary>
        /// <param name="b64Json">
        /// Base64-encoded image bytes
        /// </param>
        /// <param name="mediaType">
        /// Media type (MIME type) of the image. Omitted when the output is a standard raster format (PNG). Present for non-raster outputs such as SVG (`image/svg+xml`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationResponseDataItems(
            string b64Json,
            string? mediaType)
        {
            this.B64Json = b64Json ?? throw new global::System.ArgumentNullException(nameof(b64Json));
            this.MediaType = mediaType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationResponseDataItems" /> class.
        /// </summary>
        public ImageGenerationResponseDataItems()
        {
        }

    }
}