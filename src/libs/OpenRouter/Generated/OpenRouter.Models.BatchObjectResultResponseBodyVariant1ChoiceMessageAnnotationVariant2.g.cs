
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2TypeJsonConverter))]
        public global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url_citation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2UrlCitation UrlCitation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2" /> class.
        /// </summary>
        /// <param name="urlCitation"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2(
            global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2UrlCitation urlCitation,
            global::OpenRouter.BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2Type type)
        {
            this.Type = type;
            this.UrlCitation = urlCitation ?? throw new global::System.ArgumentNullException(nameof(urlCitation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2" /> class.
        /// </summary>
        public BatchObjectResultResponseBodyVariant1ChoiceMessageAnnotationVariant2()
        {
        }

    }
}