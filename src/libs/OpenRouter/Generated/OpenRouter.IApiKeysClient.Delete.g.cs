#nullable enable

namespace OpenRouter
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// Delete an API key<br/>
        /// Delete an existing API key. Authenticate with a [management key](/docs/guides/overview/auth/management-api-keys).
        /// </summary>
        /// <param name="hash">
        /// The hash identifier of the API key to delete<br/>
        /// Example: f01d52606dc8f0a8303a7b5cc3fa07109c2e346cec7c0a16b40de462992ce943
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.DeleteKeysResponse> DeleteAsync(
            string hash,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an API key<br/>
        /// Delete an existing API key. Authenticate with a [management key](/docs/guides/overview/auth/management-api-keys).
        /// </summary>
        /// <param name="hash">
        /// The hash identifier of the API key to delete<br/>
        /// Example: f01d52606dc8f0a8303a7b5cc3fa07109c2e346cec7c0a16b40de462992ce943
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.DeleteKeysResponse>> DeleteAsResponseAsync(
            string hash,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}