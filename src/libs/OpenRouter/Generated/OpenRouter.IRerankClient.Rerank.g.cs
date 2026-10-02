#nullable enable

namespace OpenRouter
{
    public partial interface IRerankClient
    {
        /// <summary>
        /// Submit a rerank request<br/>
        /// Submits a rerank request to the rerank router
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.CreateRerankResponse> RerankAsync(

            global::OpenRouter.CreateRerankRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit a rerank request<br/>
        /// Submits a rerank request to the rerank router
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.CreateRerankResponse>> RerankAsResponseAsync(

            global::OpenRouter.CreateRerankRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit a rerank request<br/>
        /// Submits a rerank request to the rerank router
        /// </summary>
        /// <param name="documents">
        /// The list of documents to rerank. Documents may be plain strings, or structured objects with `text` and/or `image` for multimodal models.<br/>
        /// Example: [Paris is the capital of France., Berlin is the capital of Germany.]
        /// </param>
        /// <param name="model">
        /// The rerank model to use<br/>
        /// Example: cohere/rerank-v3.5
        /// </param>
        /// <param name="provider"></param>
        /// <param name="query">
        /// The search query to rerank documents against<br/>
        /// Example: What is the capital of France?
        /// </param>
        /// <param name="sessionId">
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow). Used for observability grouping in Broadcast and private logging; never sent to the provider. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.<br/>
        /// Example: session-1234
        /// </param>
        /// <param name="topN">
        /// Number of most relevant documents to return<br/>
        /// Example: 3
        /// </param>
        /// <param name="trace">
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.<br/>
        /// Example: {"trace_id":"trace-abc123","trace_name":"my-app-trace"}
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user. Forwarded to Broadcast and private logging as the end-user id; never sent to the provider.<br/>
        /// Example: user-1234
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.CreateRerankResponse> RerankAsync(
            global::System.Collections.Generic.IList<global::OpenRouter.AnyOf<string, global::OpenRouter.CreateRerankRequestDocument>> documents,
            string model,
            string query,
            global::OpenRouter.AllOf<global::OpenRouter.ProviderPreferences, object>? provider = default,
            string? sessionId = default,
            int? topN = default,
            global::OpenRouter.TraceConfig? trace = default,
            string? user = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}