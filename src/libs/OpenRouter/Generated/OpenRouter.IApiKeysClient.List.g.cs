#nullable enable

namespace OpenRouter
{
    public partial interface IApiKeysClient
    {
        /// <summary>
        /// List API keys<br/>
        /// List all API keys for the authenticated user. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="includeDisabled">
        /// Whether to include disabled API keys in the response<br/>
        /// Example: false
        /// </param>
        /// <param name="includeExpired">
        /// Whether to include expired API keys in the response. Expired keys are excluded by default and returned only when this is true.<br/>
        /// Example: false
        /// </param>
        /// <param name="offset">
        /// Number of API keys to skip for pagination<br/>
        /// Example: 0
        /// </param>
        /// <param name="workspaceId">
        /// Filter API keys by workspace ID. By default, keys in the default workspace are returned.<br/>
        /// Example: 0df9e665-d932-5740-b2c7-b52af166bc11
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.ListResponse> ListAsync(
            bool? includeDisabled = default,
            bool? includeExpired = default,
            int? offset = default,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List API keys<br/>
        /// List all API keys for the authenticated user. [Management key](/docs/guides/overview/auth/management-api-keys) required.
        /// </summary>
        /// <param name="includeDisabled">
        /// Whether to include disabled API keys in the response<br/>
        /// Example: false
        /// </param>
        /// <param name="includeExpired">
        /// Whether to include expired API keys in the response. Expired keys are excluded by default and returned only when this is true.<br/>
        /// Example: false
        /// </param>
        /// <param name="offset">
        /// Number of API keys to skip for pagination<br/>
        /// Example: 0
        /// </param>
        /// <param name="workspaceId">
        /// Filter API keys by workspace ID. By default, keys in the default workspace are returned.<br/>
        /// Example: 0df9e665-d932-5740-b2c7-b52af166bc11
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenRouter.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenRouter.AutoSDKHttpResponse<global::OpenRouter.ListResponse>> ListAsResponseAsync(
            bool? includeDisabled = default,
            bool? includeExpired = default,
            int? offset = default,
            global::System.Guid? workspaceId = default,
            global::OpenRouter.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}