#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageWorkspacesClient
    {
        /// <summary>
        /// Bulk remove members from a workspace<br/>
        /// Remove multiple members from a workspace. Members with active API keys in the workspace cannot be removed. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.BulkRemoveWorkspaceMembersResponse> BulkRemoveWorkspaceMembersAsync(
            string id,

            global::OpenRouter.BulkRemoveWorkspaceMembersRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk remove members from a workspace<br/>
        /// Remove multiple members from a workspace. Members with active API keys in the workspace cannot be removed. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userIds">
        /// List of user IDs to remove from the workspace
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.BulkRemoveWorkspaceMembersResponse> BulkRemoveWorkspaceMembersAsync(
            string id,
            global::System.Collections.Generic.IList<string> userIds,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}