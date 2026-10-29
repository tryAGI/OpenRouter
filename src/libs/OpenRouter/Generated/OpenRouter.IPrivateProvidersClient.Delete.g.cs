#nullable enable

namespace OpenRouter
{
    public partial interface IPrivateProvidersClient
    {
        /// <summary>
        /// Delete a private provider<br/>
        /// Delete a private provider. Refuses (409) while any private endpoint still runs under it. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="slug">
        /// Example: acme
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.DeletePrivateProviderResponse> DeleteAsync(
            string slug,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a private provider<br/>
        /// Delete a private provider. Refuses (409) while any private endpoint still runs under it. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="slug">
        /// Example: acme
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.DeletePrivateProviderResponse>> DeleteAsResponseAsync(
            string slug,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}