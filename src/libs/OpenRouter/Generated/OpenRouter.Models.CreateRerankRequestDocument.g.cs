
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A structured document with optional text and/or image content. At least one of `text` or `image` must be provided.
    /// </summary>
    public sealed partial class CreateRerankRequestDocument
    {
        /// <summary>
        /// An image associated with the document, as a remote URL (http/https) or a base64-encoded data URI (data:image/...).<br/>
        /// Example: https://upload.wikimedia.org/wikipedia/commons/thumb/8/8b/Phytogenic.png
        /// </summary>
        /// <example>https://upload.wikimedia.org/wikipedia/commons/thumb/8/8b/Phytogenic.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// The document text<br/>
        /// Example: AI enables robots to perceive, plan, and act autonomously.
        /// </summary>
        /// <example>AI enables robots to perceive, plan, and act autonomously.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRerankRequestDocument" /> class.
        /// </summary>
        /// <param name="image">
        /// An image associated with the document, as a remote URL (http/https) or a base64-encoded data URI (data:image/...).<br/>
        /// Example: https://upload.wikimedia.org/wikipedia/commons/thumb/8/8b/Phytogenic.png
        /// </param>
        /// <param name="text">
        /// The document text<br/>
        /// Example: AI enables robots to perceive, plan, and act autonomously.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRerankRequestDocument(
            string? image,
            string? text)
        {
            this.Image = image;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRerankRequestDocument" /> class.
        /// </summary>
        public CreateRerankRequestDocument()
        {
        }

    }
}