
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: {"audio_url":{"url":"https://example.com/audio.mp3"},"type":"audio_url"}
    /// </summary>
    public sealed partial class ContentPartAudio
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.ContentPartAudioAudioUrl AudioUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.ContentPartAudioTypeJsonConverter))]
        public global::OpenRouter.ContentPartAudioType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentPartAudio" /> class.
        /// </summary>
        /// <param name="audioUrl"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentPartAudio(
            global::OpenRouter.ContentPartAudioAudioUrl audioUrl,
            global::OpenRouter.ContentPartAudioType type)
        {
            this.AudioUrl = audioUrl ?? throw new global::System.ArgumentNullException(nameof(audioUrl));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentPartAudio" /> class.
        /// </summary>
        public ContentPartAudio()
        {
        }

    }
}