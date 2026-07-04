#nullable enable

namespace OpenRouter
{
    public partial interface IBenchmarksClient
    {
        /// <summary>
        /// List Benchmarks<br/>
        /// Unified benchmark endpoint that aggregates scores from multiple benchmark sources (Artificial Analysis, Design Arena). Filter by source to reproduce the exact shapes from the legacy per-source endpoints, or use task_type to find models suited for specific workloads. Authenticate with any valid OpenRouter API key. Rate-limited to 30 requests/minute per key and 500 requests/day per account.
        /// </summary>
        /// <param name="source">
        /// Benchmark source to query. Determines the shape of the returned items. When omitted, returns results from all sources.
        /// </param>
        /// <param name="taskType">
        /// Filter results by task type. For Artificial Analysis, maps to the corresponding index. For Design Arena, maps to the matching category.
        /// </param>
        /// <param name="arena">
        /// Design Arena only: arena to query. Defaults to `models` when source is `design-arena`.
        /// </param>
        /// <param name="category"></param>
        /// <param name="maxResults"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.UnifiedBenchmarksResponse> GetBenchmarksAsync(
            global::OpenRouter.BenchmarksGetParametersSource? source = default,
            global::OpenRouter.BenchmarksGetParametersTaskType? taskType = default,
            global::OpenRouter.BenchmarksGetParametersArena? arena = default,
            string? category = default,
            int? maxResults = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Benchmarks<br/>
        /// Unified benchmark endpoint that aggregates scores from multiple benchmark sources (Artificial Analysis, Design Arena). Filter by source to reproduce the exact shapes from the legacy per-source endpoints, or use task_type to find models suited for specific workloads. Authenticate with any valid OpenRouter API key. Rate-limited to 30 requests/minute per key and 500 requests/day per account.
        /// </summary>
        /// <param name="source">
        /// Benchmark source to query. Determines the shape of the returned items. When omitted, returns results from all sources.
        /// </param>
        /// <param name="taskType">
        /// Filter results by task type. For Artificial Analysis, maps to the corresponding index. For Design Arena, maps to the matching category.
        /// </param>
        /// <param name="arena">
        /// Design Arena only: arena to query. Defaults to `models` when source is `design-arena`.
        /// </param>
        /// <param name="category"></param>
        /// <param name="maxResults"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.UnifiedBenchmarksResponse>> GetBenchmarksAsResponseAsync(
            global::OpenRouter.BenchmarksGetParametersSource? source = default,
            global::OpenRouter.BenchmarksGetParametersTaskType? taskType = default,
            global::OpenRouter.BenchmarksGetParametersArena? arena = default,
            string? category = default,
            int? maxResults = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}