
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Emitted when a text chunk becomes available during streaming generation of text-based formats (e.g. SVG)<br/>
    /// Example: {"phase":"content","text":"\u003Csvg xmlns=\u0022http://www.w3.org/2000/svg\u0022\u003E","type":"image_generation.text_chunk"}
    /// </summary>
    public sealed partial class ImageGenTextChunkEvent
    {
        /// <summary>
        /// The generation phase this chunk belongs to. `content` is the renderable output; `reasoning` and `draft` are intermediate provider phases.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phase")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ImageGenTextChunkEventPhaseJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ImageGenTextChunkEventPhase Phase { get; set; }

        /// <summary>
        /// A text fragment of the image being generated (e.g. partial SVG markup)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The event type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ImageGenTextChunkEventTypeJsonConverter))]
        public global::OpenRouter.ImageGenTextChunkEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenTextChunkEvent" /> class.
        /// </summary>
        /// <param name="phase">
        /// The generation phase this chunk belongs to. `content` is the renderable output; `reasoning` and `draft` are intermediate provider phases.
        /// </param>
        /// <param name="text">
        /// A text fragment of the image being generated (e.g. partial SVG markup)
        /// </param>
        /// <param name="type">
        /// The event type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ImageGenTextChunkEvent(
            global::OpenRouter.ImageGenTextChunkEventPhase phase,
            string text,
            global::OpenRouter.ImageGenTextChunkEventType type)
        {
            this.Phase = phase;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenTextChunkEvent" /> class.
        /// </summary>
        public ImageGenTextChunkEvent()
        {
        }

    }
}