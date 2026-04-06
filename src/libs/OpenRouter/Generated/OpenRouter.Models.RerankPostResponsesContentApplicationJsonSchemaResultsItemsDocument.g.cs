
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// The document object containing the original text
    /// </summary>
    public sealed partial class RerankPostResponsesContentApplicationJsonSchemaResultsItemsDocument
    {
        /// <summary>
        /// The document text
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
        /// Initializes a new instance of the <see cref="RerankPostResponsesContentApplicationJsonSchemaResultsItemsDocument" /> class.
        /// </summary>
        /// <param name="text">
        /// The document text
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankPostResponsesContentApplicationJsonSchemaResultsItemsDocument(
            string text)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankPostResponsesContentApplicationJsonSchemaResultsItemsDocument" /> class.
        /// </summary>
        public RerankPostResponsesContentApplicationJsonSchemaResultsItemsDocument()
        {
        }
    }
}