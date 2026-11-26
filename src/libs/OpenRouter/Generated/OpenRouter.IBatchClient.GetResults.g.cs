#nullable enable

namespace OpenRouter
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Get batch results<br/>
        /// Returns a cursor-paginated page of normalized OpenRouter-format results for a finished batch. Pass the previous page's `next_cursor` as `cursor` to read the next page. Pages are stable across retries for the 30-day artifact retention window. See the [Batch API Quickstart](https://openrouter.ai/docs/batch-quickstart).
        /// </summary>
        /// <param name="id">
        /// The batch job id returned from submit.<br/>
        /// Example: batch_abc123
        /// </param>
        /// <param name="limit">
        /// Maximum number of result items to return, from 1 through 1000.<br/>
        /// Example: 500
        /// </param>
        /// <param name="cursor">
        /// Opaque pagination cursor from the previous page's `next_cursor`. Omit for the first page.<br/>
        /// Example: djE6YmF0Y2hfYWJjMTIzOjEwMjQ
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.BatchResultsPageResponse> GetResultsAsync(
            string id,
            int? limit = default,
            string? cursor = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get batch results<br/>
        /// Returns a cursor-paginated page of normalized OpenRouter-format results for a finished batch. Pass the previous page's `next_cursor` as `cursor` to read the next page. Pages are stable across retries for the 30-day artifact retention window. See the [Batch API Quickstart](https://openrouter.ai/docs/batch-quickstart).
        /// </summary>
        /// <param name="id">
        /// The batch job id returned from submit.<br/>
        /// Example: batch_abc123
        /// </param>
        /// <param name="limit">
        /// Maximum number of result items to return, from 1 through 1000.<br/>
        /// Example: 500
        /// </param>
        /// <param name="cursor">
        /// Opaque pagination cursor from the previous page's `next_cursor`. Omit for the first page.<br/>
        /// Example: djE6YmF0Y2hfYWJjMTIzOjEwMjQ
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.BatchResultsPageResponse>> GetResultsAsResponseAsync(
            string id,
            int? limit = default,
            string? cursor = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}