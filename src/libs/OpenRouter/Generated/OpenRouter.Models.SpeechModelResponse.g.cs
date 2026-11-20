
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A text-to-speech model. Its members are the envelope of its endpoints': enums are unioned and ranges widened, so a value inside a range may be accepted by no single endpoint. Each record in `endpoints` lists exactly what that endpoint accepts.<br/>
    /// Example: {"created":1742428800,"description":"Text-to-speech model with steerable delivery.","endpoints":[{"input_modalities":[{"type":"text"}],"output_modalities":[{"supported_parameters":{"instructions":{"type":"unknown"},"response_format":{"type":"enum","values":["mp3","pcm"]},"speed":{"max":4,"min":0.25,"type":"range"},"voice":{"type":"enum","values":["alloy","coral"]}},"type":"speech"}],"provider_name":"OpenAI","provider_slug":"openai"}],"id":"openai/gpt-4o-mini-tts","input_modalities":[{"type":"text"}],"name":"OpenAI: GPT-4o mini TTS","output_modalities":[{"supported_parameters":{"instructions":{"type":"unknown"},"response_format":{"type":"enum","values":["mp3","pcm"]},"speed":{"max":4,"min":0.25,"type":"range"},"voice":{"type":"enum","values":["alloy","coral"]}},"type":"speech"}]}
    /// </summary>
    public sealed partial class SpeechModelResponse
    {
        /// <summary>
        /// Unix timestamp (seconds) of when the model was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset Created { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Each endpoint serving the model, with exactly the inputs and parameters it accepts. Some endpoints route only after the caller accepts a provider requirement such as a self-attestation; until then, a request to them is rejected with a 403 that names the requirement.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoints")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.SpeechModelEndpoint> Endpoints { get; set; }

        /// <summary>
        /// Model slug<br/>
        /// Example: openai/gpt-4o-mini-tts
        /// </summary>
        /// <example>openai/gpt-4o-mini-tts</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_modalities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.SpeechInputModality> InputModalities { get; set; }

        /// <summary>
        /// Example: OpenAI: GPT-4o mini TTS
        /// </summary>
        /// <example>OpenAI: GPT-4o mini TTS</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_modalities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::OpenRouter.SpeechOutputModality> OutputModalities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechModelResponse" /> class.
        /// </summary>
        /// <param name="created">
        /// Unix timestamp (seconds) of when the model was created
        /// </param>
        /// <param name="description"></param>
        /// <param name="endpoints">
        /// Each endpoint serving the model, with exactly the inputs and parameters it accepts. Some endpoints route only after the caller accepts a provider requirement such as a self-attestation; until then, a request to them is rejected with a 403 that names the requirement.
        /// </param>
        /// <param name="id">
        /// Model slug<br/>
        /// Example: openai/gpt-4o-mini-tts
        /// </param>
        /// <param name="inputModalities"></param>
        /// <param name="name">
        /// Example: OpenAI: GPT-4o mini TTS
        /// </param>
        /// <param name="outputModalities"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechModelResponse(
            global::System.DateTimeOffset created,
            string description,
            global::System.Collections.Generic.IList<global::OpenRouter.SpeechModelEndpoint> endpoints,
            string id,
            global::System.Collections.Generic.IList<global::OpenRouter.SpeechInputModality> inputModalities,
            string name,
            global::System.Collections.Generic.IList<global::OpenRouter.SpeechOutputModality> outputModalities)
        {
            this.Created = created;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Endpoints = endpoints ?? throw new global::System.ArgumentNullException(nameof(endpoints));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.InputModalities = inputModalities ?? throw new global::System.ArgumentNullException(nameof(inputModalities));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OutputModalities = outputModalities ?? throw new global::System.ArgumentNullException(nameof(outputModalities));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechModelResponse" /> class.
        /// </summary>
        public SpeechModelResponse()
        {
        }

    }
}