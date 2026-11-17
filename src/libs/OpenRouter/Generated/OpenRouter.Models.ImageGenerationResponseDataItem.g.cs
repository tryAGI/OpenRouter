
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImageGenerationResponseDataItem
    {
        /// <summary>
        /// Base64-encoded image bytes. Present unless the request asked for `response_format: "url"` and `url` was issued.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("b64_json")]
        public string? B64Json { get; set; }

        /// <summary>
        /// Layer metadata, present when the request asked the provider to split the image into layers (Seedream: `provider.options.seed.layer_decomposition: true` with the required `layer_decomposition_options.max_images`, 2 to 16). Decomposition requires `n` to be 1 or omitted; the response returns up to `max_images` images (the base image plus its layers).<br/>
        /// Example: {"background":"transparent","bounding_box":{"absolute":[238,124,786,673],"normalized":[232,121,768,657]},"description":"A solid red circle","name":"Red circle","z_index":1}
        /// </summary>
        /// <example>{"background":"transparent","bounding_box":{"absolute":[238,124,786,673],"normalized":[232,121,768,657]},"description":"A solid red circle","name":"Red circle","z_index":1}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("layer")]
        public global::OpenRouter.ImageGenerationLayer? Layer { get; set; }

        /// <summary>
        /// Media type (MIME type) of the image, e.g. `image/png`, `image/jpeg`, `image/webp`, `image/svg+xml`. May be omitted if the format could not be determined.<br/>
        /// Example: image/png
        /// </summary>
        /// <example>image/png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        public string? MediaType { get; set; }

        /// <summary>
        /// Signed download URL for the image bytes, issued for `response_format: "url"` requests. Valid until `expires_at`. Absent when the response fell back to `b64_json`.<br/>
        /// Example: https://storage.googleapis.com/openrouter-generated-media-us/v1/...
        /// </summary>
        /// <example>https://storage.googleapis.com/openrouter-generated-media-us/v1/...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationResponseDataItem" /> class.
        /// </summary>
        /// <param name="b64Json">
        /// Base64-encoded image bytes. Present unless the request asked for `response_format: "url"` and `url` was issued.
        /// </param>
        /// <param name="layer">
        /// Layer metadata, present when the request asked the provider to split the image into layers (Seedream: `provider.options.seed.layer_decomposition: true` with the required `layer_decomposition_options.max_images`, 2 to 16). Decomposition requires `n` to be 1 or omitted; the response returns up to `max_images` images (the base image plus its layers).<br/>
        /// Example: {"background":"transparent","bounding_box":{"absolute":[238,124,786,673],"normalized":[232,121,768,657]},"description":"A solid red circle","name":"Red circle","z_index":1}
        /// </param>
        /// <param name="mediaType">
        /// Media type (MIME type) of the image, e.g. `image/png`, `image/jpeg`, `image/webp`, `image/svg+xml`. May be omitted if the format could not be determined.<br/>
        /// Example: image/png
        /// </param>
        /// <param name="url">
        /// Signed download URL for the image bytes, issued for `response_format: "url"` requests. Valid until `expires_at`. Absent when the response fell back to `b64_json`.<br/>
        /// Example: https://storage.googleapis.com/openrouter-generated-media-us/v1/...
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationResponseDataItem(
            string? b64Json,
            global::OpenRouter.ImageGenerationLayer? layer,
            string? mediaType,
            string? url)
        {
            this.B64Json = b64Json;
            this.Layer = layer;
            this.MediaType = mediaType;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationResponseDataItem" /> class.
        /// </summary>
        public ImageGenerationResponseDataItem()
        {
        }

    }
}