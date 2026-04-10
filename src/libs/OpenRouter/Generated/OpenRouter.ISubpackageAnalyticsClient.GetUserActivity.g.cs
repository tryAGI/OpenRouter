#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageAnalyticsClient
    {
        /// <summary>
        /// Get user activity grouped by endpoint<br/>
        /// Returns user activity data grouped by endpoint for the last 30 (completed) UTC days. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="apiKeyHash"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ActivityResponse> GetUserActivityAsync(
            string? date = default,
            string? apiKeyHash = default,
            string? userId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}