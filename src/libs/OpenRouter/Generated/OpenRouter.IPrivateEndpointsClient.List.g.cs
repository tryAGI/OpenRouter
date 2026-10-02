#nullable enable

namespace OpenRouter
{
    public partial interface IPrivateEndpointsClient
    {
        /// <summary>
        /// List private endpoints<br/>
        /// List the organization's private endpoints, including drafts. Requires the private endpoints entitlement. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ListPrivateEndpointsResponse> ListAsync(
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List private endpoints<br/>
        /// List the organization's private endpoints, including drafts. Requires the private endpoints entitlement. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ListPrivateEndpointsResponse>> ListAsResponseAsync(
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}