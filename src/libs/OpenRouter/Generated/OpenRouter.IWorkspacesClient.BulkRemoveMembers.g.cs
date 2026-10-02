#nullable enable

namespace OpenRouter
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Bulk remove members from a workspace<br/>
        /// Remove multiple members from a workspace. Members with active API keys in the workspace cannot be removed. SCIM-managed members cannot be removed; changes must be made in your identity provider. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// The workspace ID (UUID) or slug<br/>
        /// Example: production
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.BulkRemoveWorkspaceMembersResponse> BulkRemoveMembersAsync(
            string id,

            global::OpenRouter.BulkRemoveWorkspaceMembersRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk remove members from a workspace<br/>
        /// Remove multiple members from a workspace. Members with active API keys in the workspace cannot be removed. SCIM-managed members cannot be removed; changes must be made in your identity provider. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// The workspace ID (UUID) or slug<br/>
        /// Example: production
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.BulkRemoveWorkspaceMembersResponse>> BulkRemoveMembersAsResponseAsync(
            string id,

            global::OpenRouter.BulkRemoveWorkspaceMembersRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk remove members from a workspace<br/>
        /// Remove multiple members from a workspace. Members with active API keys in the workspace cannot be removed. SCIM-managed members cannot be removed; changes must be made in your identity provider. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// The workspace ID (UUID) or slug<br/>
        /// Example: production
        /// </param>
        /// <param name="userIds">
        /// List of user IDs to remove from the workspace<br/>
        /// Example: [user_abc123, user_def456]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.BulkRemoveWorkspaceMembersResponse> BulkRemoveMembersAsync(
            string id,
            global::System.Collections.Generic.IList<string> userIds,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}