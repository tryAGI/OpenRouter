#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageWorkspacesClient
    {
        /// <summary>
        /// Delete a workspace budget<br/>
        /// Remove the budget for a given interval. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="interval">
        /// Budget reset interval. Use "lifetime" for a one-time budget that never resets.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.DeleteWorkspaceBudgetResponse> DeleteWorkspaceBudgetAsync(
            string id,
            global::OpenRouter.WorkspaceBudgetInterval interval,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a workspace budget<br/>
        /// Remove the budget for a given interval. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="interval">
        /// Budget reset interval. Use "lifetime" for a one-time budget that never resets.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.DeleteWorkspaceBudgetResponse>> DeleteWorkspaceBudgetAsResponseAsync(
            string id,
            global::OpenRouter.WorkspaceBudgetInterval interval,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}