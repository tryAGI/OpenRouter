
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Reference audio input object
    /// </summary>
    public sealed partial class SpeechInputReferenceAudioInput
    {
        /// <summary>
        /// Base64-encoded reference audio (optionally a data URI). Supported audio formats are provider-specific. Limited to 20 MiB of base64 (15 MiB of decoded audio). Exactly one of `data` or `url` is required.<br/>
        /// Example: data:audio/wav;base64,UklGRuQXDABXQVZF...
        /// </summary>
        /// <example>data:audio/wav;base64,UklGRuQXDABXQVZF...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public string? Data { get; set; }

        /// <summary>
        /// Audio format of the reference audio (e.g., wav, mp3). Optional; most providers detect the format from the audio bytes.<br/>
        /// Example: wav
        /// </summary>
        /// <example>wav</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public string? Format { get; set; }

        /// <summary>
        /// Public http(s) URL of the reference audio. OpenRouter downloads it (15 MiB max) and forwards the bytes, never the URL. Exactly one of `data` or `url` is required.<br/>
        /// Example: https://example.com/reference.wav
        /// </summary>
        /// <example>https://example.com/reference.wav</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechInputReferenceAudioInput" /> class.
        /// </summary>
        /// <param name="data">
        /// Base64-encoded reference audio (optionally a data URI). Supported audio formats are provider-specific. Limited to 20 MiB of base64 (15 MiB of decoded audio). Exactly one of `data` or `url` is required.<br/>
        /// Example: data:audio/wav;base64,UklGRuQXDABXQVZF...
        /// </param>
        /// <param name="format">
        /// Audio format of the reference audio (e.g., wav, mp3). Optional; most providers detect the format from the audio bytes.<br/>
        /// Example: wav
        /// </param>
        /// <param name="url">
        /// Public http(s) URL of the reference audio. OpenRouter downloads it (15 MiB max) and forwards the bytes, never the URL. Exactly one of `data` or `url` is required.<br/>
        /// Example: https://example.com/reference.wav
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechInputReferenceAudioInput(
            string? data,
            string? format,
            string? url)
        {
            this.Data = data;
            this.Format = format;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechInputReferenceAudioInput" /> class.
        /// </summary>
        public SpeechInputReferenceAudioInput()
        {
        }

    }
}