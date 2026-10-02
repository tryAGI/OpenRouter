
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Reference audio input for stateless voice cloning. Up to three parts per request; the Nth audio part is addressable from `input` as `@AudioN` on providers that support multiple references.<br/>
    /// Example: {"input_audio":{"data":"data:audio/wav;base64,UklGRuQXDABXQVZF..."},"type":"input_audio"}
    /// </summary>
    public sealed partial class SpeechInputReferenceAudio
    {
        /// <summary>
        /// Reference audio input object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.SpeechInputReferenceAudioInput InputAudio { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.SpeechInputReferenceAudioTypeJsonConverter))]
        public global::OpenRouter.SpeechInputReferenceAudioType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechInputReferenceAudio" /> class.
        /// </summary>
        /// <param name="inputAudio">
        /// Reference audio input object
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechInputReferenceAudio(
            global::OpenRouter.SpeechInputReferenceAudioInput inputAudio,
            global::OpenRouter.SpeechInputReferenceAudioType type)
        {
            this.InputAudio = inputAudio ?? throw new global::System.ArgumentNullException(nameof(inputAudio));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechInputReferenceAudio" /> class.
        /// </summary>
        public SpeechInputReferenceAudio()
        {
        }

    }
}