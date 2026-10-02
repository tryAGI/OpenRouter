#nullable enable

namespace OpenRouter
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Get a workspace budget<br/>
        /// Retrieve the budget for a given interval. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="workspaceRef">
        /// The workspace ID (UUID) or slug<br/>
        /// Example: production
        /// </param>
        /// <param name="interval">
        /// Budget reset interval. Use "lifetime" for a one-time budget that never resets.<br/>
        /// Example: monthly
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.GetWorkspaceBudgetResponse> GetBudgetAsync(
            string workspaceRef,
            global::OpenRouter.WorkspaceBudgetInterval interval,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a workspace budget<br/>
        /// Retrieve the budget for a given interval. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="workspaceRef">
        /// The workspace ID (UUID) or slug<br/>
        /// Example: production
        /// </param>
        /// <param name="interval">
        /// Budget reset interval. Use "lifetime" for a one-time budget that never resets.<br/>
        /// Example: monthly
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.GetWorkspaceBudgetResponse>> GetBudgetAsResponseAsync(
            string workspaceRef,
            global::OpenRouter.WorkspaceBudgetInterval interval,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}