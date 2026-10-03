
#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Speech-to-text request input. Accepts a JSON body with input_audio containing base64-encoded audio or a URL the provider downloads.<br/>
    /// Example: {"input_audio":{"data":"UklGRiQA...","format":"wav"},"language":"en","model":"openai/whisper-large-v3"}
    /// </summary>
    public sealed partial class STTRequest
    {
        /// <summary>
        /// Label each word with the speaker who said it. Speaker labels are returned on the words array (speaker, speaker_label), so response_format must be "verbose_json" (a "json" request is rejected with a 400) and word timestamps are included even when timestamp_granularities omits "word". Only supported by some providers; the request is rejected with a 400 when the selected model cannot diarize. Providers may charge extra.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("diarize")]
        public bool? Diarize { get; set; }

        /// <summary>
        /// Audio to transcribe: inline base64 bytes, or a URL the provider downloads directly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.STTInputAudioJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenRouter.STTInputAudio InputAudio { get; set; }

        /// <summary>
        /// Domain terms, names, or phrases to bias recognition toward. Only supported by some providers; the request is rejected with a 400 when the selected model cannot use keyterms. Providers may cap the number of terms or characters per term and may charge extra.<br/>
        /// Example: [OpenRouter, Scribe]
        /// </summary>
        /// <example>[OpenRouter, Scribe]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyterms")]
        public global::System.Collections.Generic.IList<string>? Keyterms { get; set; }

        /// <summary>
        /// ISO-639-1 language code (e.g., "en", "ja"). Auto-detected if omitted.<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// STT model identifier<br/>
        /// Example: openai/whisper-large-v3
        /// </summary>
        /// <example>openai/whisper-large-v3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Provider-specific passthrough configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public global::OpenRouter.STTRequestProvider? Provider { get; set; }

        /// <summary>
        /// Output format. "json" (default) returns { text, usage }. "verbose_json" additionally returns task, language, duration, and segment-level timestamps; only supported by OpenAI-compatible providers.<br/>
        /// Example: json
        /// </summary>
        /// <example>json</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenRouter.JsonConverters.STTRequestResponseFormatJsonConverter))]
        public global::OpenRouter.STTRequestResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow). Used for observability grouping in Broadcast and private logging; never sent to the provider. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.<br/>
        /// Example: session-1234
        /// </summary>
        /// <example>session-1234</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Sampling temperature for transcription<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Timestamp detail levels to include when response_format is "verbose_json". "segment" returns segment-level timestamps; "word" additionally returns word-level timestamps in the words array. Ignored unless response_format is "verbose_json".<br/>
        /// Example: [segment]
        /// </summary>
        /// <example>[segment]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp_granularities")]
        public global::System.Collections.Generic.IList<global::OpenRouter.STTTimestampGranularity>? TimestampGranularities { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="STTRequest" /> class.
        /// </summary>
        /// <param name="inputAudio">
        /// Audio to transcribe: inline base64 bytes, or a URL the provider downloads directly.
        /// </param>
        /// <param name="model">
        /// STT model identifier<br/>
        /// Example: openai/whisper-large-v3
        /// </param>
        /// <param name="diarize">
        /// Label each word with the speaker who said it. Speaker labels are returned on the words array (speaker, speaker_label), so response_format must be "verbose_json" (a "json" request is rejected with a 400) and word timestamps are included even when timestamp_granularities omits "word". Only supported by some providers; the request is rejected with a 400 when the selected model cannot diarize. Providers may charge extra.<br/>
        /// Example: true
        /// </param>
        /// <param name="keyterms">
        /// Domain terms, names, or phrases to bias recognition toward. Only supported by some providers; the request is rejected with a 400 when the selected model cannot use keyterms. Providers may cap the number of terms or characters per term and may charge extra.<br/>
        /// Example: [OpenRouter, Scribe]
        /// </param>
        /// <param name="language">
        /// ISO-639-1 language code (e.g., "en", "ja"). Auto-detected if omitted.<br/>
        /// Example: en
        /// </param>
        /// <param name="provider">
        /// Provider-specific passthrough configuration
        /// </param>
        /// <param name="responseFormat">
        /// Output format. "json" (default) returns { text, usage }. "verbose_json" additionally returns task, language, duration, and segment-level timestamps; only supported by OpenAI-compatible providers.<br/>
        /// Example: json
        /// </param>
        /// <param name="sessionId">
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow). Used for observability grouping in Broadcast and private logging; never sent to the provider. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.<br/>
        /// Example: session-1234
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature for transcription<br/>
        /// Example: 0
        /// </param>
        /// <param name="timestampGranularities">
        /// Timestamp detail levels to include when response_format is "verbose_json". "segment" returns segment-level timestamps; "word" additionally returns word-level timestamps in the words array. Ignored unless response_format is "verbose_json".<br/>
        /// Example: [segment]
        /// </param>
        /// <param name="trace">
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.<br/>
        /// Example: {"trace_id":"trace-abc123","trace_name":"my-app-trace"}
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user. Forwarded to Broadcast and private logging as the end-user id; never sent to the provider.<br/>
        /// Example: user-1234
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public STTRequest(
            global::OpenRouter.STTInputAudio inputAudio,
            string model,
            bool? diarize,
            global::System.Collections.Generic.IList<string>? keyterms,
            string? language,
            global::OpenRouter.STTRequestProvider? provider,
            global::OpenRouter.STTRequestResponseFormat? responseFormat,
            string? sessionId,
            double? temperature,
            global::System.Collections.Generic.IList<global::OpenRouter.STTTimestampGranularity>? timestampGranularities,
            global::OpenRouter.TraceConfig? trace,
            string? user)
        {
            this.Diarize = diarize;
            this.InputAudio = inputAudio;
            this.Keyterms = keyterms;
            this.Language = language;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Provider = provider;
            this.ResponseFormat = responseFormat;
            this.SessionId = sessionId;
            this.Temperature = temperature;
            this.TimestampGranularities = timestampGranularities;
            this.Trace = trace;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="STTRequest" /> class.
        /// </summary>
        public STTRequest()
        {
        }

    }
}