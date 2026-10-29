#nullable enable

namespace OpenRouter
{
    public partial interface IPrivateProvidersClient
    {
        /// <summary>
        /// Update a private provider<br/>
        /// Update a private provider’s details or declared data policy. The name and slug cannot change. Refuses (409) a data-policy change while OpenRouter pins the declared policy on one of its endpoints. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="slug">
        /// Example: acme
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.UpdatePrivateProviderResponse> UpdateAsync(
            string slug,

            global::OpenRouter.UpdatePrivateProviderRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a private provider<br/>
        /// Update a private provider’s details or declared data policy. The name and slug cannot change. Refuses (409) a data-policy change while OpenRouter pins the declared policy on one of its endpoints. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="slug">
        /// Example: acme
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.UpdatePrivateProviderResponse>> UpdateAsResponseAsync(
            string slug,

            global::OpenRouter.UpdatePrivateProviderRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a private provider<br/>
        /// Update a private provider’s details or declared data policy. The name and slug cannot change. Refuses (409) a data-policy change while OpenRouter pins the declared policy on one of its endpoints. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="slug">
        /// Example: acme
        /// </param>
        /// <param name="baseUrl">
        /// HTTPS base URL of an OpenAI-compatible API, used by private endpoints under this provider that set no URL of their own. Without it, each endpoint must set its own. Private, internal, metadata and OpenRouter hosts are rejected.<br/>
        /// Example: https://inference.example.com/v1
        /// </param>
        /// <param name="dataPolicy"></param>
        /// <param name="displayName">
        /// Example: Acme
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.UpdatePrivateProviderResponse> UpdateAsync(
            string slug,
            string? baseUrl = default,
            global::OpenRouter.UpdatePrivateProviderRequestDataPolicy? dataPolicy = default,
            string? displayName = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}