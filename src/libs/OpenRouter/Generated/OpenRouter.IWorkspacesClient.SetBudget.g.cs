#nullable enable

namespace OpenRouter
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Create or update a workspace budget<br/>
        /// Create or update the budget for a given interval. Budget limits must strictly decrease as the interval narrows (lifetime &gt; monthly &gt; weekly &gt; daily). The optional `include_byok_in_budgets` flag is a workspace-wide setting: when provided it applies to every budget interval for the workspace, not just the interval in this request. Note that a change made here is applied to budget enforcement immediately, but an already-open workspace settings page in the web dashboard may keep showing the previous value until it is reloaded. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="workspaceRef">
        /// The workspace ID (UUID) or slug<br/>
        /// Example: production
        /// </param>
        /// <param name="interval">
        /// Budget reset interval. Use "lifetime" for a one-time budget that never resets.<br/>
        /// Example: monthly
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.UpsertWorkspaceBudgetResponse> SetBudgetAsync(
            string workspaceRef,
            global::OpenRouter.WorkspaceBudgetInterval interval,

            global::OpenRouter.UpsertWorkspaceBudgetRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or update a workspace budget<br/>
        /// Create or update the budget for a given interval. Budget limits must strictly decrease as the interval narrows (lifetime &gt; monthly &gt; weekly &gt; daily). The optional `include_byok_in_budgets` flag is a workspace-wide setting: when provided it applies to every budget interval for the workspace, not just the interval in this request. Note that a change made here is applied to budget enforcement immediately, but an already-open workspace settings page in the web dashboard may keep showing the previous value until it is reloaded. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="workspaceRef">
        /// The workspace ID (UUID) or slug<br/>
        /// Example: production
        /// </param>
        /// <param name="interval">
        /// Budget reset interval. Use "lifetime" for a one-time budget that never resets.<br/>
        /// Example: monthly
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.UpsertWorkspaceBudgetResponse>> SetBudgetAsResponseAsync(
            string workspaceRef,
            global::OpenRouter.WorkspaceBudgetInterval interval,

            global::OpenRouter.UpsertWorkspaceBudgetRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or update a workspace budget<br/>
        /// Create or update the budget for a given interval. Budget limits must strictly decrease as the interval narrows (lifetime &gt; monthly &gt; weekly &gt; daily). The optional `include_byok_in_budgets` flag is a workspace-wide setting: when provided it applies to every budget interval for the workspace, not just the interval in this request. Note that a change made here is applied to budget enforcement immediately, but an already-open workspace settings page in the web dashboard may keep showing the previous value until it is reloaded. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="workspaceRef">
        /// The workspace ID (UUID) or slug<br/>
        /// Example: production
        /// </param>
        /// <param name="interval">
        /// Budget reset interval. Use "lifetime" for a one-time budget that never resets.<br/>
        /// Example: monthly
        /// </param>
        /// <param name="includeByokInBudgets">
        /// Whether to include BYOK (bring-your-own-key) spend when enforcing the workspace's budgets. This is a workspace-wide setting: it applies to every budget interval (daily, weekly, monthly, and lifetime), not just the interval being upserted in this request. Omit to leave the current setting unchanged.<br/>
        /// Example: true
        /// </param>
        /// <param name="limitUsd">
        /// Spending limit in USD. Must be greater than 0.<br/>
        /// Example: 100
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.UpsertWorkspaceBudgetResponse> SetBudgetAsync(
            string workspaceRef,
            global::OpenRouter.WorkspaceBudgetInterval interval,
            double limitUsd,
            bool? includeByokInBudgets = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}