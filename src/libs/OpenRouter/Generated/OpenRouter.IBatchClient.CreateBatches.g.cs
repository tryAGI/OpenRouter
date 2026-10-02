#nullable enable

namespace OpenRouter
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Create a batch<br/>
        /// Creates a batch of requests that run asynchronously against a single endpoint (`/v1/chat/completions`, `/v1/responses`, `/v1/messages`, `/v1/embeddings`). Returns `202` with `status: "validating"`. Poll `GET /batches/{id}` for progress and results. See the [Batch API Quickstart](https://openrouter.ai/docs/batch-quickstart).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.BatchObject> CreateBatchesAsync(

            global::OpenRouter.BatchSubmitBody request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a batch<br/>
        /// Creates a batch of requests that run asynchronously against a single endpoint (`/v1/chat/completions`, `/v1/responses`, `/v1/messages`, `/v1/embeddings`). Returns `202` with `status: "validating"`. Poll `GET /batches/{id}` for progress and results. See the [Batch API Quickstart](https://openrouter.ai/docs/batch-quickstart).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.BatchObject>> CreateBatchesAsResponseAsync(

            global::OpenRouter.BatchSubmitBody request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a batch<br/>
        /// Creates a batch of requests that run asynchronously against a single endpoint (`/v1/chat/completions`, `/v1/responses`, `/v1/messages`, `/v1/embeddings`). Returns `202` with `status: "validating"`. Poll `GET /batches/{id}` for progress and results. See the [Batch API Quickstart](https://openrouter.ai/docs/batch-quickstart).
        /// </summary>
        /// <param name="completionWindow">
        /// Default Value: 24h
        /// </param>
        /// <param name="endpoint"></param>
        /// <param name="model"></param>
        /// <param name="provider">
        /// Batch provider routing preferences. Only `provider.only` is supported.<br/>
        /// Example: {"only":["google-vertex"]}
        /// </param>
        /// <param name="requests"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.BatchObject> CreateBatchesAsync(
            global::OpenRouter.BatchSubmitBodyEndpoint endpoint,
            string model,
            global::System.Collections.Generic.IList<global::OpenRouter.BatchSubmitBodyRequest> requests,
            global::OpenRouter.BatchSubmitBodyCompletionWindow? completionWindow = default,
            global::OpenRouter.BatchProviderPreferences? provider = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}