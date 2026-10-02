
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Emitted when streaming generation fails after the SSE response starts<br/>
    /// Example: {"error":{"code":"upstream_error","message":"The upstream provider returned an error","param":null,"type":"provider_error"},"type":"error"}
    /// </summary>
    public sealed partial class ImageGenStreamErrorEvent
    {
        /// <summary>
        /// Provider error details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ImageGenStreamErrorEventError Error { get; set; }

        /// <summary>
        /// The event type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ImageGenStreamErrorEventTypeJsonConverter))]
        public global::OpenRouter.ImageGenStreamErrorEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenStreamErrorEvent" /> class.
        /// </summary>
        /// <param name="error">
        /// Provider error details
        /// </param>
        /// <param name="type">
        /// The event type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenStreamErrorEvent(
            global::OpenRouter.ImageGenStreamErrorEventError error,
            global::OpenRouter.ImageGenStreamErrorEventType type)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenStreamErrorEvent" /> class.
        /// </summary>
        public ImageGenStreamErrorEvent()
        {
        }

    }
}