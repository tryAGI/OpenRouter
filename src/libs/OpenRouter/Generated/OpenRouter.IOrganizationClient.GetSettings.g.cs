#nullable enable

namespace OpenRouter
{
    public partial interface IOrganizationClient
    {
        /// <summary>
        /// Get organization settings<br/>
        /// Get the settings of the organization associated with the authenticated management key. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.GetOrganizationSettingsResponse> GetSettingsAsync(
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get organization settings<br/>
        /// Get the settings of the organization associated with the authenticated management key. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.GetOrganizationSettingsResponse>> GetSettingsAsResponseAsync(
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}