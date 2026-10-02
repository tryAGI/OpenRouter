#nullable enable

namespace OpenRouter
{
    public partial interface IBenchmarksClient
    {
        /// <summary>
        /// List Benchmarks<br/>
        /// Unified benchmark endpoint that aggregates scores from multiple benchmark sources (Artificial Analysis, Design Arena, and OpenRouter's own tau-bench, GPQA, and web-search evals). Filter by source to reproduce the exact shapes from the legacy per-source endpoints, or use task_type to find models suited for specific workloads. Use task_type=search (or a search_* benchmark_type) for OpenRouter's search benchmarks, which publish each model's highest-scoring eligible evaluation configuration with same-configuration runs combined by task-weighted mean. Authenticate with any valid OpenRouter API key. Rate-limited to 30 requests/minute per key and 500 requests/day per account.
        /// </summary>
        /// <param name="source">
        /// Benchmark source to query. Determines the shape of the returned items. When omitted, returns results from all sources.<br/>
        /// Example: artificial-analysis
        /// </param>
        /// <param name="taskType">
        /// Filter results by task type. For Artificial Analysis, maps to the corresponding index. For Design Arena, maps to the matching category. `search` returns OpenRouter search benchmark results only.<br/>
        /// Example: coding
        /// </param>
        /// <param name="benchmarkType">
        /// Return results for one exact OpenRouter benchmark. A `search_*` value narrows the response to search results only; a classic value narrows the OpenRouter items and leaves other sources' items as they are.<br/>
        /// Example: search_widesearch
        /// </param>
        /// <param name="includeRunConfig">
        /// Search benchmarks only: include the published lane configuration whitelist in each search item. Defaults to false. The whitelist is limited to agent turn count, reasoning effort, and temperature so future harness configuration changes do not change the public contract.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="searchEngine">
        /// OpenRouter search benchmarks only: filter by the search engine used.<br/>
        /// Example: exa
        /// </param>
        /// <param name="searchSurface">
        /// OpenRouter search benchmarks only: filter by the request surface the lane ran on.<br/>
        /// Example: server-tool
        /// </param>
        /// <param name="arena">
        /// Design Arena only: arena to query. Defaults to `models` when source is `design-arena`.<br/>
        /// Example: models
        /// </param>
        /// <param name="category">
        /// Design Arena only: category within the arena (e.g. `codecategories`, `uicomponent`, `gamedev`, `3d`, `dataviz`, `image`, `video`, `svg`). When omitted, returns all categories.<br/>
        /// Example: codecategories
        /// </param>
        /// <param name="maxResults">
        /// Maximum number of items to return. When omitted, all matching results are returned.<br/>
        /// Example: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.UnifiedBenchmarksResponse> GetBenchmarksAsync(
            global::OpenRouter.GetBenchmarksSource? source = default,
            global::OpenRouter.GetBenchmarksTaskType? taskType = default,
            global::OpenRouter.GetBenchmarksBenchmarkType? benchmarkType = default,
            bool? includeRunConfig = default,
            string? searchEngine = default,
            global::OpenRouter.GetBenchmarksSearchSurface? searchSurface = default,
            global::OpenRouter.GetBenchmarksArena? arena = default,
            string? category = default,
            int? maxResults = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Benchmarks<br/>
        /// Unified benchmark endpoint that aggregates scores from multiple benchmark sources (Artificial Analysis, Design Arena, and OpenRouter's own tau-bench, GPQA, and web-search evals). Filter by source to reproduce the exact shapes from the legacy per-source endpoints, or use task_type to find models suited for specific workloads. Use task_type=search (or a search_* benchmark_type) for OpenRouter's search benchmarks, which publish each model's highest-scoring eligible evaluation configuration with same-configuration runs combined by task-weighted mean. Authenticate with any valid OpenRouter API key. Rate-limited to 30 requests/minute per key and 500 requests/day per account.
        /// </summary>
        /// <param name="source">
        /// Benchmark source to query. Determines the shape of the returned items. When omitted, returns results from all sources.<br/>
        /// Example: artificial-analysis
        /// </param>
        /// <param name="taskType">
        /// Filter results by task type. For Artificial Analysis, maps to the corresponding index. For Design Arena, maps to the matching category. `search` returns OpenRouter search benchmark results only.<br/>
        /// Example: coding
        /// </param>
        /// <param name="benchmarkType">
        /// Return results for one exact OpenRouter benchmark. A `search_*` value narrows the response to search results only; a classic value narrows the OpenRouter items and leaves other sources' items as they are.<br/>
        /// Example: search_widesearch
        /// </param>
        /// <param name="includeRunConfig">
        /// Search benchmarks only: include the published lane configuration whitelist in each search item. Defaults to false. The whitelist is limited to agent turn count, reasoning effort, and temperature so future harness configuration changes do not change the public contract.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="searchEngine">
        /// OpenRouter search benchmarks only: filter by the search engine used.<br/>
        /// Example: exa
        /// </param>
        /// <param name="searchSurface">
        /// OpenRouter search benchmarks only: filter by the request surface the lane ran on.<br/>
        /// Example: server-tool
        /// </param>
        /// <param name="arena">
        /// Design Arena only: arena to query. Defaults to `models` when source is `design-arena`.<br/>
        /// Example: models
        /// </param>
        /// <param name="category">
        /// Design Arena only: category within the arena (e.g. `codecategories`, `uicomponent`, `gamedev`, `3d`, `dataviz`, `image`, `video`, `svg`). When omitted, returns all categories.<br/>
        /// Example: codecategories
        /// </param>
        /// <param name="maxResults">
        /// Maximum number of items to return. When omitted, all matching results are returned.<br/>
        /// Example: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.UnifiedBenchmarksResponse>> GetBenchmarksAsResponseAsync(
            global::OpenRouter.GetBenchmarksSource? source = default,
            global::OpenRouter.GetBenchmarksTaskType? taskType = default,
            global::OpenRouter.GetBenchmarksBenchmarkType? benchmarkType = default,
            bool? includeRunConfig = default,
            string? searchEngine = default,
            global::OpenRouter.GetBenchmarksSearchSurface? searchSurface = default,
            global::OpenRouter.GetBenchmarksArena? arena = default,
            string? category = default,
            int? maxResults = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}