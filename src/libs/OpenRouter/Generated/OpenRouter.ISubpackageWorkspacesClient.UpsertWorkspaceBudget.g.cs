#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageWorkspacesClient
    {
        /// <summary>
        /// Create or update a workspace budget<br/>
        /// Create or update the budget for a given interval. Budget limits must strictly decrease as the interval narrows (lifetime &gt; monthly &gt; weekly &gt; daily). [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="interval">
        /// Budget reset interval. Use "lifetime" for a one-time budget that never resets.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.UpsertWorkspaceBudgetResponse> UpsertWorkspaceBudgetAsync(
            string id,
            global::OpenRouter.WorkspaceBudgetInterval interval,

            global::OpenRouter.UpsertWorkspaceBudgetRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or update a workspace budget<br/>
        /// Create or update the budget for a given interval. Budget limits must strictly decrease as the interval narrows (lifetime &gt; monthly &gt; weekly &gt; daily). [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="interval">
        /// Budget reset interval. Use "lifetime" for a one-time budget that never resets.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.UpsertWorkspaceBudgetResponse>> UpsertWorkspaceBudgetAsResponseAsync(
            string id,
            global::OpenRouter.WorkspaceBudgetInterval interval,

            global::OpenRouter.UpsertWorkspaceBudgetRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or update a workspace budget<br/>
        /// Create or update the budget for a given interval. Budget limits must strictly decrease as the interval narrows (lifetime &gt; monthly &gt; weekly &gt; daily). [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="interval">
        /// Budget reset interval. Use "lifetime" for a one-time budget that never resets.
        /// </param>
        /// <param name="limitUsd">
        /// Spending limit in USD. Must be greater than 0.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.UpsertWorkspaceBudgetResponse> UpsertWorkspaceBudgetAsync(
            string id,
            global::OpenRouter.WorkspaceBudgetInterval interval,
            double limitUsd,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}