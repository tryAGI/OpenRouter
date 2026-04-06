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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.RerankCreateRerankResponse200> CreateRerankAsync(

            global::OpenRouter.CreateRerankRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit a rerank request<br/>
        /// Submits a rerank request to the rerank router
        /// </summary>
        /// <param name="model">
        /// The rerank model to use
        /// </param>
        /// <param name="query">
        /// The search query to rerank documents against
        /// </param>
        /// <param name="documents">
        /// The list of documents to rerank
        /// </param>
        /// <param name="topN">
        /// Number of most relevant documents to return
        /// </param>
        /// <param name="provider">
        /// Provider routing preferences for the request.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.RerankCreateRerankResponse200> CreateRerankAsync(
            string model,
            string query,
            global::System.Collections.Generic.IList<string> documents,
            int? topN = default,
            global::OpenRouter.ProviderPreferences? provider = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}