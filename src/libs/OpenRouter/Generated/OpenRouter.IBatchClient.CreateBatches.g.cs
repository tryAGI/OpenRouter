#nullable enable

namespace OpenRouter
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Create a batch<br/>
        /// Creates a batch of requests that run asynchronously against a single endpoint (`/v1/chat/completions`, `/v1/responses`, `/v1/messages`, `/v1/embeddings`, `/v1/audio/speech`). Returns `202` with `status: "validating"`. Poll `GET /batches/{id}` for progress and results. See the [Batch API Quickstart](https://openrouter.ai/docs/batch-quickstart).
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
        /// Creates a batch of requests that run asynchronously against a single endpoint (`/v1/chat/completions`, `/v1/responses`, `/v1/messages`, `/v1/embeddings`, `/v1/audio/speech`). Returns `202` with `status: "validating"`. Poll `GET /batches/{id}` for progress and results. See the [Batch API Quickstart](https://openrouter.ai/docs/batch-quickstart).
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
        /// Creates a batch of requests that run asynchronously against a single endpoint (`/v1/chat/completions`, `/v1/responses`, `/v1/messages`, `/v1/embeddings`, `/v1/audio/speech`). Returns `202` with `status: "validating"`. Poll `GET /batches/{id}` for progress and results. See the [Batch API Quickstart](https://openrouter.ai/docs/batch-quickstart).
        /// </summary>
        /// <param name="callbackUrl">
        /// HTTPS URL that receives a `batch.completed`, `batch.failed`, `batch.cancelled` or `batch.expired` webhook event when the batch reaches a terminal status. Must appear before `requests` in the request body.
        /// </param>
        /// <param name="completionWindow">
        /// Default Value: 24h
        /// </param>
        /// <param name="endpoint"></param>
        /// <param name="input">
        /// A batch input file or table in your own storage, named in place of `requests`. Available to allowlisted callers on Google Vertex BYOK endpoints only.
        /// </param>
        /// <param name="model"></param>
        /// <param name="provider">
        /// Batch provider routing preferences. Only `provider.only` and `provider.allow_fallbacks` are supported.<br/>
        /// Example: {"only":["google-vertex"]}
        /// </param>
        /// <param name="requests">
        /// The batch requests. Send exactly one of `requests` or `input`; `requests` must be the last field in the request body.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.BatchObject> CreateBatchesAsync(
            global::OpenRouter.BatchSubmitBodyEndpoint endpoint,
            string model,
            string? callbackUrl = default,
            global::OpenRouter.BatchSubmitBodyCompletionWindow? completionWindow = default,
            global::OpenRouter.BatchInputReference? input = default,
            global::OpenRouter.BatchProviderPreferences? provider = default,
            global::System.Collections.Generic.IList<global::OpenRouter.BatchSubmitBodyRequest>? requests = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}