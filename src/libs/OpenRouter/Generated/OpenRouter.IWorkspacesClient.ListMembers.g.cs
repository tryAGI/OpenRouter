#nullable enable

namespace OpenRouter
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// List workspace members<br/>
        /// List all members of a workspace. Returns paginated results. For the default workspace, returns all organization members (implicit membership). [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// The workspace ID (UUID) or slug<br/>
        /// Example: production
        /// </param>
        /// <param name="offset">
        /// Number of records to skip for pagination<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="limit">
        /// Maximum number of records to return (max 100)<br/>
        /// Default Value: 50<br/>
        /// Example: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ListWorkspaceMembersResponse> ListMembersAsync(
            string id,
            int? offset = default,
            int? limit = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List workspace members<br/>
        /// List all members of a workspace. Returns paginated results. For the default workspace, returns all organization members (implicit membership). [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id">
        /// The workspace ID (UUID) or slug<br/>
        /// Example: production
        /// </param>
        /// <param name="offset">
        /// Number of records to skip for pagination<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="limit">
        /// Maximum number of records to return (max 100)<br/>
        /// Default Value: 50<br/>
        /// Example: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ListWorkspaceMembersResponse>> ListMembersAsResponseAsync(
            string id,
            int? offset = default,
            int? limit = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}