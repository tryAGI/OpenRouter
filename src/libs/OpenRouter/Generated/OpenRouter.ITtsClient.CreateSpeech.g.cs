#nullable enable

namespace OpenRouter
{
    public partial interface ITtsClient
    {
        /// <summary>
        /// Create speech<br/>
        /// Synthesizes audio from the input text. Returns a raw audio bytestream in the requested format (e.g. mp3, pcm, wav).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateSpeechAsync(

            global::OpenRouter.SpeechRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create speech<br/>
        /// Synthesizes audio from the input text. Returns a raw audio bytestream in the requested format (e.g. mp3, pcm, wav).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> CreateSpeechAsStreamAsync(

            global::OpenRouter.SpeechRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create speech<br/>
        /// Synthesizes audio from the input text. Returns a raw audio bytestream in the requested format (e.g. mp3, pcm, wav).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<byte[]>> CreateSpeechAsResponseAsync(

            global::OpenRouter.SpeechRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create speech<br/>
        /// Synthesizes audio from the input text. Returns a raw audio bytestream in the requested format (e.g. mp3, pcm, wav).
        /// </summary>
        /// <param name="input">
        /// Text to synthesize, or a list of turns for multi-speaker input. Each turn has its own text, voice, and instructions. Multi-speaker input is currently supported by Gemini TTS models only.<br/>
        /// Example: Hello world
        /// </param>
        /// <param name="inputReferences">
        /// Reference content for stateless voice cloning or voice design. Audio mode: one to three `input_audio` parts, each optionally paired with a `text` part carrying its transcript (a single clip accepts its transcript before or after it; with multiple clips each transcript immediately follows its clip); only routed to endpoints that support voice cloning (and multiple references when more than one part is sent). Image mode: exactly one `image_url` part; only routed to endpoints that support image references. The two modes cannot be mixed. An empty array is treated as no reference.<br/>
        /// Example: [{"input_audio":{"data":"data:audio/wav;base64,UklGRuQXDABXQVZF..."},"type":"input_audio"}, {"text":"I used to rule the world.","type":"text"}]
        /// </param>
        /// <param name="instructions">
        /// Delivery instructions for the whole request, such as tone, pacing, or emotion. Supported by OpenAI gpt-4o-mini-tts and Gemini TTS models. Ignored by other providers.<br/>
        /// Example: Speak in a warm and friendly tone.
        /// </param>
        /// <param name="model">
        /// TTS model identifier<br/>
        /// Example: mistralai/voxtral-mini-tts-2603
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateSpeechAsync(
            global::OpenRouter.SpeechInput input,
            string model,
            global::System.Collections.Generic.IList<global::OpenRouter.SpeechInputReference>? inputReferences = default,
            string? instructions = default,
            global::OpenRouter.SpeechRequestProvider? provider = default,
            global::OpenRouter.SpeechRequestResponseFormat? responseFormat = default,
            string? sessionId = default,
            double? speed = default,
            global::OpenRouter.TraceConfig? trace = default,
            string? user = default,
            string? voice = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}