#nullable enable

namespace OpenRouter
{
    public partial interface IPrivateEndpointsClient
    {
        /// <summary>
        /// Validate a draft private endpoint<br/>
        /// Send a live test request to the draft endpoint using the given workspace's BYOK credential for its provider. A passing validation is required before activation. Failed checks return 200 with `passed: false`. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// Stable identifier of the private endpoint.<br/>
        /// Example: 5b1c4c4e-7d0a-4a8e-9f3a-2d6c1b0e8a11
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.PrivateEndpointValidationResponse> ValidateAsync(
            global::System.Guid id,

            global::OpenRouter.ValidatePrivateEndpointRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate a draft private endpoint<br/>
        /// Send a live test request to the draft endpoint using the given workspace's BYOK credential for its provider. A passing validation is required before activation. Failed checks return 200 with `passed: false`. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// Stable identifier of the private endpoint.<br/>
        /// Example: 5b1c4c4e-7d0a-4a8e-9f3a-2d6c1b0e8a11
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.PrivateEndpointValidationResponse>> ValidateAsResponseAsync(
            global::System.Guid id,

            global::OpenRouter.ValidatePrivateEndpointRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate a draft private endpoint<br/>
        /// Send a live test request to the draft endpoint using the given workspace's BYOK credential for its provider. A passing validation is required before activation. Failed checks return 200 with `passed: false`. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// Stable identifier of the private endpoint.<br/>
        /// Example: 5b1c4c4e-7d0a-4a8e-9f3a-2d6c1b0e8a11
        /// </param>
        /// <param name="workspaceId">
        /// Workspace whose BYOK credential is used for the live validation call. The workspace must belong to your account.<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.PrivateEndpointValidationResponse> ValidateAsync(
            global::System.Guid id,
            global::System.Guid workspaceId,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}