#nullable enable

namespace OpenRouter
{
    public partial interface ISttClient
    {
        /// <summary>
        /// Create transcription<br/>
        /// Transcribes audio into text. Accepts base64-encoded audio input as JSON, an OpenAI-style multipart/form-data file upload, or a URL the provider downloads directly, and returns the transcribed text.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.STTResponse> CreateTranscriptionAsync(

            global::OpenRouter.STTRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create transcription<br/>
        /// Transcribes audio into text. Accepts base64-encoded audio input as JSON, an OpenAI-style multipart/form-data file upload, or a URL the provider downloads directly, and returns the transcribed text.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.STTResponse>> CreateTranscriptionAsResponseAsync(

            global::OpenRouter.STTRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create transcription<br/>
        /// Transcribes audio into text. Accepts base64-encoded audio input as JSON, an OpenAI-style multipart/form-data file upload, or a URL the provider downloads directly, and returns the transcribed text.
        /// </summary>
        /// <param name="diarize">
        /// Label each word with the speaker who said it. Speaker labels are returned on the words array (speaker, speaker_label), so response_format must be "verbose_json" (a "json" request is rejected with a 400) and word timestamps are included even when timestamp_granularities omits "word". Only supported by some providers; the request is rejected with a 400 when the selected model cannot diarize. Providers may charge extra.<br/>
        /// Example: true
        /// </param>
        /// <param name="inputAudio">
        /// Audio to transcribe: inline base64 bytes, or a URL the provider downloads directly.
        /// </param>
        /// <param name="keyterms">
        /// Domain terms, names, or phrases to bias recognition toward. Only supported by some providers; the request is rejected with a 400 when the selected model cannot use keyterms. Providers may cap the number of terms or characters per term and may charge extra.<br/>
        /// Example: [OpenRouter, Scribe]
        /// </param>
        /// <param name="language">
        /// ISO-639-1 language code (e.g., "en", "ja"). Auto-detected if omitted.<br/>
        /// Example: en
        /// </param>
        /// <param name="model">
        /// STT model identifier<br/>
        /// Example: openai/whisper-large-v3
        /// </param>
        /// <param name="provider">
        /// Provider configuration: data policy routing preferences (`zdr`, `data_collection`) and provider-specific passthrough options
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.STTResponse> CreateTranscriptionAsync(
            global::OpenRouter.STTInputAudio inputAudio,
            string model,
            bool? diarize = default,
            global::System.Collections.Generic.IList<string>? keyterms = default,
            string? language = default,
            global::OpenRouter.STTRequestProvider? provider = default,
            global::OpenRouter.STTRequestResponseFormat? responseFormat = default,
            string? sessionId = default,
            double? temperature = default,
            global::System.Collections.Generic.IList<global::OpenRouter.STTTimestampGranularity>? timestampGranularities = default,
            global::OpenRouter.TraceConfig? trace = default,
            string? user = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}