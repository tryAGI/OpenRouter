#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageEmbeddingsClient
    {
        /// <summary>
        /// List all embeddings models<br/>
        /// Returns a list of all available embeddings models and their properties
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ModelsListResponse> ListEmbeddingsModelsAsync(
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}