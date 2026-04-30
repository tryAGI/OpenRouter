
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Base64-encoded audio to transcribe
    /// </summary>
    public sealed partial class STTInputAudio
    {
        /// <summary>
        /// Base64-encoded audio data (raw bytes, not a data URI)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// Audio format (e.g., wav, mp3, flac, m4a, ogg, webm, aac). Supported formats vary by provider.
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
        /// Initializes a new instance of the <see cref="STTInputAudio" /> class.
        /// </summary>
        /// <param name="data">
        /// Base64-encoded audio data (raw bytes, not a data URI)
        /// </param>
        /// <param name="format">
        /// Audio format (e.g., wav, mp3, flac, m4a, ogg, webm, aac). Supported formats vary by provider.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTInputAudio(
            string data,
            string format)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Format = format ?? throw new global::System.ArgumentNullException(nameof(format));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTInputAudio" /> class.
        /// </summary>
        public STTInputAudio()
        {
        }
    }
}