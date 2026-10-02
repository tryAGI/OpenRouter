#nullable enable

namespace OpenRouter
{
    public partial interface IEmbeddingsClient
    {
        /// <summary>
        /// Submit an embedding request<br/>
        /// Submits an embedding request to the embeddings router
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.CreateEmbeddingsResponse> GenerateAsync(

            global::OpenRouter.CreateEmbeddingsRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit an embedding request<br/>
        /// Submits an embedding request to the embeddings router
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.CreateEmbeddingsResponse>> GenerateAsResponseAsync(

            global::OpenRouter.CreateEmbeddingsRequest request,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit an embedding request<br/>
        /// Submits an embedding request to the embeddings router
        /// </summary>
        /// <param name="dimensions">
        /// The number of dimensions for the output embeddings<br/>
        /// Example: 1536
        /// </param>
        /// <param name="encodingFormat">
        /// The format of the output embeddings<br/>
        /// Example: float
        /// </param>
        /// <param name="input">
        /// Text, token, or multimodal input(s) to embed<br/>
        /// Example: The quick brown fox jumps over the lazy dog
        /// </param>
        /// <param name="inputType">
        /// The type of input (e.g. search_query, search_document)<br/>
        /// Example: search_query
        /// </param>
        /// <param name="model">
        /// The model to use for embeddings<br/>
        /// Example: openai/text-embedding-3-small
        /// </param>
        /// <param name="provider"></param>
        /// <param name="sessionId">
        /// A unique identifier for grouping related requests (e.g., a conversation or agent workflow). Used for observability grouping in Broadcast and private logging; never sent to the provider. If provided in both the request body and the x-session-id header, the body value takes precedence. Maximum of 256 characters.<br/>
        /// Example: session-1234
        /// </param>
        /// <param name="trace">
        /// Metadata for observability and tracing. Known keys (trace_id, trace_name, span_name, generation_name, parent_span_id) have special handling. Additional keys are passed through as custom metadata to configured broadcast destinations.<br/>
        /// Example: {"trace_id":"trace-abc123","trace_name":"my-app-trace"}
        /// </param>
        /// <param name="user">
        /// A unique identifier for the end-user<br/>
        /// Example: user-1234
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.CreateEmbeddingsResponse> GenerateAsync(
            global::OpenRouter.AnyOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, global::System.Collections.Generic.IList<global::OpenRouter.CreateEmbeddingsRequestInputVariant5Item>> input,
            string model,
            int? dimensions = default,
            global::OpenRouter.CreateEmbeddingsRequestEncodingFormat? encodingFormat = default,
            string? inputType = default,
            global::OpenRouter.AllOf<global::OpenRouter.ProviderPreferences, object>? provider = default,
            string? sessionId = default,
            global::OpenRouter.TraceConfig? trace = default,
            string? user = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}