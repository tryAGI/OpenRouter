#nullable enable

namespace OpenRouter
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// List batches<br/>
        /// Lists batches in the workspace of the authenticating API key, newest first. To fetch the next page, pass the previous page's `last_id` as `after`. List items omit `results`. Use `GET /batches/{id}` to get them. See the [Batch API Quickstart](https://openrouter.ai/docs/batch-quickstart).
        /// </summary>
        /// <param name="limit">
        /// Maximum number of batches to return, from 1 through 100.<br/>
        /// Example: 20
        /// </param>
        /// <param name="after">
        /// Batch id from the previous page's `last_id`.<br/>
        /// Example: batch_7a4b02
        /// </param>
        /// <param name="status">
        /// Repeat this parameter to include more than one status.<br/>
        /// Example: [completed, failed]
        /// </param>
        /// <param name="createdAfter">
        /// Only include batches created strictly after this timestamp.<br/>
        /// Example: 2026-08-20T00:00:00Z
        /// </param>
        /// <param name="createdBefore"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.BatchListResponse> ListAsync(
            int? limit = default,
            string? after = default,
            global::System.Collections.Generic.IList<global::OpenRouter.BatchListStatus>? status = default,
            global::OpenRouter.BatchListTimestamp? createdAfter = default,
            global::OpenRouter.AllOf<global::OpenRouter.BatchListTimestamp?, object>? createdBefore = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List batches<br/>
        /// Lists batches in the workspace of the authenticating API key, newest first. To fetch the next page, pass the previous page's `last_id` as `after`. List items omit `results`. Use `GET /batches/{id}` to get them. See the [Batch API Quickstart](https://openrouter.ai/docs/batch-quickstart).
        /// </summary>
        /// <param name="limit">
        /// Maximum number of batches to return, from 1 through 100.<br/>
        /// Example: 20
        /// </param>
        /// <param name="after">
        /// Batch id from the previous page's `last_id`.<br/>
        /// Example: batch_7a4b02
        /// </param>
        /// <param name="status">
        /// Repeat this parameter to include more than one status.<br/>
        /// Example: [completed, failed]
        /// </param>
        /// <param name="createdAfter">
        /// Only include batches created strictly after this timestamp.<br/>
        /// Example: 2026-08-20T00:00:00Z
        /// </param>
        /// <param name="createdBefore"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.BatchListResponse>> ListAsResponseAsync(
            int? limit = default,
            string? after = default,
            global::System.Collections.Generic.IList<global::OpenRouter.BatchListStatus>? status = default,
            global::OpenRouter.BatchListTimestamp? createdAfter = default,
            global::OpenRouter.AllOf<global::OpenRouter.BatchListTimestamp?, object>? createdBefore = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}