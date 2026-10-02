#nullable enable

namespace OpenRouter
{
    public partial interface IOrganizationClient
    {
        /// <summary>
        /// Update organization settings<br/>
        /// Update the settings of the organization associated with the authenticated management key. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.UpdateOrganizationSettingsResponse> UpdateSettingsAsync(

            global::OpenRouter.UpdateOrganizationSettingsRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update organization settings<br/>
        /// Update the settings of the organization associated with the authenticated management key. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.UpdateOrganizationSettingsResponse>> UpdateSettingsAsResponseAsync(

            global::OpenRouter.UpdateOrganizationSettingsRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update organization settings<br/>
        /// Update the settings of the organization associated with the authenticated management key. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="isFilteredModelCatalogEnabled">
        /// When true, `GET /api/v1/models` called with one of the organization's API keys returns only the models that key can use (the `/api/v1/models/user` catalog), and the signed-in dashboard shows the same list. Anonymous requests always receive the public catalog.<br/>
        /// Example: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.UpdateOrganizationSettingsResponse> UpdateSettingsAsync(
            bool isFilteredModelCatalogEnabled,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}