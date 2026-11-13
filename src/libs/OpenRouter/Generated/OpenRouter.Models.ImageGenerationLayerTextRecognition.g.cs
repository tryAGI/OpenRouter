
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Text found in the layer, present when the provider ran text recognition<br/>
    /// Example: {"lines":[{"bounding_box":{"absolute":[238,124,786,673],"normalized":[232,121,768,657]},"runs":[{"text":"SALE"}]}],"text":"SALE"}
    /// </summary>
    public sealed partial class ImageGenerationLayerTextRecognition
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lines")]
        public global::System.Collections.Generic.IList<global::OpenRouter.ImageGenerationLayerTextRecognitionLine>? Lines { get; set; }

        /// <summary>
        /// Full text recognized in the layer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationLayerTextRecognition" /> class.
        /// </summary>
        /// <param name="text">
        /// Full text recognized in the layer
        /// </param>
        /// <param name="lines"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationLayerTextRecognition(
            string text,
            global::System.Collections.Generic.IList<global::OpenRouter.ImageGenerationLayerTextRecognitionLine>? lines)
        {
            this.Lines = lines;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationLayerTextRecognition" /> class.
        /// </summary>
        public ImageGenerationLayerTextRecognition()
        {
        }

    }
}