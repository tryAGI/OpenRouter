#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageBetaAnalyticsClient
    {
        /// <summary>
        /// Query analytics data<br/>
        /// Execute an analytics query with specified metrics, dimensions, filters, and time range. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.BetaAnalyticsQueryAnalyticsResponse200> QueryAnalyticsAsync(

            global::OpenRouter.QueryAnalyticsRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query analytics data<br/>
        /// Execute an analytics query with specified metrics, dimensions, filters, and time range. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.BetaAnalyticsQueryAnalyticsResponse200>> QueryAnalyticsAsResponseAsync(

            global::OpenRouter.QueryAnalyticsRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query analytics data<br/>
        /// Execute an analytics query with specified metrics, dimensions, filters, and time range. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="dimensions"></param>
        /// <param name="filters"></param>
        /// <param name="granularity">
        /// Time granularity
        /// </param>
        /// <param name="groupLimit">
        /// Maximum rows per distinct combination of dimensions. When omitted on time-series queries (granularity + dimensions), auto-computed to avoid truncating time windows. Explicit values override the default and may truncate time buckets if set lower than the number of buckets in the range. Ignored when no dimensions are specified.
        /// </param>
        /// <param name="limit">
        /// Maximum total rows returned. Defaults to 1000. On time-series queries with dimensions and no explicit group_limit, the server may raise this to accommodate the expected number of unique time-bucket/dimension combinations.
        /// </param>
        /// <param name="metrics"></param>
        /// <param name="orderBy"></param>
        /// <param name="timeRange"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.BetaAnalyticsQueryAnalyticsResponse200> QueryAnalyticsAsync(
            global::System.Collections.Generic.IList<string> metrics,
            global::System.Collections.Generic.IList<string>? dimensions = default,
            global::System.Collections.Generic.IList<global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaFiltersItems>? filters = default,
            string? granularity = default,
            int? groupLimit = default,
            int? limit = default,
            global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaOrderBy? orderBy = default,
            global::OpenRouter.AnalyticsQueryPostRequestBodyContentApplicationJsonSchemaTimeRange? timeRange = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}