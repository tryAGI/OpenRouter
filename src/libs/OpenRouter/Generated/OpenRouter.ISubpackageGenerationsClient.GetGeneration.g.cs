#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageGenerationsClient
    {
        /// <summary>
        /// Get request &amp; usage metadata for a generation
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.GenerationsGetGenerationResponse200> GetGenerationAsync(
            string id,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}