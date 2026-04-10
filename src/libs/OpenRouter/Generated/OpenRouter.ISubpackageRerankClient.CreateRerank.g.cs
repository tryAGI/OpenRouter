#nullable enable

namespace OpenRouter
{
    public partial interface ISubpackageRerankClient
    {
        /// <summary>
        /// Submit a rerank request<br/>
        /// Submits a rerank request to the rerank router
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.RerankCreateRerankResponse200> CreateRerankAsync(

            global::OpenRouter.CreateRerankRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit a rerank request<br/>
        /// Submits a rerank request to the rerank router
        /// </summary>
        /// <param name="documents">
        /// The list of documents to rerank
        /// </param>
        /// <param name="model">
        /// The rerank model to use
        /// </param>
        /// <param name="provider"></param>
        /// <param name="query">
        /// The search query to rerank documents against
        /// </param>
        /// <param name="topN">
        /// Number of most relevant documents to return
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.RerankCreateRerankResponse200> CreateRerankAsync(
            global::System.Collections.Generic.IList<string> documents,
            string model,
            string query,
            global::OpenRouter.RerankPostRequestBodyContentApplicationJsonSchemaProvider? provider = default,
            int? topN = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}