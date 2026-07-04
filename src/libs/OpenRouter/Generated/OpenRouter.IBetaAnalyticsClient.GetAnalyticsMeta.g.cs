#nullable enable

namespace OpenRouter
{
    public partial interface IBetaAnalyticsClient
    {
        /// <summary>
        /// Get available analytics metrics and dimensions<br/>
        /// Returns the available metrics, dimensions, filter operators, and granularities for the analytics query endpoint. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.BetaAnalyticsGetAnalyticsMetaResponse200> GetAnalyticsMetaAsync(
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get available analytics metrics and dimensions<br/>
        /// Returns the available metrics, dimensions, filter operators, and granularities for the analytics query endpoint. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.BetaAnalyticsGetAnalyticsMetaResponse200>> GetAnalyticsMetaAsResponseAsync(
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}