
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Text-to-speech request input<br/>
    /// Example: {"input":"Hello world","model":"mistralai/voxtral-mini-tts-2603","response_format":"pcm","speed":1,"voice":"en_paul_neutral"}
    /// </summary>
    public sealed partial class SpeechRequest
    {
        /// <summary>
        /// Text to synthesize, or a list of turns for multi-speaker input. Each turn has its own text, voice, and instructions. Multi-speaker input is currently supported by Gemini TTS models only.<br/>
        /// Example: Hello world
        /// </summary>
        /// <example>Hello world</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.SpeechInputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.SpeechInput Input { get; set; }

        /// <summary>
        /// Reference content for stateless voice cloning or voice design. Audio mode: one to three `input_audio` parts, each optionally paired with a `text` part carrying its transcript (a single clip accepts its transcript before or after it; with multiple clips each transcript immediately follows its clip); only routed to endpoints that support voice cloning (and multiple references when more than one part is sent). Image mode: exactly one `image_url` part; only routed to endpoints that support image references. The two modes cannot be mixed. An empty array is treated as no reference.<br/>
        /// Example: [{"input_audio":{"data":"data:audio/wav;base64,UklGRuQXDABXQVZF..."},"type":"input_audio"}, {"text":"I used to rule the world.","type":"text"}]
        /// </summary>
        /// <example>[{"input_audio":{"data":"data:audio/wav;base64,UklGRuQXDABXQVZF..."},"type":"input_audio"}, {"text":"I used to rule the world.","type":"text"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_references")]
        public global::System.Collections.Generic.IList<global::OpenRouter.SpeechInputReference>? InputReferences { get; set; }

        /// <summary>
        /// Delivery instructions for the whole request, such as tone, pacing, or emotion. Supported by OpenAI gpt-4o-mini-tts and Gemini TTS models. Ignored by other providers.<br/>
        /// Example: Speak in a warm and friendly tone.
        /// </summary>
        /// <example>Speak in a warm and friendly tone.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// TTS model identifier<br/>
        /// Example: mistralai/voxtral-mini-tts-2603
        /// </summary>
        /// <example>mistralai/voxtral-mini-tts-2603</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Provider configuration: data policy routing preferences (`zdr`, `data_collection`) and provider-specific passthrough options
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public global::OpenRouter.SpeechRequestProvider? Provider { get; set; }

        /// <summary>
        /// Audio output format<br/>
        /// Default Value: pcm<br/>
        /// Example: pcm
        /// </summary>
        /// <example>pcm</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.SpeechRequestResponseFormatJsonConverter))]
        public global::OpenRouter.SpeechRequestResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow). Used for observability grouping in Broadcast and private logging; never sent to the provider. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.<br/>
        /// Example: session-1234
        /// </summary>
        /// <example>session-1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Playback speed multiplier. Honored by models that support it (e.g. OpenAI TTS). Other providers either ignore it or return a 400 for a non-default value when the model has no speed control.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        public double? Speed { get; set; }

        /// <summary>
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.<br/>
        /// Example: {"trace_id":"trace-abc123","trace_name":"my-app-trace"}
        /// </summary>
        /// <example>{"trace_id":"trace-abc123","trace_name":"my-app-trace"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace")]
        public global::OpenRouter.TraceConfig? Trace { get; set; }

        /// <summary>
        /// A unique identifier representing your end-user. Forwarded to Broadcast and private logging as the end-user id; never sent to the provider.<br/>
        /// Example: user-1234
        /// </summary>
        /// <example>user-1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// Voice identifier (provider-specific).<br/>
        /// Example: en_paul_neutral
        /// </summary>
        /// <example>en_paul_neutral</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        public string? Voice { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Text to synthesize, or a list of turns for multi-speaker input. Each turn has its own text, voice, and instructions. Multi-speaker input is currently supported by Gemini TTS models only.<br/>
        /// Example: Hello world
        /// </param>
        /// <param name="model">
        /// TTS model identifier<br/>
        /// Example: mistralai/voxtral-mini-tts-2603
        /// </param>
        /// <param name="inputReferences">
        /// Reference content for stateless voice cloning or voice design. Audio mode: one to three `input_audio` parts, each optionally paired with a `text` part carrying its transcript (a single clip accepts its transcript before or after it; with multiple clips each transcript immediately follows its clip); only routed to endpoints that support voice cloning (and multiple references when more than one part is sent). Image mode: exactly one `image_url` part; only routed to endpoints that support image references. The two modes cannot be mixed. An empty array is treated as no reference.<br/>
        /// Example: [{"input_audio":{"data":"data:audio/wav;base64,UklGRuQXDABXQVZF..."},"type":"input_audio"}, {"text":"I used to rule the world.","type":"text"}]
        /// </param>
        /// <param name="instructions">
        /// Delivery instructions for the whole request, such as tone, pacing, or emotion. Supported by OpenAI gpt-4o-mini-tts and Gemini TTS models. Ignored by other providers.<br/>
        /// Example: Speak in a warm and friendly tone.
        /// </param>
        /// <param name="provider">
        /// Provider configuration: data policy routing preferences (`zdr`, `data_collection`) and provider-specific passthrough options
        /// </param>
        /// <param name="responseFormat">
        /// Audio output format<br/>
        /// Default Value: pcm<br/>
        /// Example: pcm
        /// </param>
        /// <param name="sessionId">
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow). Used for observability grouping in Broadcast and private logging; never sent to the provider. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.<br/>
        /// Example: session-1234
        /// </param>
        /// <param name="speed">
        /// Playback speed multiplier. Honored by models that support it (e.g. OpenAI TTS). Other providers either ignore it or return a 400 for a non-default value when the model has no speed control.<br/>
        /// Example: 1
        /// </param>
        /// <param name="trace">
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.<br/>
        /// Example: {"trace_id":"trace-abc123","trace_name":"my-app-trace"}
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user. Forwarded to Broadcast and private logging as the end-user id; never sent to the provider.<br/>
        /// Example: user-1234
        /// </param>
        /// <param name="voice">
        /// Voice identifier (provider-specific).<br/>
        /// Example: en_paul_neutral
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechRequest(
            global::OpenRouter.SpeechInput input,
            string model,
            global::System.Collections.Generic.IList<global::OpenRouter.SpeechInputReference>? inputReferences,
            string? instructions,
            global::OpenRouter.SpeechRequestProvider? provider,
            global::OpenRouter.SpeechRequestResponseFormat? responseFormat,
            string? sessionId,
            double? speed,
            global::OpenRouter.TraceConfig? trace,
            string? user,
            string? voice)
        {
            this.Input = input;
            this.InputReferences = inputReferences;
            this.Instructions = instructions;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Provider = provider;
            this.ResponseFormat = responseFormat;
            this.SessionId = sessionId;
            this.Speed = speed;
            this.Trace = trace;
            this.User = user;
            this.Voice = voice;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechRequest" /> class.
        /// </summary>
        public SpeechRequest()
        {
        }

    }
}