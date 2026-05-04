#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageSttClient
    {
        /// <summary>
        /// Create transcription<br/>
        /// Transcribes audio into text. Accepts base64-encoded audio input and returns the transcribed text.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.STTResponse> CreateAudioTranscriptionsAsync(

            global::OpenRouter.STTRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create transcription<br/>
        /// Transcribes audio into text. Accepts base64-encoded audio input and returns the transcribed text.
        /// </summary>
        /// <param name="inputAudio">
        /// Base64-encoded audio to transcribe
        /// </param>
        /// <param name="language">
        /// ISO-639-1 language code (e.g., "en", "ja"). Auto-detected if omitted.
        /// </param>
        /// <param name="model">
        /// STT model identifier
        /// </param>
        /// <param name="provider">
        /// Provider-specific passthrough configuration
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature for transcription
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.STTResponse> CreateAudioTranscriptionsAsync(
            global::OpenRouter.STTInputAudio inputAudio,
            string model,
            string? language = default,
            global::OpenRouter.SttRequestProvider? provider = default,
            double? temperature = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}