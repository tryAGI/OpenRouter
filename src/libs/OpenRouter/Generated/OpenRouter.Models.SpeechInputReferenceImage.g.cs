
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Reference image describing the desired voice. Cannot be combined with `input_audio` parts. Only routed to endpoints that support image references.<br/>
    /// Example: {"image_url":{"url":"data:image/png;base64,iVBORw0KGgo..."},"type":"image_url"}
    /// </summary>
    public sealed partial class SpeechInputReferenceImage
    {
        /// <summary>
        /// Reference image input object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.SpeechInputReferenceImageInput ImageUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.SpeechInputReferenceImageTypeJsonConverter))]
        public global::OpenRouter.SpeechInputReferenceImageType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechInputReferenceImage" /> class.
        /// </summary>
        /// <param name="imageUrl">
        /// Reference image input object
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechInputReferenceImage(
            global::OpenRouter.SpeechInputReferenceImageInput imageUrl,
            global::OpenRouter.SpeechInputReferenceImageType type)
        {
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechInputReferenceImage" /> class.
        /// </summary>
        public SpeechInputReferenceImage()
        {
        }

    }
}