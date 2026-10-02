
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Emitted when generation completes and the final image is available<br/>
    /// Example: {"b64_json":"\u003Cbase64-encoded-final-image\u003E","created":1748372400,"type":"image_generation.completed","usage":{"completion_tokens":4175,"cost":0.04,"prompt_tokens":0,"total_tokens":4175}}
    /// </summary>
    public sealed partial class ImageGenCompletedEvent
    {
        /// <summary>
        /// Base64-encoded final image data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("b64_json")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string B64Json { get; set; }

        /// <summary>
        /// Unix timestamp (seconds) when the image was generated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset Created { get; set; }

        /// <summary>
        /// Media type (MIME type) of the image, e.g. `image/png`, `image/jpeg`, `image/webp`, `image/svg+xml`. May be omitted if the format could not be determined.<br/>
        /// Example: image/png
        /// </summary>
        /// <example>image/png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        public string? MediaType { get; set; }

        /// <summary>
        /// The event type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ImageGenCompletedEventTypeJsonConverter))]
        public global::OpenRouter.ImageGenCompletedEventType Type { get; set; }

        /// <summary>
        /// Token and cost usage for the image generation request, when available<br/>
        /// Example: {"completion_tokens":4175,"cost":0.04,"prompt_tokens":0,"total_tokens":4175}
        /// </summary>
        /// <example>{"completion_tokens":4175,"cost":0.04,"prompt_tokens":0,"total_tokens":4175}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::OpenRouter.ImageGenerationUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenCompletedEvent" /> class.
        /// </summary>
        /// <param name="b64Json">
        /// Base64-encoded final image data
        /// </param>
        /// <param name="created">
        /// Unix timestamp (seconds) when the image was generated
        /// </param>
        /// <param name="mediaType">
        /// Media type (MIME type) of the image, e.g. `image/png`, `image/jpeg`, `image/webp`, `image/svg+xml`. May be omitted if the format could not be determined.<br/>
        /// Example: image/png
        /// </param>
        /// <param name="type">
        /// The event type
        /// </param>
        /// <param name="usage">
        /// Token and cost usage for the image generation request, when available<br/>
        /// Example: {"completion_tokens":4175,"cost":0.04,"prompt_tokens":0,"total_tokens":4175}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenCompletedEvent(
            string b64Json,
            global::System.DateTimeOffset created,
            string? mediaType,
            global::OpenRouter.ImageGenCompletedEventType type,
            global::OpenRouter.ImageGenerationUsage? usage)
        {
            this.B64Json = b64Json ?? throw new global::System.ArgumentNullException(nameof(b64Json));
            this.Created = created;
            this.MediaType = mediaType;
            this.Type = type;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenCompletedEvent" /> class.
        /// </summary>
        public ImageGenCompletedEvent()
        {
        }

    }
}