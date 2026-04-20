#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageTtsClient
    {
        /// <summary>
        /// Create speech<br/>
        /// Synthesizes audio from the input text
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateAudioSpeechAsync(

            global::OpenRouter.CreateAudioSpeechRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create speech<br/>
        /// Synthesizes audio from the input text
        /// </summary>
        /// <param name="input">
        /// Text to synthesize
        /// </param>
        /// <param name="model">
        /// TTS model identifier
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
        /// <param name="voice">
        /// Voice identifier (provider-specific).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateAudioSpeechAsync(
            string input,
            string model,
            string voice,
            global::OpenRouter.AudioSpeechPostRequestBodyContentApplicationJsonSchemaProvider? provider = default,
            global::OpenRouter.AudioSpeechPostRequestBodyContentApplicationJsonSchemaResponseFormat? responseFormat = default,
            double? speed = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}