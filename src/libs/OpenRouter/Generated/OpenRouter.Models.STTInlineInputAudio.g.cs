
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Inline base64 audio input for speech-to-text<br/>
    /// Example: {"data":"UklGRiQA...","format":"wav"}
    /// </summary>
    public sealed partial class STTInlineInputAudio
    {
        /// <summary>
        /// Base64-encoded audio data (raw bytes, not a data URI)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// Audio format (e.g., wav, mp3, flac, m4a, ogg, webm, aac). Supported formats vary by provider. "pcm" means headerless signed 16-bit little-endian mono audio at 16 kHz.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="STTInlineInputAudio" /> class.
        /// </summary>
        /// <param name="data">
        /// Base64-encoded audio data (raw bytes, not a data URI)
        /// </param>
        /// <param name="format">
        /// Audio format (e.g., wav, mp3, flac, m4a, ogg, webm, aac). Supported formats vary by provider. "pcm" means headerless signed 16-bit little-endian mono audio at 16 kHz.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTInlineInputAudio(
            string data,
            string format)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Format = format ?? throw new global::System.ArgumentNullException(nameof(format));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTInlineInputAudio" /> class.
        /// </summary>
        public STTInlineInputAudio()
        {
        }

    }
}