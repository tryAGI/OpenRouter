
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant3TypeJsonConverter))]
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant3Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_search_citation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant3WebSearchCitation WebSearchCitation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant3" /> class.
        /// </summary>
        /// <param name="webSearchCitation"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant3(
            global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant3WebSearchCitation webSearchCitation,
            global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant3Type type)
        {
            this.Type = type;
            this.WebSearchCitation = webSearchCitation ?? throw new global::System.ArgumentNullException(nameof(webSearchCitation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant3" /> class.
        /// </summary>
        public BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant3()
        {
        }

    }
}