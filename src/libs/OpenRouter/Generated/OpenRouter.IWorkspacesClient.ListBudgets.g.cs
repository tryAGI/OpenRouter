#nullable enable

namespace OpenRouter
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// List workspace budgets<br/>
        /// List all budgets configured for a workspace. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="workspaceRef">
        /// The workspace ID (UUID) or slug<br/>
        /// Example: production
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ListWorkspaceBudgetsResponse> ListBudgetsAsync(
            string workspaceRef,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List workspace budgets<br/>
        /// List all budgets configured for a workspace. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="workspaceRef">
        /// The workspace ID (UUID) or slug<br/>
        /// Example: production
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ListWorkspaceBudgetsResponse>> ListBudgetsAsResponseAsync(
            string workspaceRef,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}