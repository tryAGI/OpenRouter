#nullable enable

namespace OpenRouter
{
    public partial interface ITtsClient
    {
        /// <summary>
        /// Get a text-to-speech model<br/>
        /// Returns a text-to-speech model with each endpoint's own inputs and speech output parameters.
        /// </summary>
        /// <param name="author">
        /// Model author/organization<br/>
        /// Example: openai
        /// </param>
        /// <param name="slug">
        /// Model slug<br/>
        /// Example: gpt-4o-mini-tts
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.SpeechModelResponse> GetModelAsync(
            string author,
            string slug,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a text-to-speech model<br/>
        /// Returns a text-to-speech model with each endpoint's own inputs and speech output parameters.
        /// </summary>
        /// <param name="author">
        /// Model author/organization<br/>
        /// Example: openai
        /// </param>
        /// <param name="slug">
        /// Model slug<br/>
        /// Example: gpt-4o-mini-tts
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.SpeechModelResponse>> GetModelAsResponseAsync(
            string author,
            string slug,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}