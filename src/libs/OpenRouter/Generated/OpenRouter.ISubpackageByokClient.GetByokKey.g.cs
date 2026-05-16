#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageByokClient
    {
        /// <summary>
        /// Get a BYOK provider credential<br/>
        /// Get a single bring-your-own-key (BYOK) provider credential by its `id`. Defaults to the authenticated entity's default workspace; use the `workspace_id` query parameter to scope to a different workspace. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="workspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.GetBYOKKeyResponse> GetByokKeyAsync(
            global::System.Guid id,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a BYOK provider credential<br/>
        /// Get a single bring-your-own-key (BYOK) provider credential by its `id`. Defaults to the authenticated entity's default workspace; use the `workspace_id` query parameter to scope to a different workspace. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="workspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.GetBYOKKeyResponse>> GetByokKeyAsResponseAsync(
            global::System.Guid id,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}