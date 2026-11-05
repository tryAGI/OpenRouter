
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A web source the provider used for this request. Applies to the whole request, not to a specific answer.
    /// </summary>
    public sealed partial class DecisionsUrlCitationAnnotation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.DecisionsUrlCitationAnnotationTypeJsonConverter))]
        public global::OpenRouter.DecisionsUrlCitationAnnotationType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url_citation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.DecisionsUrlCitationAnnotationUrlCitation UrlCitation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionsUrlCitationAnnotation" /> class.
        /// </summary>
        /// <param name="urlCitation"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DecisionsUrlCitationAnnotation(
            global::OpenRouter.DecisionsUrlCitationAnnotationUrlCitation urlCitation,
            global::OpenRouter.DecisionsUrlCitationAnnotationType type)
        {
            this.Type = type;
            this.UrlCitation = urlCitation ?? throw new global::System.ArgumentNullException(nameof(urlCitation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecisionsUrlCitationAnnotation" /> class.
        /// </summary>
        public DecisionsUrlCitationAnnotation()
        {
        }

    }
}