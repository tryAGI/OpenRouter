
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"item_id":"ig_abc123","output_index":0,"partial_image_b64":"iVBORw0KGgo...","partial_image_index":0,"sequence_number":3,"type":"response.image_generation_call.partial_image"}
    /// </summary>
    public sealed partial class OpenAIResponsesImageGenCallPartialImage
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partial_image_b64")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PartialImageB64 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partial_image_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PartialImageIndex { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.OpenAIResponsesImageGenCallPartialImageTypeJsonConverter))]
        public global::OpenRouter.OpenAIResponsesImageGenCallPartialImageType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIResponsesImageGenCallPartialImage" /> class.
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="outputIndex"></param>
        /// <param name="partialImageB64"></param>
        /// <param name="partialImageIndex"></param>
        /// <param name="sequenceNumber"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIResponsesImageGenCallPartialImage(
            string itemId,
            int outputIndex,
            string partialImageB64,
            int partialImageIndex,
            int sequenceNumber,
            global::OpenRouter.OpenAIResponsesImageGenCallPartialImageType type)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.PartialImageB64 = partialImageB64 ?? throw new global::System.ArgumentNullException(nameof(partialImageB64));
            this.PartialImageIndex = partialImageIndex;
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIResponsesImageGenCallPartialImage" /> class.
        /// </summary>
        public OpenAIResponsesImageGenCallPartialImage()
        {
        }

    }
}