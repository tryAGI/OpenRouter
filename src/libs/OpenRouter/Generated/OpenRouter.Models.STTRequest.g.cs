
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Speech-to-text request input. Accepts a JSON body with input_audio containing base64-encoded audio.
    /// </summary>
    public sealed partial class STTRequest
    {
        /// <summary>
        /// Base64-encoded audio to transcribe
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.STTInputAudio InputAudio { get; set; }

        /// <summary>
        /// ISO-639-1 language code (e.g., "en", "ja"). Auto-detected if omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// STT model identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Provider-specific passthrough configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public global::OpenRouter.SttRequestProvider? Provider { get; set; }

        /// <summary>
        /// Sampling temperature for transcription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="STTRequest" /> class.
        /// </summary>
        /// <param name="inputAudio">
        /// Base64-encoded audio to transcribe
        /// </param>
        /// <param name="model">
        /// STT model identifier
        /// </param>
        /// <param name="language">
        /// ISO-639-1 language code (e.g., "en", "ja"). Auto-detected if omitted.
        /// </param>
        /// <param name="provider">
        /// Provider-specific passthrough configuration
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature for transcription
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTRequest(
            global::OpenRouter.STTInputAudio inputAudio,
            string model,
            string? language,
            global::OpenRouter.SttRequestProvider? provider,
            double? temperature)
        {
            this.InputAudio = inputAudio ?? throw new global::System.ArgumentNullException(nameof(inputAudio));
            this.Language = language;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Provider = provider;
            this.Temperature = temperature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTRequest" /> class.
        /// </summary>
        public STTRequest()
        {
        }

    }
}