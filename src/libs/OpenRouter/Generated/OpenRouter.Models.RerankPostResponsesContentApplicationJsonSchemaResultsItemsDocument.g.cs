
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The document object echoing the original input (text and/or image)
    /// </summary>
    public sealed partial class RerankPostResponsesContentApplicationJsonSchemaResultsItemsDocument
    {
        /// <summary>
        /// The image (URL or data URI) from the original document
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
        /// Initializes a new instance of the <see cref="RerankPostResponsesContentApplicationJsonSchemaResultsItemsDocument" /> class.
        /// </summary>
        /// <param name="image">
        /// The image (URL or data URI) from the original document
        /// </param>
        /// <param name="text">
        /// The document text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankPostResponsesContentApplicationJsonSchemaResultsItemsDocument(
            string? image,
            string? text)
        {
            this.Image = image;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankPostResponsesContentApplicationJsonSchemaResultsItemsDocument" /> class.
        /// </summary>
        public RerankPostResponsesContentApplicationJsonSchemaResultsItemsDocument()
        {
        }

    }
}