#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageModelsClient
    {
        /// <summary>
        /// Get total count of available models
        /// </summary>
        /// <param name="outputModalities"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ModelsCountResponse> ListModelsCountAsync(
            string? outputModalities = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}