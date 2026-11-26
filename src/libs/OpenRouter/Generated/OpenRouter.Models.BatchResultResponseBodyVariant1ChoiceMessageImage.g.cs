
#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BatchResultResponseBodyVariant1ChoiceMessageImage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.BatchResultResponseBodyVariant1ChoiceMessageImageImageUrl ImageUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.BatchResultResponseBodyVariant1ChoiceMessageImageTypeJsonConverter))]
        public global::OpenRouter.BatchResultResponseBodyVariant1ChoiceMessageImageType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchResultResponseBodyVariant1ChoiceMessageImage" /> class.
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchResultResponseBodyVariant1ChoiceMessageImage(
            global::OpenRouter.BatchResultResponseBodyVariant1ChoiceMessageImageImageUrl imageUrl,
            global::OpenRouter.BatchResultResponseBodyVariant1ChoiceMessageImageType type)
        {
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchResultResponseBodyVariant1ChoiceMessageImage" /> class.
        /// </summary>
        public BatchResultResponseBodyVariant1ChoiceMessageImage()
        {
        }

    }
}