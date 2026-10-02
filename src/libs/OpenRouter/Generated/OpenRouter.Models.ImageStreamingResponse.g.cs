
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"data":{"b64_json":"\u003Cbase64-encoded-partial-image\u003E","partial_image_index":0,"type":"image_generation.partial_image"}}
    /// </summary>
    public sealed partial class ImageStreamingResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.AnyOfJsonConverter<global::OpenRouter.ImageGenPartialImageEvent, global::OpenRouter.ImageGenTextChunkEvent, global::OpenRouter.ImageGenCompletedEvent, global::OpenRouter.ImageGenStreamErrorEvent>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.AnyOf<global::OpenRouter.ImageGenPartialImageEvent, global::OpenRouter.ImageGenTextChunkEvent, global::OpenRouter.ImageGenCompletedEvent, global::OpenRouter.ImageGenStreamErrorEvent> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageStreamingResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageStreamingResponse(
            global::OpenRouter.AnyOf<global::OpenRouter.ImageGenPartialImageEvent, global::OpenRouter.ImageGenTextChunkEvent, global::OpenRouter.ImageGenCompletedEvent, global::OpenRouter.ImageGenStreamErrorEvent> data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageStreamingResponse" /> class.
        /// </summary>
        public ImageStreamingResponse()
        {
        }

    }
}