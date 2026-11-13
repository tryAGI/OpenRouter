
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Layer metadata, present when the request asked the provider to split the image into layers (Seedream: `provider.options.seed.layer_decomposition: true` with the required `layer_decomposition_options.max_images`, 2 to 16). Decomposition requires `n` to be 1 or omitted; the response returns up to `max_images` images (the base image plus its layers).<br/>
    /// Example: {"background":"transparent","bounding_box":{"absolute":[238,124,786,673],"normalized":[232,121,768,657]},"description":"A solid red circle","name":"Red circle","z_index":1}
    /// </summary>
    public sealed partial class ImageGenerationLayer
    {
        /// <summary>
        /// Whether the layer image has a transparent background
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ImageGenerationLayerBackgroundJsonConverter))]
        public global::OpenRouter.ImageGenerationLayerBackground? Background { get; set; }

        /// <summary>
        /// Where a layer sits on the base image<br/>
        /// Example: {"absolute":[238,124,786,673],"normalized":[232,121,768,657]}
        /// </summary>
        /// <example>{"absolute":[238,124,786,673],"normalized":[232,121,768,657]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bounding_box")]
        public global::OpenRouter.ImageGenerationLayerBoundingBox? BoundingBox { get; set; }

        /// <summary>
        /// Provider description of the layer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Short provider-assigned layer name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Text found in the layer, present when the provider ran text recognition<br/>
        /// Example: {"lines":[{"bounding_box":{"absolute":[238,124,786,673],"normalized":[232,121,768,657]},"runs":[{"text":"SALE"}]}],"text":"SALE"}
        /// </summary>
        /// <example>{"lines":[{"bounding_box":{"absolute":[238,124,786,673],"normalized":[232,121,768,657]},"runs":[{"text":"SALE"}]}],"text":"SALE"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_recognition")]
        public global::OpenRouter.ImageGenerationLayerTextRecognition? TextRecognition { get; set; }

        /// <summary>
        /// Stacking order; 0 is the opaque base image and higher values sit on top
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("z_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ZIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationLayer" /> class.
        /// </summary>
        /// <param name="zIndex">
        /// Stacking order; 0 is the opaque base image and higher values sit on top
        /// </param>
        /// <param name="background">
        /// Whether the layer image has a transparent background
        /// </param>
        /// <param name="boundingBox">
        /// Where a layer sits on the base image<br/>
        /// Example: {"absolute":[238,124,786,673],"normalized":[232,121,768,657]}
        /// </param>
        /// <param name="description">
        /// Provider description of the layer
        /// </param>
        /// <param name="name">
        /// Short provider-assigned layer name
        /// </param>
        /// <param name="textRecognition">
        /// Text found in the layer, present when the provider ran text recognition<br/>
        /// Example: {"lines":[{"bounding_box":{"absolute":[238,124,786,673],"normalized":[232,121,768,657]},"runs":[{"text":"SALE"}]}],"text":"SALE"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationLayer(
            int zIndex,
            global::OpenRouter.ImageGenerationLayerBackground? background,
            global::OpenRouter.ImageGenerationLayerBoundingBox? boundingBox,
            string? description,
            string? name,
            global::OpenRouter.ImageGenerationLayerTextRecognition? textRecognition)
        {
            this.Background = background;
            this.BoundingBox = boundingBox;
            this.Description = description;
            this.Name = name;
            this.TextRecognition = textRecognition;
            this.ZIndex = zIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationLayer" /> class.
        /// </summary>
        public ImageGenerationLayer()
        {
        }

    }
}