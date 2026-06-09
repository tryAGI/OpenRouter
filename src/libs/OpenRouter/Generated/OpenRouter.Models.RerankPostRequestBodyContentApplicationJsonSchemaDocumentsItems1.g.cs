
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A structured document with optional text and/or image content. At least one of `text` or `image` must be provided.
    /// </summary>
    public sealed partial class RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1
    {
        /// <summary>
        /// An image associated with the document, as a remote URL (http/https) or a base64-encoded data URI (data:image/...).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// The document text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1" /> class.
        /// </summary>
        /// <param name="image">
        /// An image associated with the document, as a remote URL (http/https) or a base64-encoded data URI (data:image/...).
        /// </param>
        /// <param name="text">
        /// The document text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1(
            string? image,
            string? text)
        {
            this.Image = image;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1" /> class.
        /// </summary>
        public RerankPostRequestBodyContentApplicationJsonSchemaDocumentsItems1()
        {
        }

    }
}