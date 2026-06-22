
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Image generation response
    /// </summary>
    public sealed partial class ImageGenerationResponse
    {
        /// <summary>
        /// Unix timestamp (seconds) when the image was generated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset Created { get; set; }

        /// <summary>
        /// Generated images
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.ImageGenerationResponseDataItems> Data { get; set; }

        /// <summary>
        /// Token and cost usage for the image generation request, when available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::OpenRouter.ImageGenerationUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationResponse" /> class.
        /// </summary>
        /// <param name="created">
        /// Unix timestamp (seconds) when the image was generated
        /// </param>
        /// <param name="data">
        /// Generated images
        /// </param>
        /// <param name="usage">
        /// Token and cost usage for the image generation request, when available
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenerationResponse(
            global::System.DateTimeOffset created,
            global::System.Collections.Generic.IList<global::OpenRouter.ImageGenerationResponseDataItems> data,
            global::OpenRouter.ImageGenerationUsage? usage)
        {
            this.Created = created;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationResponse" /> class.
        /// </summary>
        public ImageGenerationResponse()
        {
        }

    }
}