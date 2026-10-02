#nullable enable

namespace OpenRouter
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Delete a batch<br/>
        /// Deletes a batch in a terminal status (`completed`, `failed`, `expired`, or `cancelled`) and its stored requests and results. Batches still in progress return `409`. Billing and usage records are kept. See the [Batch API Quickstart](https://openrouter.ai/docs/batch-quickstart).
        /// </summary>
        /// <param name="id">
        /// The batch job id returned from submit.<br/>
        /// Example: batch_abc123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.BatchDeletedObject> DeleteAsync(
            string id,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a batch<br/>
        /// Deletes a batch in a terminal status (`completed`, `failed`, `expired`, or `cancelled`) and its stored requests and results. Batches still in progress return `409`. Billing and usage records are kept. See the [Batch API Quickstart](https://openrouter.ai/docs/batch-quickstart).
        /// </summary>
        /// <param name="id">
        /// The batch job id returned from submit.<br/>
        /// Example: batch_abc123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.BatchDeletedObject>> DeleteAsResponseAsync(
            string id,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}