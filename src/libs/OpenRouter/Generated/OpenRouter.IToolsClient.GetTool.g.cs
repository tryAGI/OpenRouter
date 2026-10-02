#nullable enable

namespace OpenRouter
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Get a server tool<br/>
        /// One server tool by canonical name or any accepted alias, with the models that run it natively.
        /// </summary>
        /// <param name="name">
        /// Canonical `openrouter:*` name or any accepted `tools[].type` alias<br/>
        /// Example: openrouter:web_search
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.GetToolResponse> GetToolAsync(
            string name,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a server tool<br/>
        /// One server tool by canonical name or any accepted alias, with the models that run it natively.
        /// </summary>
        /// <param name="name">
        /// Canonical `openrouter:*` name or any accepted `tools[].type` alias<br/>
        /// Example: openrouter:web_search
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.GetToolResponse>> GetToolAsResponseAsync(
            string name,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}