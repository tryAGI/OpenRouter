#nullable enable

namespace OpenRouter
{
    public partial interface IPrivateEndpointsClient
    {
        /// <summary>
        /// Delete a private endpoint<br/>
        /// Delete a private endpoint and stop routing to it. Pass `draft_only=true` to refuse (409) when the endpoint has been activated. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// Stable identifier of the private endpoint.<br/>
        /// Example: 5b1c4c4e-7d0a-4a8e-9f3a-2d6c1b0e8a11
        /// </param>
        /// <param name="draftOnly">
        /// When `true`, only delete the endpoint if it is still a draft (409 otherwise).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.DeletePrivateEndpointResponse> DeleteAsync(
            global::System.Guid id,
            global::OpenRouter.DeletePrivateEndpointDraftOnly? draftOnly = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a private endpoint<br/>
        /// Delete a private endpoint and stop routing to it. Pass `draft_only=true` to refuse (409) when the endpoint has been activated. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// Stable identifier of the private endpoint.<br/>
        /// Example: 5b1c4c4e-7d0a-4a8e-9f3a-2d6c1b0e8a11
        /// </param>
        /// <param name="draftOnly">
        /// When `true`, only delete the endpoint if it is still a draft (409 otherwise).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.DeletePrivateEndpointResponse>> DeleteAsResponseAsync(
            global::System.Guid id,
            global::OpenRouter.DeletePrivateEndpointDraftOnly? draftOnly = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}