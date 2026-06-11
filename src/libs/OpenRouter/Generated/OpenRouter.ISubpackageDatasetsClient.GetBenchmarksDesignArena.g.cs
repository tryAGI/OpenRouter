#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageDatasetsClient
    {
        /// <summary>
        /// Design Arena Benchmark Rankings<br/>
        /// Returns ELO ratings from head-to-head arena battles on Design Arena. Filterable by arena (models/builders/agents) and category. Includes OpenRouter pricing per model. Authenticate with any valid OpenRouter API key. Rate-limited to 30 requests/minute per key and 500 requests/day per account.
        /// </summary>
        /// <param name="arena">
        /// Arena to query. Defaults to `models`.<br/>
        /// Default Value: models
        /// </param>
        /// <param name="category"></param>
        /// <param name="maxResults">
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.BenchmarksDAResponse> GetBenchmarksDesignArenaAsync(
            global::OpenRouter.DatasetsBenchmarksDesignArenaGetParametersArena? arena = default,
            string? category = default,
            int? maxResults = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Design Arena Benchmark Rankings<br/>
        /// Returns ELO ratings from head-to-head arena battles on Design Arena. Filterable by arena (models/builders/agents) and category. Includes OpenRouter pricing per model. Authenticate with any valid OpenRouter API key. Rate-limited to 30 requests/minute per key and 500 requests/day per account.
        /// </summary>
        /// <param name="arena">
        /// Arena to query. Defaults to `models`.<br/>
        /// Default Value: models
        /// </param>
        /// <param name="category"></param>
        /// <param name="maxResults">
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.BenchmarksDAResponse>> GetBenchmarksDesignArenaAsResponseAsync(
            global::OpenRouter.DatasetsBenchmarksDesignArenaGetParametersArena? arena = default,
            string? category = default,
            int? maxResults = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}