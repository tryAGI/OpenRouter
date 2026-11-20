#nullable enable

namespace OpenRouter
{
    public partial interface ITtsClient
    {
        /// <summary>
        /// List text-to-speech models<br/>
        /// Lists every text-to-speech model with the inputs it accepts and its speech output parameters, merged across its endpoints, plus each endpoint with its own.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.SpeechModelsListResponse> ListModelsAsync(
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List text-to-speech models<br/>
        /// Lists every text-to-speech model with the inputs it accepts and its speech output parameters, merged across its endpoints, plus each endpoint with its own.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.SpeechModelsListResponse>> ListModelsAsResponseAsync(
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}