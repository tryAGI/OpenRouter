#nullable enable

namespace OpenRouter
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// List server tools<br/>
        /// Lists every server tool OpenRouter can run on behalf of a model: accepted `tools[].type` spellings per API format, the engines behind it with their pricing, and how many endpoints run it natively.
        /// </summary>
        /// <param name="offset">
        /// Number of records to skip for pagination. When both offset and limit are omitted, the full list is returned<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="limit">
        /// Maximum number of records to return (max 100). When both offset and limit are omitted, the full list is returned<br/>
        /// Default Value: 50<br/>
        /// Example: 50
        /// </param>
        /// <param name="apiFormat">
        /// Only tools usable on this API format<br/>
        /// Example: responses
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ListToolsResponse> ListToolsAsync(
            int? offset = default,
            int? limit = default,
            global::OpenRouter.ListToolsApiFormat? apiFormat = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List server tools<br/>
        /// Lists every server tool OpenRouter can run on behalf of a model: accepted `tools[].type` spellings per API format, the engines behind it with their pricing, and how many endpoints run it natively.
        /// </summary>
        /// <param name="offset">
        /// Number of records to skip for pagination. When both offset and limit are omitted, the full list is returned<br/>
        /// Default Value: 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="limit">
        /// Maximum number of records to return (max 100). When both offset and limit are omitted, the full list is returned<br/>
        /// Default Value: 50<br/>
        /// Example: 50
        /// </param>
        /// <param name="apiFormat">
        /// Only tools usable on this API format<br/>
        /// Example: responses
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ListToolsResponse>> ListToolsAsResponseAsync(
            int? offset = default,
            int? limit = default,
            global::OpenRouter.ListToolsApiFormat? apiFormat = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}