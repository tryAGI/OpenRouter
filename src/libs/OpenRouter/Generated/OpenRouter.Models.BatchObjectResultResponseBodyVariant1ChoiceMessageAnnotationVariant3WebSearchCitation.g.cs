
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant3WebSearchCitation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cited_text")]
        public string? CitedText { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_index")]
        public string? EncryptedIndex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant3WebSearchCitation" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="citedText"></param>
        /// <param name="encryptedIndex"></param>
        /// <param name="title"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant3WebSearchCitation(
            string url,
            string? citedText,
            string? encryptedIndex,
            string? title)
        {
            this.CitedText = citedText;
            this.EncryptedIndex = encryptedIndex;
            this.Title = title;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant3WebSearchCitation" /> class.
        /// </summary>
        public BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant3WebSearchCitation()
        {
        }

    }
}