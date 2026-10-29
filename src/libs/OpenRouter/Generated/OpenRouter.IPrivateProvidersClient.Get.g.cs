#nullable enable

namespace OpenRouter
{
    public partial interface IPrivateProvidersClient
    {
        /// <summary>
        /// Get a private provider<br/>
        /// Get one of the organization’s private providers by slug. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="slug">
        /// Example: acme
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.GetPrivateProviderResponse> GetAsync(
            string slug,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a private provider<br/>
        /// Get one of the organization’s private providers by slug. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="slug">
        /// Example: acme
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.GetPrivateProviderResponse>> GetAsResponseAsync(
            string slug,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}