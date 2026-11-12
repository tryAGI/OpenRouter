#nullable enable

namespace OpenRouter
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Cancel a batch<br/>
        /// Asks the provider to stop a batch that is still running. Cancellation is enabled per organization; other organizations get `403`. The response is the batch in its current status: it stays `in_progress` until the provider confirms, then becomes `cancelled`, or `completed` when the provider finished it first. Repeating the call is safe. On OpenAI a cancelled batch keeps the requests that finished before the cancellation: they are returned in `results` and charged at the batch price. With your own provider key (BYOK), the provider charges your provider account for them. A Google Vertex batch is read the same way, but this has not been observed on a live cancelled job. On every other provider a cancelled batch has no results. See the [Batch API Quickstart](https://openrouter.ai/docs/batch-quickstart).
        /// </summary>
        /// <param name="id">
        /// The batch job id returned from submit.<br/>
        /// Example: batch_abc123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.BatchObject> CancelAsync(
            string id,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel a batch<br/>
        /// Asks the provider to stop a batch that is still running. Cancellation is enabled per organization; other organizations get `403`. The response is the batch in its current status: it stays `in_progress` until the provider confirms, then becomes `cancelled`, or `completed` when the provider finished it first. Repeating the call is safe. On OpenAI a cancelled batch keeps the requests that finished before the cancellation: they are returned in `results` and charged at the batch price. With your own provider key (BYOK), the provider charges your provider account for them. A Google Vertex batch is read the same way, but this has not been observed on a live cancelled job. On every other provider a cancelled batch has no results. See the [Batch API Quickstart](https://openrouter.ai/docs/batch-quickstart).
        /// </summary>
        /// <param name="id">
        /// The batch job id returned from submit.<br/>
        /// Example: batch_abc123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.BatchObject>> CancelAsResponseAsync(
            string id,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}