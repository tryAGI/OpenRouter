
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Text-to-speech request input
    /// </summary>
    public sealed partial class SpeechRequest
    {
        /// <summary>
        /// Text to synthesize
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// TTS model identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Provider-specific passthrough configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public global::OpenRouter.SpeechRequestProvider? Provider { get; set; }

        /// <summary>
        /// Audio output format<br/>
        /// Default Value: pcm
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.SpeechRequestResponseFormatJsonConverter))]
        public global::OpenRouter.SpeechRequestResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// Playback speed multiplier. Only used by models that support it (e.g. OpenAI TTS). Ignored by other providers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Voice identifier (provider-specific).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Text to synthesize
        /// </param>
        /// <param name="model">
        /// TTS model identifier
        /// </param>
        /// <param name="voice">
        /// Voice identifier (provider-specific).
        /// </param>
        /// <param name="provider">
        /// Provider-specific passthrough configuration
        /// </param>
        /// <param name="responseFormat">
        /// Audio output format<br/>
        /// Default Value: pcm
        /// </param>
        /// <param name="speed">
        /// Playback speed multiplier. Only used by models that support it (e.g. OpenAI TTS). Ignored by other providers.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechRequest(
            string input,
            string model,
            string voice,
            global::OpenRouter.SpeechRequestProvider? provider,
            global::OpenRouter.SpeechRequestResponseFormat? responseFormat,
            double? speed)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Provider = provider;
            this.ResponseFormat = responseFormat;
            this.Speed = speed;
            this.Voice = voice ?? throw new global::System.ArgumentNullException(nameof(voice));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechRequest" /> class.
        /// </summary>
        public SpeechRequest()
        {
        }
    }
}