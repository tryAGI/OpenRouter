
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A run of text that shares one style<br/>
    /// Example: {"style":{"bold":true,"similar_font_family":"Menlo"},"text":"SALE"}
    /// </summary>
    public sealed partial class ImageGenerationLayerTextRun
    {
        /// <summary>
        /// Font and style the provider recognized for this run, e.g. `similar_font_family`, `foreground_color`, `bold`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        public object? Style { get; set; }

        /// <summary>
        ///
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
        /// Initializes a new instance of the <see cref="ImageGenerationLayerTextRun" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="style">
        /// Font and style the provider recognized for this run, e.g. `similar_font_family`, `foreground_color`, `bold`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationLayerTextRun(
            string text,
            object? style)
        {
            this.Style = style;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationLayerTextRun" /> class.
        /// </summary>
        public ImageGenerationLayerTextRun()
        {
        }

    }
}