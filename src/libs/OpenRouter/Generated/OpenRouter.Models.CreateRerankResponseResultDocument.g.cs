
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The document object echoing the original input (text and/or image)
    /// </summary>
    public sealed partial class CreateRerankResponseResultDocument
    {
        /// <summary>
        /// The image (URL or data URI) from the original document<br/>
        /// Example: https://example.com/image.png
        /// </summary>
        /// <example>https://example.com/image.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// The document text<br/>
        /// Example: Paris is the capital of France.
        /// </summary>
        /// <example>Paris is the capital of France.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRerankResponseResultDocument" /> class.
        /// </summary>
        /// <param name="image">
        /// The image (URL or data URI) from the original document<br/>
        /// Example: https://example.com/image.png
        /// </param>
        /// <param name="text">
        /// The document text<br/>
        /// Example: Paris is the capital of France.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRerankResponseResultDocument(
            string? image,
            string? text)
        {
            this.Image = image;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRerankResponseResultDocument" /> class.
        /// </summary>
        public CreateRerankResponseResultDocument()
        {
        }

    }
}