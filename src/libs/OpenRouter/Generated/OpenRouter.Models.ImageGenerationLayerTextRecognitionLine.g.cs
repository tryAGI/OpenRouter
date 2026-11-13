
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ImageGenerationLayerTextRecognitionLine
    {
        /// <summary>
        /// Where a layer sits on the base image<br/>
        /// Example: {"absolute":[238,124,786,673],"normalized":[232,121,768,657]}
        /// </summary>
        /// <example>{"absolute":[238,124,786,673],"normalized":[232,121,768,657]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bounding_box")]
        public global::OpenRouter.ImageGenerationLayerBoundingBox? BoundingBox { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ImageGenerationLayerTextRun> Runs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationLayerTextRecognitionLine" /> class.
        /// </summary>
        /// <param name="runs"></param>
        /// <param name="boundingBox">
        /// Where a layer sits on the base image<br/>
        /// Example: {"absolute":[238,124,786,673],"normalized":[232,121,768,657]}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationLayerTextRecognitionLine(
            global::System.Collections.Generic.IList<global::OpenRouter.ImageGenerationLayerTextRun> runs,
            global::OpenRouter.ImageGenerationLayerBoundingBox? boundingBox)
        {
            this.BoundingBox = boundingBox;
            this.Runs = runs ?? throw new global::System.ArgumentNullException(nameof(runs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationLayerTextRecognitionLine" /> class.
        /// </summary>
        public ImageGenerationLayerTextRecognitionLine()
        {
        }

    }
}