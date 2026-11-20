
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// List of text-to-speech models, each with its endpoints.<br/>
    /// Example: {"data":[{"created":1742428800,"description":"Text-to-speech model with steerable delivery.","endpoints":[{"input_modalities":[{"type":"text"}],"output_modalities":[{"supported_parameters":{"instructions":{"type":"unknown"},"response_format":{"type":"enum","values":["mp3","pcm"]},"speed":{"max":4,"min":0.25,"type":"range"},"voice":{"type":"enum","values":["alloy","coral"]}},"type":"speech"}],"provider_name":"OpenAI","provider_slug":"openai"}],"id":"openai/gpt-4o-mini-tts","input_modalities":[{"type":"text"}],"name":"OpenAI: GPT-4o mini TTS","output_modalities":[{"supported_parameters":{"instructions":{"type":"unknown"},"response_format":{"type":"enum","values":["mp3","pcm"]},"speed":{"max":4,"min":0.25,"type":"range"},"voice":{"type":"enum","values":["alloy","coral"]}},"type":"speech"}]}]}
    /// </summary>
    public sealed partial class SpeechModelsListResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.SpeechModelResponse> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechModelsListResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechModelsListResponse(
            global::System.Collections.Generic.IList<global::OpenRouter.SpeechModelResponse> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechModelsListResponse" /> class.
        /// </summary>
        public SpeechModelsListResponse()
        {
        }

    }
}