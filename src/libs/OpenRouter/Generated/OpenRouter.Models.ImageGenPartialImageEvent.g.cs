
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Emitted when a partial image becomes available during streaming generation<br/>
    /// Example: {"b64_json":"\u003Cbase64-encoded-partial-image\u003E","partial_image_index":0,"type":"image_generation.partial_image"}
    /// </summary>
    public sealed partial class ImageGenPartialImageEvent
    {
        /// <summary>
        /// Base64-encoded partial image data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("b64_json")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string B64Json { get; set; }

        /// <summary>
        /// 0-based index indicating which partial image this is in the sequence
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partial_image_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PartialImageIndex { get; set; }

        /// <summary>
        /// The event type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ImageGenPartialImageEventTypeJsonConverter))]
        public global::OpenRouter.ImageGenPartialImageEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenPartialImageEvent" /> class.
        /// </summary>
        /// <param name="b64Json">
        /// Base64-encoded partial image data
        /// </param>
        /// <param name="partialImageIndex">
        /// 0-based index indicating which partial image this is in the sequence
        /// </param>
        /// <param name="type">
        /// The event type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenPartialImageEvent(
            string b64Json,
            int partialImageIndex,
            global::OpenRouter.ImageGenPartialImageEventType type)
        {
            this.B64Json = b64Json ?? throw new global::System.ArgumentNullException(nameof(b64Json));
            this.PartialImageIndex = partialImageIndex;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenPartialImageEvent" /> class.
        /// </summary>
        public ImageGenPartialImageEvent()
        {
        }

    }
}