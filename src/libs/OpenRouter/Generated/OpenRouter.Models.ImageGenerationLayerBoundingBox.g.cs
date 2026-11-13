
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Where a layer sits on the base image<br/>
    /// Example: {"absolute":[238,124,786,673],"normalized":[232,121,768,657]}
    /// </summary>
    public sealed partial class ImageGenerationLayerBoundingBox
    {
        /// <summary>
        /// Layer box in pixels of the base image, as `[x_min, y_min, x_max, y_max]`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("absolute")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Absolute { get; set; }

        /// <summary>
        /// Layer box scaled to 0-1000 on each axis, as `[x_min, y_min, x_max, y_max]`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalized")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Normalized { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationLayerBoundingBox" /> class.
        /// </summary>
        /// <param name="absolute">
        /// Layer box in pixels of the base image, as `[x_min, y_min, x_max, y_max]`
        /// </param>
        /// <param name="normalized">
        /// Layer box scaled to 0-1000 on each axis, as `[x_min, y_min, x_max, y_max]`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationLayerBoundingBox(
            global::System.Collections.Generic.IList<int> absolute,
            global::System.Collections.Generic.IList<int> normalized)
        {
            this.Absolute = absolute ?? throw new global::System.ArgumentNullException(nameof(absolute));
            this.Normalized = normalized ?? throw new global::System.ArgumentNullException(nameof(normalized));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationLayerBoundingBox" /> class.
        /// </summary>
        public ImageGenerationLayerBoundingBox()
        {
        }

    }
}