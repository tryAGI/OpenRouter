#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageWorkspacesClient
    {
        /// <summary>
        /// Bulk add members to a workspace<br/>
        /// Add multiple organization members to a workspace. Members are assigned the same role they hold in the organization. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.BulkAddWorkspaceMembersResponse> BulkAddWorkspaceMembersAsync(
            string id,

            global::OpenRouter.BulkAddWorkspaceMembersRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk add members to a workspace<br/>
        /// Add multiple organization members to a workspace. Members are assigned the same role they hold in the organization. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userIds">
        /// List of user IDs to add to the workspace. Members are assigned the same role they hold in the organization.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.BulkAddWorkspaceMembersResponse> BulkAddWorkspaceMembersAsync(
            string id,
            global::System.Collections.Generic.IList<string> userIds,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}