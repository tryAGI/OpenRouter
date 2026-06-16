#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageDatasetsClient
    {
        /// <summary>
        /// Artificial Analysis Benchmark Indices<br/>
        /// Returns composite index scores (Intelligence, Coding, Agentic) from Artificial Analysis for LLM models. Includes OpenRouter pricing per model. Authenticate with any valid OpenRouter API key. Rate-limited to 30 requests/minute per key and 500 requests/day per account.
        /// </summary>
        /// <param name="maxResults">
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.BenchmarksAAResponse> GetBenchmarksArtificialAnalysisAsync(
            int? maxResults = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Artificial Analysis Benchmark Indices<br/>
        /// Returns composite index scores (Intelligence, Coding, Agentic) from Artificial Analysis for LLM models. Includes OpenRouter pricing per model. Authenticate with any valid OpenRouter API key. Rate-limited to 30 requests/minute per key and 500 requests/day per account.
        /// </summary>
        /// <param name="maxResults">
        /// Default Value: 50
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.BenchmarksAAResponse>> GetBenchmarksArtificialAnalysisAsResponseAsync(
            int? maxResults = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}